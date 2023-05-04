using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlListUser : UserControl
    {
        //private ClientInfo profile = new ClientInfo();

        public UserControlListUser()
        {
            InitializeComponent();
        }

        //public void SetProfile(ClientInfo cli)
        //{
        //    profile = cli;
        //    txtUsername.Text = cli.Username;
        //    txtFullName.Text = cli.FullName;
        //    string[] dob = cli.DateOfBirth.Split('/');
        //    dtpDOB.Value = DateTime.ParseExact(cli.DateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //    txtNote.Text = cli.Note;
        //    txtPoint.Text = cli.Point.ToString();
        //}

        //public void ChangePassword(bool isChange, string fail)
        //{
        //    if (!isChange) MessageBox.Show(fail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    else btnCancel2.PerformClick();
        //}



        /* private void btnChange_Click(object sender, EventArgs e)
         {
             if (btnChange.Text == "Change")
             {
                 btnCancel.Enabled = true;
                 btnCancel.BackColor = Color.Salmon;
                 //txtFullName.Enabled = true;
                 //dtpDOB.Enabled = true;
                 //txtNote.Enabled = true;
                 btnChange.Text = "Save";
                 btnChange.BackColor = Color.PaleGreen;
             }
             else
             {
                 //profile.FullName = txtFullName.Text;
                 //profile.DateOfBirth = dtpDOB.Text;
                 //profile.Note = txtNote.Text;
                 //FormMain.Instance.UpdateClientInfo(profile);
                 //FormMain.Instance.SendRequest($"setup_info\0{profile.FullName}\0{profile.DateOfBirth}\0{profile.Note}\0{profile.Point}");
                 btnCancel.PerformClick();
             }
         }

         private void btnCancel_Click(object sender, EventArgs e)
         {
             //SetProfile(profile);
             btnCancel.BackColor = Color.Gray;
             btnCancel.Enabled = false;
             //txtFullName.Enabled = false;
             //dtpDOB.Enabled = false;
             //txtNote.Enabled = false;
             btnChange.Text = "Change";
             btnChange.BackColor = Color.Beige;
         }

         private void btnChangeSave2_Click(object sender, EventArgs e)
         {
             if (btnChange.Text == "Change")
             {
                 btnCancel.Enabled = true;
                 btnCancel.BackColor = Color.Salmon;
                 txtCurrentPassword.Enabled = true;
                 txtNewPassword.Enabled = true;
                 txtConfirmNewPassword.Enabled = true;
                 btnChange.Text = "Save";
                 btnChange.BackColor = Color.PaleGreen;
             }
             else
             {
                 if (txtCurrentPassword.Text == string.Empty || txtNewPassword.Text == string.Empty || txtConfirmNewPassword.Text != txtNewPassword.Text || txtConfirmNewPassword.Text == string.Empty)
                 {
                     MessageBox.Show("Change Password Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else
                 {
                     if (cbxEncrypt.Checked)
                     {
                         //FormMain.Instance.SendRequest($"changepassword\01\0{Encrypt.StringToHex(txtCurrentPassword.Text)}\0{Encrypt.StringToHex(txtNewPassword.Text)}");
                     }
                     else
                     {
                         //FormMain.Instance.SendRequest($"changepassword\00\0{txtCurrentPassword.Text}\0{txtNewPassword.Text}");
                     }

                 }

             }
         }

         private void btnCancel2_Click(object sender, EventArgs e)
         {
             btnCancel.BackColor = Color.Gray;
             btnCancel.Enabled = false;
             txtConfirmNewPassword.Text = string.Empty;
             txtNewPassword.Text = string.Empty;
             txtCurrentPassword.Text = string.Empty;
             txtCurrentPassword.Enabled = false;
             txtNewPassword.Enabled = false;
             txtConfirmNewPassword.Enabled = false;
             btnChange.Text = "Change";
             btnChange.BackColor = Color.Beige;
         }

         public void Clear(object sender, EventArgs e)
         {
             btnCancel1_Click(sender, e);
             btnCancel2_Click(sender, e);
         }*/
    }
}
