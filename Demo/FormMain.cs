using System;
using System.Data;
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
        private readonly UserControlProfile _userControlProfile = new UserControlProfile();
        private readonly UserControlManageEmp _userControlManageEmp = new UserControlManageEmp();
        private readonly UserControlPhongBanDeAn _userControlPhongBanDeAn = new UserControlPhongBanDeAn();


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
            panelContainer.Controls.Add(_userControlProfile);
            panelContainer.Controls.Add(_userControlManageEmp);
            panelContainer.Controls.Add(_userControlPhongBanDeAn);

            _userControlListObject.Hide();
            _userControlGrant.Hide();
            _userControlSearch.Hide();
            _userControlEmployee.Hide();
            _userControlProfile.Hide();
            _userControlManageEmp.Hide();
            _userControlPhongBanDeAn.Hide();

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
            else if (uc is UserControlProfile)
                _userControlProfile.BringToFront();
            else if (uc is UserControlManageEmp)
                _userControlManageEmp.BringToFront();
            else if (uc is UserControlPhongBanDeAn)
                _userControlPhongBanDeAn.BringToFront();

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
            if (Auth.GetInstance().Username == "PRO")
            {
                btnEmp.Visible = true;
                btnSearch.Visible = true;
                btnGrant.Visible = true;
                btnListObject.Visible = true;
                btnLogOut.Visible = true;
                btnProfile.Visible = false;
                btnListEmpForManage.Visible = false;
                btnPhongBanDeAn.Visible = false;
                OpenUc(_userControlListObject, btnListObject, "List Object");
            }
            else
            {
                btnEmp.Visible = Auth.GetInstance().Role == "NS";
                btnSearch.Visible = false;
                btnGrant.Visible = false;
                btnListObject.Visible = false;
                btnLogOut.Visible = true;
                btnProfile.Visible = true;
                btnPhongBanDeAn.Visible = true;
                btnListEmpForManage.Visible = Auth.GetInstance().Role == "QL_TT";
                _userControlProfile.LoadData();
                _userControlManageEmp.LoadData();
                _userControlPhongBanDeAn.LoadData();
                OpenUc(_userControlProfile, btnProfile, "Profile");
            }
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
            btnProfile.Visible = false;
            btnListEmpForManage.Visible = false;
            btnPhongBanDeAn.Visible = false;
            Auth.GetInstance().LogOut();
            OpenUc(_userControlLogin, sender, "Login Sever");
        }

        #endregion

        private void btnEmp_Click(object sender, EventArgs e)
        {
            _userControlEmployee.Reset();
            OpenUc(_userControlEmployee, sender, "Employees");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _userControlProfile.Reset();
            OpenUc(_userControlProfile, sender, "Profile");
        }

        private void btnListEmpForManage_Click(object sender, EventArgs e)
        {
            _userControlManageEmp.Reset();
            OpenUc(_userControlManageEmp, sender, "List Employee");
        }

        private void btnPhongBanDeAn_Click(object sender, EventArgs e)
        {
            _userControlPhongBanDeAn.Reset();
            OpenUc(_userControlPhongBanDeAn, sender, "Phong Ban Va De An");
        }

    }
}
