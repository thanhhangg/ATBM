using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{
    public partial class UserControlSearch : UserControl, IResetUserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
        }

        private void UCSearch_Load(object sender, EventArgs e)
        {
            var roleNames = ApiRequest.GetAll<OracleRole>("/users/roles");
            var userNames = ApiRequest.GetAll<OracleUser>("/users/user-oracle");

            cbxSearchRoleName.DataSource = roleNames;
            cbxSearchRoleName.DisplayMember = "GrantedRole";
            cbxSearchRoleName.ValueMember = "GrantedRole";

            cbxSearchUserName.DataSource = userNames;
            cbxSearchUserName.DisplayMember = "Username";
            cbxSearchUserName.ValueMember = "Username";

            cbxSearchRoleName.SelectedIndex = -1;
            cbxSearchUserName.SelectedIndex = -1;
        }

        public void Reset()
        {
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roleName = cbxSearchRoleName.SelectedValue;

            if (roleName == null)
            {
                return;
            }

            var rolePrivs = ApiRequest.GetAll<RolePriv>($"/users/roles/{roleName}");
            var DBA_SYS_PRIVS = ApiRequest.GetAll<DBASysPriv>($"/users/dba-sys-privs/{roleName}");
            var DBA_TaB_PRIVS = ApiRequest.GetAll<DBATabPriv>($"/users/tabs/{roleName}");

            cbxSearchUserName.SelectedIndex = -1;
            dgvDBA_ROLE.DataSource = rolePrivs;
            dgvDBA_SYS_PRIVS.DataSource = DBA_SYS_PRIVS;
            dgvDBA_TAB.DataSource = DBA_TaB_PRIVS;
        }

        private void cbxSearchUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userName = cbxSearchUserName.SelectedValue;

            if (userName == null)
            {
                return;
            }

            var userPrivs = ApiRequest.GetAll<RolePriv>($"/users/roles/{userName}");
            var DBA_SYS_PRIVS = ApiRequest.GetAll<DBASysPriv>($"/users/dba-sys-privs/{userName}");
            var DBA_TaB_PRIVS = ApiRequest.GetAll<DBATabPriv>($"/users/tabs/{userName}");

            cbxSearchRoleName.SelectedIndex = -1;
            dgvDBA_ROLE.DataSource = userPrivs;
            dgvDBA_SYS_PRIVS.DataSource = DBA_SYS_PRIVS;
            dgvDBA_TAB.DataSource = DBA_TaB_PRIVS;
        }
    }
}
