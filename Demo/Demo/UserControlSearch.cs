using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void UCSearch_Load(object sender, EventArgs e)
        {
            cbxSearchField.SelectedIndex = 0;
        }

        public void Clear()
        {
            txtFullName.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtPoint.Text = string.Empty;
            txtUsername.Text = string.Empty;
            cbxSearchField.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }
    }
}
