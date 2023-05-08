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
    public partial class UserControlPhongBanDeAn : UserControl
    {
        string mada, tenda, ngaybd, phong;
        public UserControlPhongBanDeAn()
        {
            InitializeComponent();
        }

        public void Reset()
        {
        }

        private void UserControlPhongBanDeAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var phongban = ApiRequest.GetAll<OraclePhongBan>("/users/nv/phongban");
<<<<<<< HEAD
            dgvPB.DataSource = phongban;

            var dean = ApiRequest.GetAll<OracleDeAn>("/users/nv/dean");
            dgvDA.DataSource = dean;
=======
            dgvPhongBan.DataSource = phongban;

            var dean = ApiRequest.GetAll<OracleDeAn>("/users/nv/dean");
            dgvDeAn.DataSource = dean;
>>>>>>> fcbd1bdca14bc9820de08a5f5df5f2c3c9f2ffbd
        }

        private void UserControlPhongBanDeAn_VisibleChanged(object sender, EventArgs e)
        {
            pn_AddNewPB.Enabled = Auth.GetInstance().Role == "NS";
            pn_UpdatePB.Enabled = Auth.GetInstance().Role == "NS";
            btnAdd.Visible = Auth.GetInstance().Role == "TRG_DA";
            btnRemove.Visible = Auth.GetInstance().Role == "TRG_DA";
            btnUpdate.Visible = Auth.GetInstance().Role == "TRG_DA";
        }

        private void BTN_NS_Create_Click(object sender, EventArgs e)
        {
            var tenPB = txtNewPhongBan.Text;
            var maTruongPB = txtNewTruongPhong.Text;

            if (string.IsNullOrEmpty(tenPB))
            {
                MessageBox.Show("Tên phòng ban không thể trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(maTruongPB))
            {
                MessageBox.Show("Mã trưởng phòng không thể trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = ApiRequest.Post<object>("/users/ns/phongban/insert", JsonSerializer.Serialize(new
            {
                username = Auth.GetInstance().Username,
                TENPB = tenPB,
                TRPHG = maTruongPB
            }));

            if (result == null || result.Status == "failed")
            {
                MessageBox.Show($"Tạo phòng ban thất bại. {result.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvPhongBan.DataSource = ApiRequest.GetAll<OraclePhongBan>("/users/nv/phongban");
                MessageBox.Show("Tạo phòng ban thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPhongBan.Clear();
                txtNewTruongPhong.Clear();
            }
        }

        private void BTN_NS_Update_Click(object sender, EventArgs e)
        {
            var maPB = txtUpdateMaPB.Text;
            var tenPB = txtUpdatePhongBan.Text;
            var maTruongPB = txtUpdateTruongPhong.Text;

            if (string.IsNullOrEmpty(maPB))
            {
                MessageBox.Show("Mã phòng ban không thể trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tenPB))
            {
                MessageBox.Show("Tên phòng ban không thể trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(maTruongPB))
            {
                MessageBox.Show("Mã trưởng phòng không thể trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = ApiRequest.Post<object>("/users/ns/phongban/update", JsonSerializer.Serialize(new
            {
                username = Auth.GetInstance().Username,
                MAPB = maPB,
                TENPB = tenPB,
                TRPHG = maTruongPB
            }));

            if (result == null || result.Status == "failed")
            {
                MessageBox.Show($"Cập nhật phòng ban thất bại. {result.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvPhongBan.DataSource = ApiRequest.GetAll<OraclePhongBan>("/users/nv/phongban");
                MessageBox.Show("Cật nhật phòng ban thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUpdatePhongBan.Clear();
                txtUpdateMaPB.Clear();
                txtUpdateTruongPhong.Clear();
            }
        }

        private void dgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            var currentRow = dgvPhongBan.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            var maPB = currentRow.Cells["MAPB"].Value.ToString();
            var tenPB = currentRow.Cells["TENPB"].Value.ToString();
            var maTruongPB = currentRow.Cells["TRPHG"].Value.ToString();

            txtUpdateMaPB.Text = maPB;
            txtUpdatePhongBan.Text = tenPB;
            txtUpdateTruongPhong.Text = maTruongPB;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddDA form = new FormAddDA();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDA.SelectedCells.Count > 0)
            {
                int rowIndex = dgvDA.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDA.Rows[rowIndex];
                mada = selectedRow.Cells["MADA"].Value.ToString();
                DialogResult message = MessageBox.Show("Bạn có muốn xóa mã đề án " + mada + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    var data = new
                    {
                        username = Auth.GetInstance().Username,
                        MADA = mada,
                    };
                    string jsonBody = JsonSerializer.Serialize(data);
                    var result = ApiRequest.Post<object>("/users/trgda/dean/delete", jsonBody);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDA.SelectedCells.Count > 0)
            {
                int rowIndex = dgvDA.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDA.Rows[rowIndex];
                mada = selectedRow.Cells["MADA"].Value.ToString();
                tenda = selectedRow.Cells["TENDA"].Value.ToString();
                ngaybd = selectedRow.Cells["NGAYBD"].Value.ToString();
                phong = selectedRow.Cells["PHONG"].Value.ToString();
                FormUpdateDA form = new FormUpdateDA(mada, tenda, ngaybd, phong);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
        }
    }
}
