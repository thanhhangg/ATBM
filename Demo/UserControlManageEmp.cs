using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlManageEmp : UserControl, IResetUserControl
    {
        public bool isInvite = false;
        public UserControlManageEmp()
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

        private void UserControlManageEmp_Load(object sender, EventArgs e)
        {
            var pc = ApiRequest.GetAll<OracleProfile>("/users/qltt/phancong/\"3\"");

            var nv = ApiRequest.GetAll<OracleProfile>("/users/qltt/nhanvien/\"3\"");

            dgvListNV.AutoGenerateColumns = false;

            // dgvListNV
            // Tạo cột cho MANV
            DataGridViewTextBoxColumn colMANV = new DataGridViewTextBoxColumn();
            colMANV.DataPropertyName = "MANV";
            colMANV.HeaderText = "MANV";
            colMANV.Visible = true;
            dgvListNV.Columns.Add(colMANV);

            // Tạo cột cho TENNV
            DataGridViewTextBoxColumn colTENNV = new DataGridViewTextBoxColumn();
            colTENNV.DataPropertyName = "TENNV";
            colTENNV.HeaderText = "TENNV";
            colTENNV.Visible = true;
            dgvListNV.Columns.Add(colTENNV);

            // Tạo cột cho PHAI
            DataGridViewTextBoxColumn colPHAI = new DataGridViewTextBoxColumn();
            colPHAI.DataPropertyName = "PHAI";
            colPHAI.HeaderText = "PHAI";
            colPHAI.Visible = true;
            dgvListNV.Columns.Add(colPHAI);

            // Tạo cột cho NGAYSINH
            DataGridViewTextBoxColumn colNGAYSINH = new DataGridViewTextBoxColumn();
            colNGAYSINH.DataPropertyName = "NGAYSINH";
            colNGAYSINH.HeaderText = "NGAYSINH";
            colNGAYSINH.Visible = true;
            dgvListNV.Columns.Add(colNGAYSINH);

            // Tạo cột cho DIACHI
            DataGridViewTextBoxColumn colDIACHI = new DataGridViewTextBoxColumn();
            colDIACHI.DataPropertyName = "DIACHI";
            colDIACHI.HeaderText = "DIACHI";
            colDIACHI.Visible = true;
            dgvListNV.Columns.Add(colDIACHI);

            // Tạo cột cho SODT
            DataGridViewTextBoxColumn colSODT = new DataGridViewTextBoxColumn();
            colSODT.DataPropertyName = "SODT";
            colSODT.HeaderText = "SODT";
            colSODT.Visible = true;
            dgvListNV.Columns.Add(colSODT);

            // Tạo cột cho VAITRO
            DataGridViewTextBoxColumn colVAITRO = new DataGridViewTextBoxColumn();
            colVAITRO.DataPropertyName = "VAITRO";
            colVAITRO.HeaderText = "VAITRO";
            colVAITRO.Visible = true;
            dgvListNV.Columns.Add(colVAITRO);

            // Tạo cột cho MANQL
            DataGridViewTextBoxColumn colMANQL = new DataGridViewTextBoxColumn();
            colMANQL.DataPropertyName = "MANQL";
            colMANQL.HeaderText = "MANQL";
            colMANQL.Visible = true;
            dgvListNV.Columns.Add(colMANQL);

            // Tạo cột cho PHG
            DataGridViewTextBoxColumn colPHG = new DataGridViewTextBoxColumn();
            colPHG.DataPropertyName = "PHG";
            colPHG.HeaderText = "PHG";
            colPHG.Visible = true;
            dgvListNV.Columns.Add(colPHG);

            // dgvListPC
            dgvListPC.AutoGenerateColumns = false;

            // Tạo cột cho PHG
            DataGridViewTextBoxColumn colMANV2 = new DataGridViewTextBoxColumn();
            colMANV2.DataPropertyName = "MANV";
            colMANV2.HeaderText = "MANV";
            colMANV2.Visible = true;
            dgvListPC.Columns.Add(colMANV2);

            // Tạo cột cho MADA
            DataGridViewTextBoxColumn colMADA = new DataGridViewTextBoxColumn();
            colMADA.DataPropertyName = "MADA";
            colMADA.HeaderText = "MADA";
            colMADA.Visible = true;
            dgvListPC.Columns.Add(colMADA);

            // Tạo cột cho THOIGIAN
            DataGridViewTextBoxColumn colTHOIGIAN = new DataGridViewTextBoxColumn();
            colTHOIGIAN.DataPropertyName = "THOIGIAN";
            colTHOIGIAN.HeaderText = "THOIGIAN";
            colTHOIGIAN.Visible = true;
            dgvListPC.Columns.Add(colTHOIGIAN);

            dgvListNV.DataSource = nv;
            dgvListPC.DataSource = pc;
        }
    }
}
