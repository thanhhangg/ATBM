using System;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;
using System.Linq;
using System.Xml;
using System.Collections.Generic;

namespace Demo
{
    public partial class UserControlGrant : UserControl, IResetUserControl
    {
        private static readonly string[] Privileges = { "SELECT", "UPDATE", "INSERT", "DELETE" };

        public UserControlGrant()
        {
            InitializeComponent();
        }

        public void Reset()
        {
        }

        private void UserControlGrant_Load(object sender, EventArgs e)
        {
            var roleNames = ApiRequest.GetAll<OracleRole>("/users/roles");
            var userNames = ApiRequest.GetAll<OracleUser>("/users/user-oracle");
            var objectNames = ApiRequest.GetAll<string>("/users/tables");

            cbxGrantRoleName.DataSource = roleNames;
            cbxGrantRoleName.DisplayMember = "GrantedRole";
            cbxGrantRoleName.ValueMember = "GrantedRole";

            cbxGrantPriRoleName.DataSource = new List<OracleRole>(roleNames);
            cbxGrantPriRoleName.DisplayMember = "GrantedRole";
            cbxGrantPriRoleName.ValueMember = "GrantedRole";

            cbxRevokePriRoleName.DataSource = new List<OracleRole>(roleNames);
            cbxRevokePriRoleName.DisplayMember = "GrantedRole";
            cbxRevokePriRoleName.ValueMember = "GrantedRole";

            cbxGrantPriObjectName.DataSource = objectNames;
            cbxRevokePriObjectName.DataSource = new List<string>(objectNames);

            cbxUserNameGrantRole.DataSource = userNames;
            cbxUserNameGrantRole.DisplayMember = "Username";
            cbxUserNameGrantRole.ValueMember = "Username";

            cbxRevokeRoleName.DataSource = new List<OracleRole>(roleNames);
            cbxRevokeRoleName.DisplayMember = "GrantedRole";
            cbxRevokeRoleName.ValueMember = "GrantedRole";

            cbxRevokeRoleUsername.DataSource = new List<OracleUser>(userNames);
            cbxRevokeRoleUsername.DisplayMember = "Username";
            cbxRevokeRoleUsername.ValueMember = "Username";

            cbxReVokePriName.DataSource = new List<OracleUser>(userNames);
            cbxReVokePriName.DisplayMember = "Username";
            cbxReVokePriName.ValueMember = "Username";

            cbxGrantPriPriName.DataSource = Privileges.ToList();
            cbxReVokePriName.DataSource  = Privileges.ToList();

            cbxGrantRoleName.SelectedIndex = -1;
            cbxUserNameGrantRole.SelectedIndex = -1;
            cbxGrantPriPriName.SelectedIndex = -1;
            cbxReVokePriName.SelectedIndex = -1;
            cbxGrantPriRoleName.SelectedIndex = -1;
            cbxGrantPriObjectName.SelectedIndex = -1;
            cbxRevokeRoleName.SelectedIndex = -1;
            cbxRevokeRoleUsername.SelectedIndex = -1;
            cbxRevokePriRoleName.SelectedIndex = -1;
            cbxRevokePriObjectName.SelectedIndex = -1;
        }

        private void btnGrantSaveRole_Click(object sender, EventArgs e)
        {
            if (cbxGrantRoleName.SelectedIndex == -1 || cbxUserNameGrantRole.SelectedIndex == -1)
            {
                return;
            }

            string role = cbxGrantRoleName.SelectedValue.ToString();
            string userId = cbxUserNameGrantRole.SelectedValue.ToString();
            bool isGrantOption = cbxAdOptGrantRole.Checked;

            var data = new
            {
                role,
                userId,
                isGrantOption
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<RolePriv[]>("/users/grant-role", jsonBody);

            if (result != null)
            {
                MessageBox.Show("Grant success");
            }
            else
            {
                MessageBox.Show("Grant failed");
            }
        }

        private void btnGrantSavePri_Click(object sender, EventArgs e)
        {
            var role = cbxGrantPriRoleName.SelectedValue;
            var privilege = cbxGrantPriPriName.SelectedValue;
            var objectName = cbxGrantPriObjectName.SelectedValue;

            if (role == null ||  privilege == null || objectName == null)
            {
                MessageBox.Show("Please select all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new
            {
                userId = role.ToString(),
                privilege = privilege.ToString(),
                table = objectName.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/grant-table", jsonBody);

            if (result == null)
            {
                MessageBox.Show("Grant failed. An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Status == "failed")
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Grant success");
            }
        }

        private void btnRevokePri_Click(object sender, EventArgs e)
        {
            var role = cbxRevokePriRoleName.SelectedValue;
            var privilege = cbxReVokePriName.SelectedValue;
            var objectName = cbxRevokePriObjectName.SelectedValue;

            if (role == null || privilege == null || objectName == null)
            {
                MessageBox.Show("Please select all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new
            {
                userId = role.ToString(),
                privilege = privilege.ToString(),
                table = objectName.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/revoke-table", jsonBody);

            if (result == null)
            {
                MessageBox.Show("Revoke failed. An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Status == "failed")
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Revoke success");
            }
        }

        private void btnRevokeRoleUser_Click(object sender, EventArgs e)
        {
            var role = cbxRevokeRoleName.SelectedValue;
            var username = cbxRevokeRoleUsername.SelectedValue;

            if (role == null || username == null)
            {
                MessageBox.Show("Please select all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new
            {
                role = role.ToString(),
                userId = username.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/revoke-role", jsonBody);

            if (result == null)
            {
                MessageBox.Show("Revoke failed. An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Status == "failed")
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Revoke success");
            }
        }
    }
}
