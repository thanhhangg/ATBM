namespace Demo
{
    partial class UserControlProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phucap = new System.Windows.Forms.Label();
            this.luong = new System.Windows.Forms.Label();
            this.vaitro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phong = new System.Windows.Forms.Label();
            this.sdtTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ngaysinhTxt = new System.Windows.Forms.Label();
            this.manql = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.diachiTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.phai = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvPhanCong);
            this.panel1.Location = new System.Drawing.Point(996, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 303);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 72;
            this.label1.Text = "PHAN CONG";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Location = new System.Drawing.Point(4, 40);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(289, 256);
            this.dgvPhanCong.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(488, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(22, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Họ và tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(488, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(22, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phụ cấp:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(22, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "Số điện thoại:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(22, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.phucap);
            this.groupBox1.Controls.Add(this.luong);
            this.groupBox1.Controls.Add(this.vaitro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phong);
            this.groupBox1.Controls.Add(this.sdtTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ngaysinhTxt);
            this.groupBox1.Controls.Add(this.manql);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.diachiTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.phai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ten);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(56, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 603);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROFILE";
            // 
            // phucap
            // 
            this.phucap.AutoSize = true;
            this.phucap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phucap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phucap.Location = new System.Drawing.Point(267, 443);
            this.phucap.Name = "phucap";
            this.phucap.Size = new System.Drawing.Size(34, 28);
            this.phucap.TabIndex = 32;
            this.phucap.Text = "23";
            // 
            // luong
            // 
            this.luong.AutoSize = true;
            this.luong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.luong.Location = new System.Drawing.Point(267, 393);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(67, 28);
            this.luong.TabIndex = 30;
            this.luong.Text = "31665";
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaitro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vaitro.Location = new System.Drawing.Point(194, 285);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(114, 28);
            this.vaitro.TabIndex = 31;
            this.vaitro.Text = "QL truc tiep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mức lượng hiện tại:";
            // 
            // phong
            // 
            this.phong.AutoSize = true;
            this.phong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phong.Location = new System.Drawing.Point(194, 338);
            this.phong.Name = "phong";
            this.phong.Size = new System.Drawing.Size(23, 28);
            this.phong.TabIndex = 28;
            this.phong.Text = "7";
            // 
            // sdtTxt
            // 
            this.sdtTxt.AutoSize = true;
            this.sdtTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sdtTxt.Location = new System.Drawing.Point(203, 200);
            this.sdtTxt.Name = "sdtTxt";
            this.sdtTxt.Size = new System.Drawing.Size(76, 28);
            this.sdtTxt.TabIndex = 39;
            this.sdtTxt.Text = "label13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(22, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Phòng ban:";
            // 
            // ngaysinhTxt
            // 
            this.ngaysinhTxt.AutoSize = true;
            this.ngaysinhTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaysinhTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ngaysinhTxt.Location = new System.Drawing.Point(651, 98);
            this.ngaysinhTxt.Name = "ngaysinhTxt";
            this.ngaysinhTxt.Size = new System.Drawing.Size(76, 28);
            this.ngaysinhTxt.TabIndex = 38;
            this.ngaysinhTxt.Text = "label10";
            this.ngaysinhTxt.Click += new System.EventHandler(this.ngaysinhTxt_Click);
            // 
            // manql
            // 
            this.manql.AutoSize = true;
            this.manql.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manql.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manql.Location = new System.Drawing.Point(710, 285);
            this.manql.Name = "manql";
            this.manql.Size = new System.Drawing.Size(44, 28);
            this.manql.TabIndex = 29;
            this.manql.Text = "null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(22, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 28);
            this.label15.TabIndex = 22;
            this.label15.Text = "Chức vụ:";
            // 
            // diachiTxt
            // 
            this.diachiTxt.AutoSize = true;
            this.diachiTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachiTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.diachiTxt.Location = new System.Drawing.Point(203, 148);
            this.diachiTxt.Name = "diachiTxt";
            this.diachiTxt.Size = new System.Drawing.Size(88, 28);
            this.diachiTxt.TabIndex = 36;
            this.diachiTxt.Text = "diachiTxt";
            this.diachiTxt.Click += new System.EventHandler(this.diachiTxt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(488, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mã người quản lí:";
            // 
            // sdt
            // 
            this.sdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.Location = new System.Drawing.Point(199, 197);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(180, 34);
            this.sdt.TabIndex = 35;
            this.sdt.Text = "8262447315";
            // 
            // ngaysinh
            // 
            this.ngaysinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaysinh.Location = new System.Drawing.Point(646, 95);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(164, 34);
            this.ngaysinh.TabIndex = 34;
            this.ngaysinh.Text = "15-MAR-71";
            // 
            // diachi
            // 
            this.diachi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.diachi.Location = new System.Drawing.Point(199, 145);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(301, 34);
            this.diachi.TabIndex = 33;
            this.diachi.Text = "4 Schiller Avenue";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.id.Location = new System.Drawing.Point(194, 48);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(34, 28);
            this.id.TabIndex = 32;
            this.id.Text = "83";
            this.id.Click += new System.EventHandler(this.id_Click_1);
            // 
            // phai
            // 
            this.phai.AutoSize = true;
            this.phai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phai.Location = new System.Drawing.Point(641, 48);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(38, 28);
            this.phai.TabIndex = 27;
            this.phai.Text = "Nu";
            this.phai.Click += new System.EventHandler(this.phai_Click);
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ten.Location = new System.Drawing.Point(194, 98);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(140, 28);
            this.ten.TabIndex = 26;
            this.ten.Text = "Ryann Franken";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(796, 41);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(107, 44);
            this.update.TabIndex = 40;
            this.update.Text = "Cập nhật";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Location = new System.Drawing.Point(796, 41);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(107, 44);
            this.Edit.TabIndex = 37;
            this.Edit.Text = "Chỉnh sửa";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.editDiaChi_Click);
            // 
            // UserControlProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlProfile";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UserControlProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label phai;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label phong;
        private System.Windows.Forms.Label manql;
        private System.Windows.Forms.Label luong;
        private System.Windows.Forms.Label vaitro;
        private System.Windows.Forms.Label phucap;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox ngaysinh;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label diachiTxt;
        private System.Windows.Forms.Label sdtTxt;
        private System.Windows.Forms.Label ngaysinhTxt;
        private System.Windows.Forms.Button update;
    }
}
