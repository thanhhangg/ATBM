
namespace Demo
{
    partial class UserControlGrant
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
            this.cbxUserNameGrantRole = new System.Windows.Forms.ComboBox();
            this.cbxGrantRoleName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAdOptGrantRole = new System.Windows.Forms.CheckBox();
            this.btnGrantSaveRole = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxGrantPriObjectName = new System.Windows.Forms.ComboBox();
            this.cbxGrantPriPriName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGrantPriRoleName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrantSavePri = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxRevokePriObjectName = new System.Windows.Forms.ComboBox();
            this.cbxReVokePriName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRevokePriRoleName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRevokePri = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxRevokeRoleUsername = new System.Windows.Forms.ComboBox();
            this.cbxRevokeRoleName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRevokeRoleUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxUserNameGrantRole);
            this.panel2.Controls.Add(this.cbxGrantRoleName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxAdOptGrantRole);
            this.panel2.Controls.Add(this.btnGrantSaveRole);
            this.panel2.Controls.Add(this.lblNewPassword);
            this.panel2.Controls.Add(this.lblCurrentPassword);
            this.panel2.Location = new System.Drawing.Point(72, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 295);
            this.panel2.TabIndex = 62;
            // 
            // cbxUserNameGrantRole
            // 
            this.cbxUserNameGrantRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserNameGrantRole.FormattingEnabled = true;
            this.cbxUserNameGrantRole.Location = new System.Drawing.Point(61, 134);
            this.cbxUserNameGrantRole.Name = "cbxUserNameGrantRole";
            this.cbxUserNameGrantRole.Size = new System.Drawing.Size(209, 24);
            this.cbxUserNameGrantRole.TabIndex = 64;
            // 
            // cbxGrantRoleName
            // 
            this.cbxGrantRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrantRoleName.FormattingEnabled = true;
            this.cbxGrantRoleName.Location = new System.Drawing.Point(61, 84);
            this.cbxGrantRoleName.Name = "cbxGrantRoleName";
            this.cbxGrantRoleName.Size = new System.Drawing.Size(209, 24);
            this.cbxGrantRoleName.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Grant roles to the user";
            // 
            // cbxAdOptGrantRole
            // 
            this.cbxAdOptGrantRole.AutoSize = true;
            this.cbxAdOptGrantRole.Checked = true;
            this.cbxAdOptGrantRole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAdOptGrantRole.Location = new System.Drawing.Point(61, 174);
            this.cbxAdOptGrantRole.Name = "cbxAdOptGrantRole";
            this.cbxAdOptGrantRole.Size = new System.Drawing.Size(161, 20);
            this.cbxAdOptGrantRole.TabIndex = 58;
            this.cbxAdOptGrantRole.Text = "WITH ADMIN OPTION";
            this.cbxAdOptGrantRole.UseVisualStyleBackColor = true;
            // 
            // btnGrantSaveRole
            // 
            this.btnGrantSaveRole.BackColor = System.Drawing.Color.Beige;
            this.btnGrantSaveRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrantSaveRole.Location = new System.Drawing.Point(152, 229);
            this.btnGrantSaveRole.Name = "btnGrantSaveRole";
            this.btnGrantSaveRole.Size = new System.Drawing.Size(118, 30);
            this.btnGrantSaveRole.TabIndex = 56;
            this.btnGrantSaveRole.Text = "Grant";
            this.btnGrantSaveRole.UseVisualStyleBackColor = false;
            this.btnGrantSaveRole.Click += new System.EventHandler(this.btnGrantSaveRole_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(58, 118);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(64, 13);
            this.lblNewPassword.TabIndex = 50;
            this.lblNewPassword.Text = "User name:";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(58, 68);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(64, 13);
            this.lblCurrentPassword.TabIndex = 54;
            this.lblCurrentPassword.Text = "Role name:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxGrantPriObjectName);
            this.panel1.Controls.Add(this.cbxGrantPriPriName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxGrantPriRoleName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGrantSavePri);
            this.panel1.Controls.Add(this.lblPoint);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Location = new System.Drawing.Point(505, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 295);
            this.panel1.TabIndex = 61;
            // 
            // cbxGrantPriObjectName
            // 
            this.cbxGrantPriObjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrantPriObjectName.FormattingEnabled = true;
            this.cbxGrantPriObjectName.Location = new System.Drawing.Point(60, 189);
            this.cbxGrantPriObjectName.Name = "cbxGrantPriObjectName";
            this.cbxGrantPriObjectName.Size = new System.Drawing.Size(233, 24);
            this.cbxGrantPriObjectName.TabIndex = 64;
            // 
            // cbxGrantPriPriName
            // 
            this.cbxGrantPriPriName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrantPriPriName.FormattingEnabled = true;
            this.cbxGrantPriPriName.Location = new System.Drawing.Point(61, 141);
            this.cbxGrantPriPriName.Name = "cbxGrantPriPriName";
            this.cbxGrantPriPriName.Size = new System.Drawing.Size(233, 24);
            this.cbxGrantPriPriName.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Role name:";
            // 
            // cbxGrantPriRoleName
            // 
            this.cbxGrantPriRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrantPriRoleName.FormattingEnabled = true;
            this.cbxGrantPriRoleName.Location = new System.Drawing.Point(60, 84);
            this.cbxGrantPriRoleName.Name = "cbxGrantPriRoleName";
            this.cbxGrantPriRoleName.Size = new System.Drawing.Size(234, 24);
            this.cbxGrantPriRoleName.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Grant privileges to role";
            // 
            // btnGrantSavePri
            // 
            this.btnGrantSavePri.BackColor = System.Drawing.Color.Beige;
            this.btnGrantSavePri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrantSavePri.Location = new System.Drawing.Point(176, 229);
            this.btnGrantSavePri.Name = "btnGrantSavePri";
            this.btnGrantSavePri.Size = new System.Drawing.Size(118, 30);
            this.btnGrantSavePri.TabIndex = 53;
            this.btnGrantSavePri.Text = "Grant";
            this.btnGrantSavePri.UseVisualStyleBackColor = false;
            this.btnGrantSavePri.Click += new System.EventHandler(this.btnGrantSavePri_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(58, 173);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(75, 13);
            this.lblPoint.TabIndex = 50;
            this.lblPoint.Text = "Object name:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(58, 118);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(84, 13);
            this.lblFullName.TabIndex = 44;
            this.lblFullName.Text = "Privilege name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.PhanQyen;
            this.pictureBox1.Location = new System.Drawing.Point(932, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbxRevokePriObjectName);
            this.panel3.Controls.Add(this.cbxReVokePriName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbxRevokePriRoleName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnRevokePri);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(505, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 295);
            this.panel3.TabIndex = 63;
            // 
            // cbxRevokePriObjectName
            // 
            this.cbxRevokePriObjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRevokePriObjectName.FormattingEnabled = true;
            this.cbxRevokePriObjectName.Location = new System.Drawing.Point(61, 193);
            this.cbxRevokePriObjectName.Name = "cbxRevokePriObjectName";
            this.cbxRevokePriObjectName.Size = new System.Drawing.Size(233, 24);
            this.cbxRevokePriObjectName.TabIndex = 65;
            // 
            // cbxReVokePriName
            // 
            this.cbxReVokePriName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReVokePriName.FormattingEnabled = true;
            this.cbxReVokePriName.Location = new System.Drawing.Point(60, 141);
            this.cbxReVokePriName.Name = "cbxReVokePriName";
            this.cbxReVokePriName.Size = new System.Drawing.Size(234, 24);
            this.cbxReVokePriName.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Role name:";
            // 
            // cbxRevokePriRoleName
            // 
            this.cbxRevokePriRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRevokePriRoleName.FormattingEnabled = true;
            this.cbxRevokePriRoleName.Location = new System.Drawing.Point(60, 84);
            this.cbxRevokePriRoleName.Name = "cbxRevokePriRoleName";
            this.cbxRevokePriRoleName.Size = new System.Drawing.Size(234, 24);
            this.cbxRevokePriRoleName.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(21, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 21);
            this.label5.TabIndex = 60;
            this.label5.Text = "Revoke privileges to role/user";
            // 
            // btnRevokePri
            // 
            this.btnRevokePri.BackColor = System.Drawing.Color.Beige;
            this.btnRevokePri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRevokePri.Location = new System.Drawing.Point(176, 238);
            this.btnRevokePri.Name = "btnRevokePri";
            this.btnRevokePri.Size = new System.Drawing.Size(118, 30);
            this.btnRevokePri.TabIndex = 53;
            this.btnRevokePri.Text = "Revoke";
            this.btnRevokePri.UseVisualStyleBackColor = false;
            this.btnRevokePri.Click += new System.EventHandler(this.btnRevokePri_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Object name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Privilege name:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbxRevokeRoleUsername);
            this.panel4.Controls.Add(this.cbxRevokeRoleName);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnRevokeRoleUser);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(72, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 257);
            this.panel4.TabIndex = 65;
            // 
            // cbxRevokeRoleUsername
            // 
            this.cbxRevokeRoleUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRevokeRoleUsername.FormattingEnabled = true;
            this.cbxRevokeRoleUsername.Location = new System.Drawing.Point(61, 134);
            this.cbxRevokeRoleUsername.Name = "cbxRevokeRoleUsername";
            this.cbxRevokeRoleUsername.Size = new System.Drawing.Size(209, 24);
            this.cbxRevokeRoleUsername.TabIndex = 64;
            // 
            // cbxRevokeRoleName
            // 
            this.cbxRevokeRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRevokeRoleName.FormattingEnabled = true;
            this.cbxRevokeRoleName.Location = new System.Drawing.Point(61, 84);
            this.cbxRevokeRoleName.Name = "cbxRevokeRoleName";
            this.cbxRevokeRoleName.Size = new System.Drawing.Size(209, 24);
            this.cbxRevokeRoleName.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(20, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "Revoke roles to the user";
            // 
            // btnRevokeRoleUser
            // 
            this.btnRevokeRoleUser.BackColor = System.Drawing.Color.Beige;
            this.btnRevokeRoleUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRevokeRoleUser.Location = new System.Drawing.Point(152, 190);
            this.btnRevokeRoleUser.Name = "btnRevokeRoleUser";
            this.btnRevokeRoleUser.Size = new System.Drawing.Size(118, 30);
            this.btnRevokeRoleUser.TabIndex = 56;
            this.btnRevokeRoleUser.Text = "Revoke";
            this.btnRevokeRoleUser.UseVisualStyleBackColor = false;
            this.btnRevokeRoleUser.Click += new System.EventHandler(this.btnRevokeRoleUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "User name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Role name:";
            // 
            // UserControlGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlGrant";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UserControlGrant_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnGrantSavePri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxAdOptGrantRole;
        private System.Windows.Forms.Button btnGrantSaveRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGrantPriRoleName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRevokePriRoleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRevokePri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxGrantRoleName;
        private System.Windows.Forms.ComboBox cbxUserNameGrantRole;
        private System.Windows.Forms.ComboBox cbxGrantPriObjectName;
        private System.Windows.Forms.ComboBox cbxGrantPriPriName;
        private System.Windows.Forms.ComboBox cbxRevokePriObjectName;
        private System.Windows.Forms.ComboBox cbxReVokePriName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxRevokeRoleUsername;
        private System.Windows.Forms.ComboBox cbxRevokeRoleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRevokeRoleUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
