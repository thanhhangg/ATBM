﻿using System;
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
    public partial class UserControlPhongBanDeAn : UserControl
    {
        public UserControlPhongBanDeAn()
        {
            InitializeComponent();
        }

        public void Reset()
        {
        }

        private void UserControlPhongBanDeAn_Load(object sender, EventArgs e)
        {
            var phongban = ApiRequest.GetAll<OraclePhongBan>("/users/nv/phongban");
            dgvListUser.DataSource = phongban;

            var dean = ApiRequest.GetAll<OracleDeAn>("/users/nv/dean");
            dgvListRole.DataSource = dean;
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            var currentRow = dgvListRole.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            var data = new
            {
                role = currentRow.Cells["GrantedRole"].Value.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/drop-role", jsonBody);

            if (result == null || result.Status == "failed")
            {
                MessageBox.Show("Delete role failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Delete role successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var roles = ApiRequest.GetAll<OracleRole>("/users/roles");
                dgvListRole.DataSource = roles;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var currentRow = dgvListUser.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            var data = new
            {
                userId = currentRow.Cells["Username"].Value.ToString(),
            };

            string jsonBody = JsonSerializer.Serialize(data);

            var result = ApiRequest.Post<object>("/users/drop-user-db", jsonBody);

            if (result == null)
            {
                MessageBox.Show("Delete failed. An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Status == "failed")
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Delete successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var users = ApiRequest.GetAll<OracleUser>("/users/user-oracle");
                dgvListUser.DataSource = users;
            }
        }

        private void UserControlPhongBanDeAn_VisibleChanged(object sender, EventArgs e)
        {
            pn_AddNewPB.Enabled = Auth.GetInstance().Role == "NS";
            pn_UpdatePB.Enabled = Auth.GetInstance().Role == "NS";
        }

        private void BTN_NS_Create_Click(object sender, EventArgs e)
        {

        }

        private void BTN_NS_Update_Click(object sender, EventArgs e)
        {

        }
    }
}