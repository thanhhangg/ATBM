using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlListEmployee : UserControl, IResetUserControl
    {
        private bool isAdding = false;
        private bool isUpdating = false;

        public UserControlListEmployee()
        {
            InitializeComponent();
        }

        public void Reset()
        {
        }

        private void UserControlListEmployee_LoadAsync(object sender, EventArgs e)
        {
            LoadListEmployees();
        }

        private void LoadListEmployees()
        {
            var employees = ApiRequest.GetAll<Employee>("/users");
            dgvListEmployees.DataSource = employees;

            dgvListEmployees.AutoGenerateColumns = false;

            if (dgvListEmployees.Columns.Contains("Luong"))
            {
                dgvListEmployees.Columns.Remove("Luong");
            }

            if (dgvListEmployees.Columns.Contains("PhuCap"))
            {
                dgvListEmployees.Columns.Remove("PhuCap");
            }
        }

        private void dgvListEmployees_SelectionChanged(object sender, EventArgs e)
        {
            LoadCurrentRow();
        }

        private void LoadCurrentRow()
        {
            var currentRow = dgvListEmployees.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            var maNV = currentRow.Cells["MaNV"].Value.ToString();
            var ten = currentRow.Cells["TenNV"].Value.ToString();
            var phai = currentRow.Cells["Phai"].Value.ToString();
            var ngaySinh = currentRow.Cells["NgaySinh"].Value.ToString();
            var diaChi = currentRow.Cells["DiaChi"].Value.ToString();
            var sdt = currentRow.Cells["SoDT"].Value.ToString();
            var vaiTro = currentRow.Cells["VaiTro"].Value.ToString();
            var maNQL = currentRow.Cells["MaNQL"].Value == null ? "" : currentRow.Cells["MaNQL"].Value.ToString();
            var maPhong = currentRow.Cells["PHG"].Value == null ? "" : currentRow.Cells["PHG"].Value.ToString();

            txtMaNV.Text = maNV;
            txtTen.Text = ten;
            cbxPhai.SelectedIndex = cbxPhai.FindString(phai);
            dtNgaySinh.Value = DateTime.Parse(ngaySinh);
            txtDiaChi.Text = diaChi;
            txtSdt.Text = sdt;
            txtVaiTro.Text = vaiTro;
            txtNQL.Text = maNQL;
            txtPhongBan.Text = maPhong;
        }

        private void setFieldsState(bool enabled, bool isClear = false)
        {
            txtTen.Enabled = enabled;
            cbxPhai.Enabled = enabled;
            dtNgaySinh.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
            txtSdt.Enabled = enabled;
            txtVaiTro.Enabled = enabled;
            txtNQL.Enabled = enabled;
            txtPhongBan.Enabled = enabled;

            if (isClear)
            {
                txtMaNV.Clear();
                txtTen.Clear();
                cbxPhai.SelectedIndex = -1;
                dtNgaySinh.Value = DateTime.Now;
                txtDiaChi.Clear();
                txtSdt.Clear();
                txtVaiTro.Clear();
                txtNQL.Clear();
                txtPhongBan.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setFieldsState(true, true);

            isAdding = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            grb_SaveCancel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            setFieldsState(true, false);

            isUpdating = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            grb_SaveCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvListEmployees.CurrentRow != null)
            {
                LoadCurrentRow();
                setFieldsState(false, false);
            }
            else
            {
                setFieldsState(false, true);
            }

            isAdding = false;
            isUpdating = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            grb_SaveCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var maNV = txtMaNV.Text;
            var ten = txtTen.Text;
            var ngaySinh = dtNgaySinh.Value;
            var diaChi = txtDiaChi.Text;
            var sdt = txtSdt.Text;
            var vaiTro = txtVaiTro.Text;
            var nql = txtNQL.Text;
            var phongBan = txtPhongBan.Text;

            if (string.IsNullOrEmpty(ten)
                || cbxPhai.SelectedIndex == -1
                || string.IsNullOrEmpty(diaChi)
                || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Các trường tên, phái, địa chỉ, số điện thoại, vai trò không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isUpdating && string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Mã nhân viên không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isAdding)
            {
                var result = ApiRequest.Post<object>("/users/ns/nhanvien/insert", JsonSerializer.Serialize(new
                {
                    username = Auth.GetInstance().Username,
                    TENNV = ten,
                    NGAYSINH = ngaySinh.ToString("dd/MMM/yyyy"),
                    PHAI = cbxPhai.Text,
                    DIACHI = diaChi,
                    SODT = sdt,
                    VAITRO = vaiTro,
                    MANQL = string.IsNullOrEmpty(nql) ? null : nql,
                    PHG = string.IsNullOrEmpty(phongBan) ? null : phongBan,
                }));

                if (result == null || result.Status == "failed")
                {
                    MessageBox.Show($"Thêm nhân viên thất bại. {result.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListEmployees();

                    isAdding = false;
                    isUpdating = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    grb_SaveCancel.Enabled = false;
                }
            }
            else if (isUpdating)
            {

            }
        }
    }
}
