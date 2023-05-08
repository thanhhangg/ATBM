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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxPhai = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grb_SaveCancel = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNQL = new System.Windows.Forms.TextBox();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.pn_NHANVIEN = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
            this.grb_SaveCancel.SuspendLayout();
            this.pn_NHANVIEN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvListEmployees);
            this.panel2.Location = new System.Drawing.Point(49, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 657);
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
            this.dgvListEmployees.Size = new System.Drawing.Size(774, 600);
            this.dgvListEmployees.TabIndex = 0;
            this.dgvListEmployees.SelectionChanged += new System.EventHandler(this.dgvListEmployees_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(36, 147);
            this.txtTen.MaxLength = 20;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(255, 22);
            this.txtTen.TabIndex = 64;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Beige;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(317, 507);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 30);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Phái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(36, 256);
            this.txtDiaChi.MaxLength = 20;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(328, 22);
            this.txtDiaChi.TabIndex = 78;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Enabled = false;
            this.dtNgaySinh.Location = new System.Drawing.Point(35, 205);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(250, 22);
            this.dtNgaySinh.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 80;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            this.txtSdt.Enabled = false;
            this.txtSdt.Location = new System.Drawing.Point(37, 313);
            this.txtSdt.MaxLength = 20;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(182, 22);
            this.txtSdt.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 82;
            this.label10.Text = "Vai trò:";
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Enabled = false;
            this.txtVaiTro.Location = new System.Drawing.Point(35, 369);
            this.txtVaiTro.MaxLength = 20;
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(203, 22);
            this.txtVaiTro.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 84;
            this.label11.Text = "Quản lý:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 86;
            this.label12.Text = "Phòng:";
            // 
            // cbxPhai
            // 
            this.cbxPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhai.Enabled = false;
            this.cbxPhai.FormattingEnabled = true;
            this.cbxPhai.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbxPhai.Location = new System.Drawing.Point(324, 145);
            this.cbxPhai.Name = "cbxPhai";
            this.cbxPhai.Size = new System.Drawing.Size(80, 24);
            this.cbxPhai.TabIndex = 88;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Beige;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(176, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 30);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grb_SaveCancel
            // 
            this.grb_SaveCancel.Controls.Add(this.btnSave);
            this.grb_SaveCancel.Controls.Add(this.btnCancel);
            this.grb_SaveCancel.Enabled = false;
            this.grb_SaveCancel.Location = new System.Drawing.Point(199, 557);
            this.grb_SaveCancel.Name = "grb_SaveCancel";
            this.grb_SaveCancel.Size = new System.Drawing.Size(244, 66);
            this.grb_SaveCancel.TabIndex = 92;
            this.grb_SaveCancel.TabStop = false;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNQL
            // 
            this.txtNQL.Enabled = false;
            this.txtNQL.Location = new System.Drawing.Point(37, 439);
            this.txtNQL.MaxLength = 20;
            this.txtNQL.Name = "txtNQL";
            this.txtNQL.Size = new System.Drawing.Size(203, 22);
            this.txtNQL.TabIndex = 93;
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Enabled = false;
            this.txtPhongBan.Location = new System.Drawing.Point(261, 369);
            this.txtPhongBan.MaxLength = 20;
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(188, 22);
            this.txtPhongBan.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 95;
            this.label4.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(36, 88);
            this.txtMaNV.MaxLength = 20;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(255, 22);
            this.txtMaNV.TabIndex = 96;
            // 
            // pn_NHANVIEN
            // 
            this.pn_NHANVIEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NHANVIEN.Controls.Add(this.txtMaNV);
            this.pn_NHANVIEN.Controls.Add(this.label4);
            this.pn_NHANVIEN.Controls.Add(this.txtPhongBan);
            this.pn_NHANVIEN.Controls.Add(this.txtNQL);
            this.pn_NHANVIEN.Controls.Add(this.grb_SaveCancel);
            this.pn_NHANVIEN.Controls.Add(this.btnUpdate);
            this.pn_NHANVIEN.Controls.Add(this.cbxPhai);
            this.pn_NHANVIEN.Controls.Add(this.label12);
            this.pn_NHANVIEN.Controls.Add(this.label11);
            this.pn_NHANVIEN.Controls.Add(this.txtVaiTro);
            this.pn_NHANVIEN.Controls.Add(this.label10);
            this.pn_NHANVIEN.Controls.Add(this.txtSdt);
            this.pn_NHANVIEN.Controls.Add(this.label9);
            this.pn_NHANVIEN.Controls.Add(this.dtNgaySinh);
            this.pn_NHANVIEN.Controls.Add(this.txtDiaChi);
            this.pn_NHANVIEN.Controls.Add(this.label8);
            this.pn_NHANVIEN.Controls.Add(this.label7);
            this.pn_NHANVIEN.Controls.Add(this.label6);
            this.pn_NHANVIEN.Controls.Add(this.btnAdd);
            this.pn_NHANVIEN.Controls.Add(this.label3);
            this.pn_NHANVIEN.Controls.Add(this.txtTen);
            this.pn_NHANVIEN.Controls.Add(this.label5);
            this.pn_NHANVIEN.Location = new System.Drawing.Point(859, 43);
            this.pn_NHANVIEN.Name = "pn_NHANVIEN";
            this.pn_NHANVIEN.Size = new System.Drawing.Size(482, 657);
            this.pn_NHANVIEN.TabIndex = 75;
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
            this.grb_SaveCancel.ResumeLayout(false);
            this.pn_NHANVIEN.ResumeLayout(false);
            this.pn_NHANVIEN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListEmployees;
        private System.Windows.Forms.ComboBox cbxPHGBAN;
        private System.Windows.Forms.ComboBox cbxNQL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxPhai;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grb_SaveCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNQL;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel pn_NHANVIEN;
    }
}
