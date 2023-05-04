using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Demo
{
    public partial class FormMain : Form
    {
        private Button _currentButton;
        private UserControl _currentUserControl;

        private readonly UserControlListObject _userControlListObject = new UserControlListObject();
        private readonly UserControlGrant _userControlGrant = new UserControlGrant();
        private readonly UserControlSearch _userControlSearch = new UserControlSearch();
        private readonly UserControlLogin _userControlLogin = new UserControlLogin();
        private readonly UserControlListEmployee _userControlEmployee = new UserControlListEmployee();


        private static FormMain _instance;
        public static FormMain Instance => _instance ?? (_instance = new FormMain());

        private FormMain()
        {
            InitializeComponent();

            panelContainer.Controls.Add(_userControlListObject);
            panelContainer.Controls.Add(_userControlGrant);
            panelContainer.Controls.Add(_userControlSearch);
            panelContainer.Controls.Add(_userControlLogin);
            panelContainer.Controls.Add(_userControlEmployee);

            _userControlListObject.Hide();
            _userControlGrant.Hide();
            _userControlSearch.Hide();
            _userControlEmployee.Hide();
           
            
            _currentUserControl = _userControlLogin;
        }

        #region region handle button

        public void ActivateCurrentButtonNav(object btnSender)
        {
            if (btnSender == null || _currentButton == btnSender)
            {
                return;
            }

            DisableOtherButtonNav();
            _currentButton = (Button)btnSender;
            _currentButton.BackColor = Color.SlateGray;
        }

        private void DisableOtherButtonNav()
        {
            foreach (Control ctrl in panelNav.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = Color.FromArgb(40, 46, 52);
                }
            }
        }

        #endregion

        #region region handle user control

        public void ShowUc(UserControl uc)
        {
            if (_currentUserControl.Equals(uc))
                return;

            if (uc is UserControlListObject)
                _userControlListObject.BringToFront();
            else if (uc is UserControlGrant)
                _userControlGrant.BringToFront();
            else if (uc is UserControlSearch)
                _userControlSearch.BringToFront();
            else if (uc is UserControlLogin)
                _userControlLogin.BringToFront();
            else if (uc is UserControlListEmployee)
                _userControlEmployee.BringToFront();

            uc.Show();
            _currentUserControl.Hide();
            _currentUserControl = uc;
        }

        public void OpenUc(UserControl uc, object sender, string header)
        {
            ActivateCurrentButtonNav(sender);
            ShowUc(uc);
            lblHeader.Text = header;
        }

        public void OpenUcAfterLogin()
        {
            _userControlLogin.Reset();
            btnEmp.Visible = true;
            btnSearch.Visible = true;
            btnGrant.Visible = true;
            btnListObject.Visible = true;
            btnLogOut.Visible = true;
            OpenUc(_userControlListObject, btnListObject, "List Object");
        }

        #endregion

        #region region handle event
        // event kéo thả của panel header
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnListObject_Click(object sender, EventArgs e)
        {
            _userControlListObject.Reset();
            OpenUc(_userControlListObject, sender, "List Object");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _userControlSearch.Reset();
            OpenUc(_userControlSearch, sender, "Search An Object's Privileges");

        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            _userControlGrant.Reset();
            OpenUc(_userControlGrant, sender, "Grant Privileges");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnEmp.Visible = false;
            btnListObject.Visible = false;
            btnSearch.Visible = false;
            btnGrant.Visible = false;
            btnLogOut.Visible = false;

            OpenUc(_userControlLogin, sender, "Login Sever");
        }

        #endregion

        private void btnEmp_Click(object sender, EventArgs e)
        {
            _userControlEmployee.Reset();
            OpenUc(_userControlEmployee, sender, "Employees");
        }
    }
}
