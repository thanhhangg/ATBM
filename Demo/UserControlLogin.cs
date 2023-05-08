using System;
using System.Text.Json;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlLogin : UserControl, IResetUserControl
    {
        public UserControlLogin()
        {
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

            var result = ApiRequest.Post("/users/login", JsonSerializer.Serialize(new
            {
                username = txtUsername.Text,
                password = txtPassword.Text,
            }));

            if (result == null || (string)result["status"] == "failed")
            {
                MessageBox.Show("Log in failed! Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            var auth = Auth.GetInstance();

            auth.Username = (string)result["username"];
            auth.Role = (string)result["role"];
            auth.IsAuth = true;

            FormMain.Instance.OpenUcAfterLogin();
        }

        public void Reset()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }
    }
}
