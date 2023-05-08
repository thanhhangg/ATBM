namespace Demo
{
    partial class UserControlPhongBanDeAn
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
            this.dgvDeAn = new System.Windows.Forms.DataGridView();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_NS_Update = new System.Windows.Forms.Button();
            this.BTN_NS_Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPhongBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdatePhongBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_UpdatePB = new System.Windows.Forms.Panel();
            this.txtUpdateTruongPhong = new System.Windows.Forms.TextBox();
            this.txtUpdateMaPB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pn_AddNewPB = new System.Windows.Forms.Panel();
            this.txtNewTruongPhong = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.pn_UpdatePB.SuspendLayout();
            this.pn_AddNewPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvPhongBan);
            this.panel1.Location = new System.Drawing.Point(38, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 276);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 72;
            this.label1.Text = "PHONG BAN";
            // 
            // dgvDeAn
            // 
            this.dgvDeAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeAn.Location = new System.Drawing.Point(3, 42);
            this.dgvDeAn.MultiSelect = false;
            this.dgvDeAn.Name = "dgvDeAn";
            this.dgvDeAn.ReadOnly = true;
            this.dgvDeAn.RowHeadersVisible = false;
            this.dgvDeAn.RowHeadersWidth = 51;
            this.dgvDeAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeAn.Size = new System.Drawing.Size(453, 259);
            this.dgvDeAn.TabIndex = 0;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(3, 41);
            this.dgvPhongBan.MultiSelect = false;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersVisible = false;
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(449, 230);
            this.dgvPhongBan.TabIndex = 0;
            this.dgvPhongBan.SelectionChanged += new System.EventHandler(this.dgvPhongBan_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.dgvDeAn);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(38, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 306);
            this.panel3.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(300, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 33);
            this.btnRemove.TabIndex = 75;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(381, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(14, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 37);
            this.label4.TabIndex = 73;
            this.label4.Text = "DE AN";
            // 
            // BTN_NS_Update
            // 
            this.BTN_NS_Update.Location = new System.Drawing.Point(202, 242);
            this.BTN_NS_Update.Name = "BTN_NS_Update";
            this.BTN_NS_Update.Size = new System.Drawing.Size(117, 33);
            this.BTN_NS_Update.TabIndex = 9;
            this.BTN_NS_Update.Text = "Chỉnh sửa";
            this.BTN_NS_Update.UseVisualStyleBackColor = true;
            this.BTN_NS_Update.Click += new System.EventHandler(this.BTN_NS_Update_Click);
            // 
            // BTN_NS_Create
            // 
            this.BTN_NS_Create.Location = new System.Drawing.Point(201, 166);
            this.BTN_NS_Create.Name = "BTN_NS_Create";
            this.BTN_NS_Create.Size = new System.Drawing.Size(117, 33);
            this.BTN_NS_Create.TabIndex = 11;
            this.BTN_NS_Create.Text = "Thêm mới";
            this.BTN_NS_Create.UseVisualStyleBackColor = true;
            this.BTN_NS_Create.Click += new System.EventHandler(this.BTN_NS_Create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 69;
            this.label3.Text = "Add a new PHONGBAN";
            // 
            // txtNewPhongBan
            // 
            this.txtNewPhongBan.Location = new System.Drawing.Point(26, 61);
            this.txtNewPhongBan.MaxLength = 20;
            this.txtNewPhongBan.Name = "txtNewPhongBan";
            this.txtNewPhongBan.Size = new System.Drawing.Size(292, 26);
            this.txtNewPhongBan.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tên phòng ban:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 70;
            this.label7.Text = "Trưởng phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 28);
            this.label2.TabIndex = 69;
            this.label2.Text = "Update PHONGBAN";
            // 
            // txtUpdatePhongBan
            // 
            this.txtUpdatePhongBan.Location = new System.Drawing.Point(27, 133);
            this.txtUpdatePhongBan.MaxLength = 20;
            this.txtUpdatePhongBan.Name = "txtUpdatePhongBan";
            this.txtUpdatePhongBan.Size = new System.Drawing.Size(292, 26);
            this.txtUpdatePhongBan.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tên phòng ban:";
            // 
            // pn_UpdatePB
            // 
            this.pn_UpdatePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_UpdatePB.Controls.Add(this.txtUpdateTruongPhong);
            this.pn_UpdatePB.Controls.Add(this.txtUpdateMaPB);
            this.pn_UpdatePB.Controls.Add(this.label9);
            this.pn_UpdatePB.Controls.Add(this.label8);
            this.pn_UpdatePB.Controls.Add(this.label2);
            this.pn_UpdatePB.Controls.Add(this.BTN_NS_Update);
            this.pn_UpdatePB.Controls.Add(this.txtUpdatePhongBan);
            this.pn_UpdatePB.Controls.Add(this.label6);
            this.pn_UpdatePB.Location = new System.Drawing.Point(960, 71);
            this.pn_UpdatePB.Name = "pn_UpdatePB";
            this.pn_UpdatePB.Size = new System.Drawing.Size(359, 301);
            this.pn_UpdatePB.TabIndex = 75;
            // 
            // txtUpdateTruongPhong
            // 
            this.txtUpdateTruongPhong.Location = new System.Drawing.Point(27, 195);
            this.txtUpdateTruongPhong.MaxLength = 20;
            this.txtUpdateTruongPhong.Name = "txtUpdateTruongPhong";
            this.txtUpdateTruongPhong.Size = new System.Drawing.Size(292, 26);
            this.txtUpdateTruongPhong.TabIndex = 76;
            // 
            // txtUpdateMaPB
            // 
            this.txtUpdateMaPB.Location = new System.Drawing.Point(27, 70);
            this.txtUpdateMaPB.MaxLength = 20;
            this.txtUpdateMaPB.Name = "txtUpdateMaPB";
            this.txtUpdateMaPB.ReadOnly = true;
            this.txtUpdateMaPB.Size = new System.Drawing.Size(292, 26);
            this.txtUpdateMaPB.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 74;
            this.label9.Text = "Mã phòng ban:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 72;
            this.label8.Text = "Trưởng phòng:";
            // 
            // pn_AddNewPB
            // 
            this.pn_AddNewPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_AddNewPB.Controls.Add(this.txtNewTruongPhong);
            this.pn_AddNewPB.Controls.Add(this.label7);
            this.pn_AddNewPB.Controls.Add(this.label3);
            this.pn_AddNewPB.Controls.Add(this.BTN_NS_Create);
            this.pn_AddNewPB.Controls.Add(this.txtNewPhongBan);
            this.pn_AddNewPB.Controls.Add(this.label5);
            this.pn_AddNewPB.Location = new System.Drawing.Point(560, 78);
            this.pn_AddNewPB.Name = "pn_AddNewPB";
            this.pn_AddNewPB.Size = new System.Drawing.Size(359, 213);
            this.pn_AddNewPB.TabIndex = 74;
            // 
            // txtNewTruongPhong
            // 
            this.txtNewTruongPhong.Location = new System.Drawing.Point(27, 122);
            this.txtNewTruongPhong.MaxLength = 20;
            this.txtNewTruongPhong.Name = "txtNewTruongPhong";
            this.txtNewTruongPhong.Size = new System.Drawing.Size(292, 26);
            this.txtNewTruongPhong.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.image_removebg_preview__7_;
            this.pictureBox1.Location = new System.Drawing.Point(560, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlPhongBanDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pn_UpdatePB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn_AddNewPB);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlPhongBanDeAn";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UserControlPhongBanDeAn_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControlPhongBanDeAn_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pn_UpdatePB.ResumeLayout(false);
            this.pn_UpdatePB.PerformLayout();
            this.pn_AddNewPB.ResumeLayout(false);
            this.pn_AddNewPB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDeAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Button BTN_NS_Update;
        private System.Windows.Forms.Button BTN_NS_Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPhongBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdatePhongBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pn_UpdatePB;
        private System.Windows.Forms.Panel pn_AddNewPB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateMaPB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateTruongPhong;
        private System.Windows.Forms.TextBox txtNewTruongPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
    }
}
