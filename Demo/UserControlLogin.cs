using System;
using System.Text.Json;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlLogin : UserControl, IResetUserControl
    {
        public static string username;
        public static string role;
        public UserControlLogin()
        {
            username = "";
            role = "";
            InitializeComponent();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                string usernameTmp = txtUsername.Text.ToString();
                string passwordTmp = txtPassword.Text.ToString();
                var data = new
                {
                    username = usernameTmp,
                    password = passwordTmp,
                };
                string jsonBody = JsonSerializer.Serialize(data);
                var result = ApiRequest.Post<object>("/users/login", jsonBody);
                Console.WriteLine(result.Status);
                if (result.Status == "completed")
                {
                    username = usernameTmp;
                    if (username != "PRO")
                    {
                        string[] userFindRole = username.Split('"');
                        Console.WriteLine(userFindRole[1]);
                        var getRole = ApiRequest.GetAll<RolePriv>("/users/roles/" + userFindRole[1]);
                        role = getRole[0].GrantedRole.ToString();
                    }
                    FormMain.Instance.OpenUcAfterLogin();
                }
                else
                {
                    MessageBox.Show("Username or Password invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                }
            }




            //if (cbxEncypt.Checked)
            //{
            //    FormMain.Instance.SendRequest($"login\0{Encrypt.StringToHex(txtUsername.Text)}\0{Encrypt.StringToHex(txtPassword.Text)}\01");
            //}
            //else
            //{
            //    FormMain.Instance.SendRequest($"login\0{txtUsername.Text}\0{txtPassword.Text}\00");
            //}
        }

        public void Reset()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }
    }
}
