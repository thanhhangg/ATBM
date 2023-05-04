
namespace Demo
{
    partial class UserControlListObject
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
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListUser = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListRole = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddNewRole = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvListUser);
            this.panel1.Location = new System.Drawing.Point(56, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 465);
            this.panel1.TabIndex = 7;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(737, 5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(88, 29);
            this.btnDeleteUser.TabIndex = 75;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 72;
            this.label1.Text = "LIST USER";
            // 
            // dgvListUser
            // 
            this.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUser.Location = new System.Drawing.Point(4, 40);
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.ReadOnly = true;
            this.dgvListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUser.Size = new System.Drawing.Size(838, 420);
            this.dgvListUser.TabIndex = 0;
            this.dgvListUser.SelectionChanged += new System.EventHandler(this.dgvListUser_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddNewUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUsename);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(964, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 160);
            this.panel2.TabIndex = 8;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Beige;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewUser.Location = new System.Drawing.Point(193, 108);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(125, 30);
            this.btnAddNewUser.TabIndex = 72;
            this.btnAddNewUser.Text = "Add";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Add a new user";
            // 
            // txtUsename
            // 
            this.txtUsename.Location = new System.Drawing.Point(35, 65);
            this.txtUsename.MaxLength = 20;
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(283, 22);
            this.txtUsename.TabIndex = 64;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(32, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 13);
            this.lblUsername.TabIndex = 63;
            this.lblUsername.Text = "Enter name:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDeleteRole);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvListRole);
            this.panel3.Location = new System.Drawing.Point(52, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 185);
            this.panel3.TabIndex = 8;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Enabled = false;
            this.btnDeleteRole.Location = new System.Drawing.Point(741, 6);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(88, 29);
            this.btnDeleteRole.TabIndex = 74;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 73;
            this.label4.Text = "LIST ROLE";
            // 
            // dgvListRole
            // 
            this.dgvListRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRole.Location = new System.Drawing.Point(3, 41);
            this.dgvListRole.Name = "dgvListRole";
            this.dgvListRole.ReadOnly = true;
            this.dgvListRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRole.Size = new System.Drawing.Size(839, 136);
            this.dgvListRole.TabIndex = 0;
            this.dgvListRole.SelectionChanged += new System.EventHandler(this.dgvListRole_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.List_User;
            this.pictureBox1.Location = new System.Drawing.Point(981, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAddNewRole);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtNewRole);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(964, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 145);
            this.panel4.TabIndex = 73;
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.BackColor = System.Drawing.Color.Beige;
            this.btnAddNewRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewRole.Location = new System.Drawing.Point(193, 94);
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.Size = new System.Drawing.Size(125, 30);
            this.btnAddNewRole.TabIndex = 72;
            this.btnAddNewRole.Text = "Add";
            this.btnAddNewRole.UseVisualStyleBackColor = false;
            this.btnAddNewRole.Click += new System.EventHandler(this.btnAddNewRole_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Add a new role";
            // 
            // txtNewRole
            // 
            this.txtNewRole.Location = new System.Drawing.Point(26, 55);
            this.txtNewRole.MaxLength = 20;
            this.txtNewRole.Name = "txtNewRole";
            this.txtNewRole.Size = new System.Drawing.Size(292, 22);
            this.txtNewRole.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Enter name:";
            // 
            // UserControlListObject
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
            this.Name = "UserControlListObject";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UserControlListObject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListRole;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddNewRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}
