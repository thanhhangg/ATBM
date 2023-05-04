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

        private readonly UserControlDashboard _userControlDashboard = new UserControlDashboard();
        private readonly UserControlListUser _userControlProfile = new UserControlListUser();
        private readonly UserControlSearch _userControlSearch = new UserControlSearch();
        private readonly UserControlLogin _userControlLogin = new UserControlLogin();
        private readonly UserControlSignUp _userControlSignUp = new UserControlSignUp();
        private readonly UserControlDemo _userControlDemo = new UserControlDemo();


        private static FormMain _instance;
        public static FormMain Instance => _instance ?? (_instance = new FormMain());

        private FormMain()
        {
            InitializeComponent();

            panelContainer.Controls.Add(_userControlDashboard);
            panelContainer.Controls.Add(_userControlProfile);
            panelContainer.Controls.Add(_userControlSearch);
            panelContainer.Controls.Add(_userControlLogin);
            panelContainer.Controls.Add(_userControlSignUp);
            panelContainer.Controls.Add(_userControlDemo);

            _userControlDashboard.Hide();
            _userControlProfile.Hide();
            _userControlSearch.Hide();
            _userControlSignUp.Hide();

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

            if (uc is UserControlDashboard)
                _userControlDashboard.BringToFront();
            else if (uc is UserControlListUser)
                _userControlProfile.BringToFront();
            else if (uc is UserControlSearch)
                _userControlSearch.BringToFront();
            else if (uc is UserControlLogin)
                _userControlLogin.BringToFront();
            else if (uc is UserControlSignUp)
                _userControlSignUp.BringToFront();
            else if (uc is UserControlDemo)
                _userControlDemo.BringToFront();

            uc.Show();
            _currentUserControl.Hide();
            _currentUserControl = uc;
        }

        public void OpenUcDashboard()
        {
            ActivateCurrentButtonNav(btnDashboard);
            ShowUc(_userControlDashboard);
            lblHeader.Text = "Dashboard";
        }

        public void OpenUcProfile()
        {
            ActivateCurrentButtonNav(btnProfile);
            ShowUc(_userControlProfile);
            lblHeader.Text = "Profile";
        }

        public void OpenUcSearch()
        {
            ActivateCurrentButtonNav(btnSearch);
            ShowUc(_userControlSearch);
            lblHeader.Text = "Search";
        }

        public void OpenUcLogin()
        {
            ActivateCurrentButtonNav(btnLogOut);
            ShowUc(_userControlLogin);
            lblHeader.Text = "Login";
            btnProfile.Visible = false;
            btnDashboard.Visible = false;
            btnSearch.Visible = false;
            lblUsername.Text = "";
        }

        public void OpenUcSignUp()
        {
            ActivateCurrentButtonNav(btnLogOut);
            ShowUc(_userControlSignUp);
            lblHeader.Text = "Sign Up";
        }

        public void OpenUc(UserControl uc, object sender, string header)
        {
            ActivateCurrentButtonNav(sender);
            ShowUc(uc);
            lblHeader.Text = header;
        }

        public void OpenUcAfterLogin()
        {
            _userControlLogin.Clear();
            btnProfile.Visible = true;
            btnSearch.Visible = true;
            btnDashboard.Visible = true;
            btnLogOut.Visible = true;
            OpenUcDashboard();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _userControlProfile.Clear(sender, e);
            _userControlSearch.Clear();
            OpenUcDashboard();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _userControlSearch.Clear();
            OpenUcProfile();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _userControlProfile.Clear(sender, e);
            OpenUcSearch();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            OpenUc(_userControlDemo, sender, "Demo");
            //btnDashboard.Visible = false;
            //btnProfile.Visible = false;
            //btnSearch.Visible = false;
            //btnLogOut.Visible = false;
            //OpenUcLogin();
        }

        #endregion
    }
}
