namespace Demo
{
    partial class UserControlListEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListEmployees = new System.Windows.Forms.DataGridView();
            this.pn_NHANVIEN = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNHANVIEN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgaySinhNHANVIEN = new System.Windows.Forms.DateTimePicker();
            this.txtSdtNHANVIEN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVaiTroNHANVIEN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxPhaiNHANVIEN = new System.Windows.Forms.ComboBox();
            this.cbxNQLNHANVIEN = new System.Windows.Forms.ComboBox();
            this.cbxPHGBANNHANVIEN = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grb_SaveCancel = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.pn_NHANVIEN.SuspendLayout();
            this.grb_SaveCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvListEmployees);
            this.panel2.Location = new System.Drawing.Point(49, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 680);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 72;
            this.label2.Text = "LIST EMPLOYEE";
            // 
            // dgvListEmployees
            // 
            this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployees.Location = new System.Drawing.Point(3, 45);
            this.dgvListEmployees.MultiSelect = false;
            this.dgvListEmployees.Name = "dgvListEmployees";
            this.dgvListEmployees.ReadOnly = true;
            this.dgvListEmployees.RowHeadersWidth = 51;
            this.dgvListEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListEmployees.Size = new System.Drawing.Size(774, 630);
            this.dgvListEmployees.TabIndex = 0;
            this.dgvListEmployees.SelectionChanged += new System.EventHandler(this.dgvListEmployees_SelectionChanged);
            // 
            // pn_NHANVIEN
            // 
            this.pn_NHANVIEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NHANVIEN.Controls.Add(this.grb_SaveCancel);
            this.pn_NHANVIEN.Controls.Add(this.btnUpdate);
            this.pn_NHANVIEN.Controls.Add(this.cbxPHGBANNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.cbxNQLNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.cbxPhaiNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.label12);
            this.pn_NHANVIEN.Controls.Add(this.label11);
            this.pn_NHANVIEN.Controls.Add(this.txtVaiTroNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.label10);
            this.pn_NHANVIEN.Controls.Add(this.txtSdtNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.label9);
            this.pn_NHANVIEN.Controls.Add(this.dtNgaySinhNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.txtDiaChiNV);
            this.pn_NHANVIEN.Controls.Add(this.label8);
            this.pn_NHANVIEN.Controls.Add(this.label7);
            this.pn_NHANVIEN.Controls.Add(this.label6);
            this.pn_NHANVIEN.Controls.Add(this.btnAdd);
            this.pn_NHANVIEN.Controls.Add(this.label3);
            this.pn_NHANVIEN.Controls.Add(this.txtTenNHANVIEN);
            this.pn_NHANVIEN.Controls.Add(this.label5);
            this.pn_NHANVIEN.Location = new System.Drawing.Point(859, 43);
            this.pn_NHANVIEN.Name = "pn_NHANVIEN";
            this.pn_NHANVIEN.Size = new System.Drawing.Size(482, 608);
            this.pn_NHANVIEN.TabIndex = 75;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Beige;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(314, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 30);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 28);
            this.label3.TabIndex = 69;
            this.label3.Text = "Thông tin NHANVIEN";
            // 
            // txtTenNHANVIEN
            // 
            this.txtTenNHANVIEN.Location = new System.Drawing.Point(27, 79);
            this.txtTenNHANVIEN.MaxLength = 20;
            this.txtTenNHANVIEN.Name = "txtTenNHANVIEN";
            this.txtTenNHANVIEN.Size = new System.Drawing.Size(255, 22);
            this.txtTenNHANVIEN.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Phái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Ngày sinh:";
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(27, 188);
            this.txtDiaChiNV.MaxLength = 20;
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(328, 22);
            this.txtDiaChiNV.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Địa chỉ:";
            // 
            // dtNgaySinhNHANVIEN
            // 
            this.dtNgaySinhNHANVIEN.Location = new System.Drawing.Point(26, 137);
            this.dtNgaySinhNHANVIEN.Name = "dtNgaySinhNHANVIEN";
            this.dtNgaySinhNHANVIEN.Size = new System.Drawing.Size(250, 22);
            this.dtNgaySinhNHANVIEN.TabIndex = 79;
            // 
            // txtSdtNHANVIEN
            // 
            this.txtSdtNHANVIEN.Location = new System.Drawing.Point(28, 245);
            this.txtSdtNHANVIEN.MaxLength = 20;
            this.txtSdtNHANVIEN.Name = "txtSdtNHANVIEN";
            this.txtSdtNHANVIEN.Size = new System.Drawing.Size(182, 22);
            this.txtSdtNHANVIEN.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 80;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtVaiTroNHANVIEN
            // 
            this.txtVaiTroNHANVIEN.Location = new System.Drawing.Point(26, 301);
            this.txtVaiTroNHANVIEN.MaxLength = 20;
            this.txtVaiTroNHANVIEN.Name = "txtVaiTroNHANVIEN";
            this.txtVaiTroNHANVIEN.Size = new System.Drawing.Size(203, 22);
            this.txtVaiTroNHANVIEN.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 82;
            this.label10.Text = "Vai trò:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 84;
            this.label11.Text = "Quản lý:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 86;
            this.label12.Text = "Phòng:";
            // 
            // cbxPhaiNHANVIEN
            // 
            this.cbxPhaiNHANVIEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhaiNHANVIEN.FormattingEnabled = true;
            this.cbxPhaiNHANVIEN.Location = new System.Drawing.Point(315, 77);
            this.cbxPhaiNHANVIEN.Name = "cbxPhaiNHANVIEN";
            this.cbxPhaiNHANVIEN.Size = new System.Drawing.Size(80, 24);
            this.cbxPhaiNHANVIEN.TabIndex = 88;
            // 
            // cbxNQLNHANVIEN
            // 
            this.cbxNQLNHANVIEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNQLNHANVIEN.FormattingEnabled = true;
            this.cbxNQLNHANVIEN.Location = new System.Drawing.Point(26, 382);
            this.cbxNQLNHANVIEN.Name = "cbxNQLNHANVIEN";
            this.cbxNQLNHANVIEN.Size = new System.Drawing.Size(272, 24);
            this.cbxNQLNHANVIEN.TabIndex = 89;
            // 
            // cbxPHGBANNHANVIEN
            // 
            this.cbxPHGBANNHANVIEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPHGBANNHANVIEN.FormattingEnabled = true;
            this.cbxPHGBANNHANVIEN.Location = new System.Drawing.Point(268, 299);
            this.cbxPHGBANNHANVIEN.Name = "cbxPHGBANNHANVIEN";
            this.cbxPHGBANNHANVIEN.Size = new System.Drawing.Size(176, 24);
            this.cbxPHGBANNHANVIEN.TabIndex = 90;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Beige;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(173, 454);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 30);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // grb_SaveCancel
            // 
            this.grb_SaveCancel.Controls.Add(this.btnSave);
            this.grb_SaveCancel.Controls.Add(this.btnCancel);
            this.grb_SaveCancel.Location = new System.Drawing.Point(196, 504);
            this.grb_SaveCancel.Name = "grb_SaveCancel";
            this.grb_SaveCancel.Size = new System.Drawing.Size(244, 66);
            this.grb_SaveCancel.TabIndex = 92;
            this.grb_SaveCancel.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Beige;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(126, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 30);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Beige;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(18, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 30);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // UserControlListEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pn_NHANVIEN);
            this.Controls.Add(this.panel2);
            this.Name = "UserControlListEmployee";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UserControlListEmployee_LoadAsync);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
            this.pn_NHANVIEN.ResumeLayout(false);
            this.pn_NHANVIEN.PerformLayout();
            this.grb_SaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListEmployees;
        private System.Windows.Forms.Panel pn_NHANVIEN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNHANVIEN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVaiTroNHANVIEN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSdtNHANVIEN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtNgaySinhNHANVIEN;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grb_SaveCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxPHGBANNHANVIEN;
        private System.Windows.Forms.ComboBox cbxNQLNHANVIEN;
        private System.Windows.Forms.ComboBox cbxPhaiNHANVIEN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
