using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlProfile : UserControl, IResetUserControl
    {
        public UserControlProfile()
        {
            InitializeComponent();
        }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            diachi.Visible = false;
            diachiTxt.Visible = true;
            ngaysinh.Visible = false;
            ngaysinhTxt.Visible = true;
            sdt.Visible = false;
            sdtTxt.Visible = true;
            Edit.Visible = true;
            update.Visible = false;

            LoadData();
        }

        public void LoadData()
        {
            var user = ApiRequest.GetAll<OracleProfile>("/users/nv/info/" + Auth.GetInstance().Username);
            id.Text = user[0].MANV.ToString();
            ten.Text = user[0].TENNV.ToString();
            phai.Text = user[0].PHAI.ToString();
            ngaysinhTxt.Text = user[0].NGAYSINH.ToString("dd-MMMM-yyyy");
            diachiTxt.Text = user[0].DIACHI.ToString();
            sdtTxt.Text = user[0].SODT.ToString();
            luong.Text = user[0].LUONG.ToString();
            phucap.Text = user[0].PHUCAP.ToString();
            vaitro.Text = user[0].VAITRO.ToString();
            manql.Text = user[0].MANQL.ToString();
            phong.Text = user[0].PHG.ToString();

            dgvPhanCong.AutoGenerateColumns = false;

            // Tạo cột cho MADA
            DataGridViewTextBoxColumn colMADA = new DataGridViewTextBoxColumn();
            colMADA.DataPropertyName = "MADA";
            colMADA.HeaderText = "MADA";
            colMADA.Visible = true;
            dgvPhanCong.Columns.Add(colMADA);

            // Tạo cột cho THOIGIAN
            DataGridViewTextBoxColumn colTHOIGIAN = new DataGridViewTextBoxColumn();
            colTHOIGIAN.DataPropertyName = "THOIGIAN";
            colTHOIGIAN.HeaderText = "THOIGIAN";
            colTHOIGIAN.Visible = true;
            dgvPhanCong.Columns.Add(colTHOIGIAN);

            dgvPhanCong.DataSource = user;
        }

        public void Reset()
        {
        }

        private void editDiaChi_Click(object sender, EventArgs e)
        {
            diachiTxt.Visible = false;
            diachi.Visible = true;
            diachi.Text = diachiTxt.Text;

            ngaysinhTxt.Visible = false;
            ngaysinh.Visible = true;
            ngaysinh.Text = ngaysinhTxt.Text;

            sdtTxt.Visible = false;
            sdt.Visible = true;
            sdt.Text = sdtTxt.Text;

            Edit.Visible = false;
            update.Visible = true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            var ngaySinhText = ngaysinh.Text;
            var diaChiText = diachi.Text;
            var sdtText = sdt.Text;
            Console.WriteLine(ngaySinhText);
            Console.WriteLine(diaChiText);
            Console.WriteLine(sdtText);

            DateTime ngaySinh = DateTime.Parse(ngaySinhText);

            var data = new
            {
                username = Auth.GetInstance().Username,
                NGAYSINH = ngaySinh.ToString("dd-MMMM-yyyy"),
                DIACHI = diaChiText.ToString(),
                SODT = sdtText.ToString(),
            };
            Console.WriteLine(data);
            string jsonBody = JsonSerializer.Serialize(data);
            Console.WriteLine(jsonBody);
            var result = ApiRequest.Post<object>("/users/nv/update-info", jsonBody);

            diachiTxt.Visible = true;
            diachi.Visible = false;
            diachiTxt.Text = diaChiText;

            ngaysinhTxt.Visible = true;
            ngaysinh.Visible = false;
            ngaysinhTxt.Text = ngaySinhText;

            sdtTxt.Visible = true;
            sdt.Visible = false;
            sdtTxt.Text = sdtText;

            Edit.Visible = true;
            update.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void id_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void diachiTxt_Click(object sender, EventArgs e)
        {

        }

        private void phai_Click(object sender, EventArgs e)
        {

        }

        private void ngaysinhTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
