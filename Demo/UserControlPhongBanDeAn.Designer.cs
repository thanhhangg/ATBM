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
            this.dgvListUser = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListRole = new System.Windows.Forms.DataGridView();
            this.BTN_NS_Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_NS_Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAddMaTP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NS_Update_tenPB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_UpdatePB = new System.Windows.Forms.Panel();
            this.cbUpdateMaTP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pn_AddNewPB = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRole)).BeginInit();
            this.pn_UpdatePB.SuspendLayout();
            this.pn_AddNewPB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvListUser);
            this.panel1.Location = new System.Drawing.Point(36, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 252);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 72;
            this.label1.Text = "DE AN";
            // 
            // dgvListUser
            // 
            this.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUser.Location = new System.Drawing.Point(7, 41);
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.ReadOnly = true;
            this.dgvListUser.RowHeadersWidth = 51;
            this.dgvListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUser.Size = new System.Drawing.Size(356, 202);
            this.dgvListUser.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvListRole);
            this.panel3.Location = new System.Drawing.Point(36, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 405);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(14, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 37);
            this.label4.TabIndex = 73;
            this.label4.Text = "PHONG BAN";
            // 
            // dgvListRole
            // 
            this.dgvListRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRole.Location = new System.Drawing.Point(3, 41);
            this.dgvListRole.MultiSelect = false;
            this.dgvListRole.Name = "dgvListRole";
            this.dgvListRole.ReadOnly = true;
            this.dgvListRole.RowHeadersWidth = 51;
            this.dgvListRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRole.Size = new System.Drawing.Size(453, 359);
            this.dgvListRole.TabIndex = 0;
            // 
            // BTN_NS_Update
            // 
            this.BTN_NS_Update.Location = new System.Drawing.Point(202, 166);
            this.BTN_NS_Update.Name = "BTN_NS_Update";
            this.BTN_NS_Update.Size = new System.Drawing.Size(117, 33);
            this.BTN_NS_Update.TabIndex = 9;
            this.BTN_NS_Update.Text = "Chỉnh sửa";
            this.BTN_NS_Update.UseVisualStyleBackColor = true;
            this.BTN_NS_Update.Click += new System.EventHandler(this.BTN_NS_Update_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // txtNewRole
            // 
            this.txtNewRole.Location = new System.Drawing.Point(26, 61);
            this.txtNewRole.MaxLength = 20;
            this.txtNewRole.Name = "txtNewRole";
            this.txtNewRole.Size = new System.Drawing.Size(292, 26);
            this.txtNewRole.TabIndex = 64;
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
            // cbAddMaTP
            // 
            this.cbAddMaTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddMaTP.FormattingEnabled = true;
            this.cbAddMaTP.Location = new System.Drawing.Point(27, 122);
            this.cbAddMaTP.Name = "cbAddMaTP";
            this.cbAddMaTP.Size = new System.Drawing.Size(291, 28);
            this.cbAddMaTP.TabIndex = 71;
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
            // txt_NS_Update_tenPB
            // 
            this.txt_NS_Update_tenPB.Location = new System.Drawing.Point(27, 61);
            this.txt_NS_Update_tenPB.MaxLength = 20;
            this.txt_NS_Update_tenPB.Name = "txt_NS_Update_tenPB";
            this.txt_NS_Update_tenPB.Size = new System.Drawing.Size(292, 26);
            this.txt_NS_Update_tenPB.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tên phòng ban:";
            // 
            // pn_UpdatePB
            // 
            this.pn_UpdatePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_UpdatePB.Controls.Add(this.cbUpdateMaTP);
            this.pn_UpdatePB.Controls.Add(this.label8);
            this.pn_UpdatePB.Controls.Add(this.label2);
            this.pn_UpdatePB.Controls.Add(this.BTN_NS_Update);
            this.pn_UpdatePB.Controls.Add(this.txt_NS_Update_tenPB);
            this.pn_UpdatePB.Controls.Add(this.label6);
            this.pn_UpdatePB.Location = new System.Drawing.Point(960, 71);
            this.pn_UpdatePB.Name = "pn_UpdatePB";
            this.pn_UpdatePB.Size = new System.Drawing.Size(359, 213);
            this.pn_UpdatePB.TabIndex = 75;
            // 
            // cbUpdateMaTP
            // 
            this.cbUpdateMaTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateMaTP.FormattingEnabled = true;
            this.cbUpdateMaTP.Location = new System.Drawing.Point(28, 122);
            this.cbUpdateMaTP.Name = "cbUpdateMaTP";
            this.cbUpdateMaTP.Size = new System.Drawing.Size(291, 28);
            this.cbUpdateMaTP.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 72;
            this.label8.Text = "Trưởng phòng:";
            // 
            // pn_AddNewPB
            // 
            this.pn_AddNewPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_AddNewPB.Controls.Add(this.cbAddMaTP);
            this.pn_AddNewPB.Controls.Add(this.label7);
            this.pn_AddNewPB.Controls.Add(this.label3);
            this.pn_AddNewPB.Controls.Add(this.BTN_NS_Create);
            this.pn_AddNewPB.Controls.Add(this.txtNewRole);
            this.pn_AddNewPB.Controls.Add(this.label5);
            this.pn_AddNewPB.Location = new System.Drawing.Point(532, 71);
            this.pn_AddNewPB.Name = "pn_AddNewPB";
            this.pn_AddNewPB.Size = new System.Drawing.Size(359, 213);
            this.pn_AddNewPB.TabIndex = 74;
            // 
            // UserControlPhongBanDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_UpdatePB);
            this.Controls.Add(this.pn_AddNewPB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlPhongBanDeAn";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UserControlPhongBanDeAn_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControlPhongBanDeAn_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRole)).EndInit();
            this.pn_UpdatePB.ResumeLayout(false);
            this.pn_UpdatePB.PerformLayout();
            this.pn_AddNewPB.ResumeLayout(false);
            this.pn_AddNewPB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListRole;
        private System.Windows.Forms.Button BTN_NS_Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_NS_Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NS_Update_tenPB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAddMaTP;
        private System.Windows.Forms.Panel pn_UpdatePB;
        private System.Windows.Forms.Panel pn_AddNewPB;
        private System.Windows.Forms.ComboBox cbUpdateMaTP;
        private System.Windows.Forms.Label label8;
    }
}
