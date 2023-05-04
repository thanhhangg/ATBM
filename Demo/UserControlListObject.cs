using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Demo
{
    public partial class UserControlListObject : UserControl, IResetUserControl
    {
        public bool isInvite = false;
        public UserControlListObject()
        {
            InitializeComponent();
        }

        public void Reset()
        {
        }

        private void cbxAddNew_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cbxAddNew_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void UserControlListObject_Load(object sender, EventArgs e)
        {
            var users = ApiRequest.GetAll<OracleUser>("/users/user-oracle");
            dgvListUser.DataSource = users;

            var roles = ApiRequest.GetAll<OracleRole>("/users/roles");
            dgvListRole.DataSource = roles;
        }

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            var role = txtNewRole.Text;

            if (string.Empty.Equals(role))
            {
                MessageBox.Show("Role cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new
            {
                role,
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/create-role", jsonBody);

            if (result == null || result.Status == "failed")
            {
                MessageBox.Show("Create role failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Create role successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var roles = ApiRequest.GetAll<OracleRole>("/users/roles");
                dgvListRole.DataSource = roles;
                txtNewRole.Clear();
            }
        }

        private void dgvListRole_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = dgvListRole.CurrentRow.Index;
            btnDeleteRole.Enabled = selectedIndex >= 0;
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            var currentRow = dgvListRole.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            var data = new
            {
                role = currentRow.Cells["GrantedRole"].Value.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/drop-role", jsonBody);

            if (result == null || result.Status == "failed")
            {
                MessageBox.Show("Delete role failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Delete role successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var roles = ApiRequest.GetAll<OracleRole>("/users/roles");
                dgvListRole.DataSource = roles;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var currentRow = dgvListUser.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            var data = new
            {
                userId = currentRow.Cells["Username"].Value.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/drop-user-db", jsonBody);

            if (result == null)
            {
                MessageBox.Show("Delete failed. An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Status == "failed")
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Delete successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var users = ApiRequest.GetAll<OracleUser>("/users/user-oracle");
                dgvListUser.DataSource = users;
            }
        }

        private void dgvListUser_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = dgvListUser.CurrentRow.Index;
            btnDeleteUser.Enabled = selectedIndex >= 0;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            var username = txtUsename.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = new
            {
                userId = username,
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/create-user-db", jsonBody);

            if (result == null)
            {
                MessageBox.Show("Create failed. An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Status == "failed")
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Create successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var users = ApiRequest.GetAll<OracleUser>("/users/user-oracle");
                dgvListUser.DataSource = users;
                txtUsename.Clear();
            }
        }
    }
}
