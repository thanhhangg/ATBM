
using System;

namespace Demo
{
    partial class UserControlSearch
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
            this.lbEnter = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.cbxSearchRoleName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDBA_SYS_PRIVS = new System.Windows.Forms.DataGridView();
            this.lbDBA_SYS_PRIVS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDBA_ROLE = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDBA_TAB = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxSearchUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBA_SYS_PRIVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBA_ROLE)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBA_TAB)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnter.Location = new System.Drawing.Point(62, 21);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(62, 13);
            this.lbEnter.TabIndex = 18;
            this.lbEnter.Text = "Role Name";
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.cbxSearchRoleName);
            this.panelContainer.Controls.Add(this.lbEnter);
            this.panelContainer.Location = new System.Drawing.Point(74, 445);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(380, 91);
            this.panelContainer.TabIndex = 30;
            // 
            // cbxSearchRoleName
            // 
            this.cbxSearchRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchRoleName.FormattingEnabled = true;
            this.cbxSearchRoleName.Location = new System.Drawing.Point(65, 37);
            this.cbxSearchRoleName.Name = "cbxSearchRoleName";
            this.cbxSearchRoleName.Size = new System.Drawing.Size(255, 25);
            this.cbxSearchRoleName.TabIndex = 32;
            this.cbxSearchRoleName.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvDBA_SYS_PRIVS);
            this.panel1.Controls.Add(this.lbDBA_SYS_PRIVS);
            this.panel1.Location = new System.Drawing.Point(538, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 139);
            this.panel1.TabIndex = 31;
            // 
            // dgvDBA_SYS_PRIVS
            // 
            this.dgvDBA_SYS_PRIVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBA_SYS_PRIVS.Location = new System.Drawing.Point(3, 34);
            this.dgvDBA_SYS_PRIVS.Name = "dgvDBA_SYS_PRIVS";
            this.dgvDBA_SYS_PRIVS.Size = new System.Drawing.Size(560, 100);
            this.dgvDBA_SYS_PRIVS.TabIndex = 1;
            // 
            // lbDBA_SYS_PRIVS
            // 
            this.lbDBA_SYS_PRIVS.AutoSize = true;
            this.lbDBA_SYS_PRIVS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBA_SYS_PRIVS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDBA_SYS_PRIVS.Location = new System.Drawing.Point(12, 10);
            this.lbDBA_SYS_PRIVS.Name = "lbDBA_SYS_PRIVS";
            this.lbDBA_SYS_PRIVS.Size = new System.Drawing.Size(130, 21);
            this.lbDBA_SYS_PRIVS.TabIndex = 0;
            this.lbDBA_SYS_PRIVS.Text = "DBA_SYS_PRIVS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(74, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvDBA_ROLE);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(542, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 193);
            this.panel3.TabIndex = 33;
            // 
            // dgvDBA_ROLE
            // 
            this.dgvDBA_ROLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBA_ROLE.Location = new System.Drawing.Point(3, 42);
            this.dgvDBA_ROLE.Name = "dgvDBA_ROLE";
            this.dgvDBA_ROLE.Size = new System.Drawing.Size(743, 146);
            this.dgvDBA_ROLE.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "DBA_ROLE_PRIVS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvDBA_TAB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(538, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 193);
            this.panel2.TabIndex = 34;
            // 
            // dgvDBA_TAB
            // 
            this.dgvDBA_TAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBA_TAB.Location = new System.Drawing.Point(3, 42);
            this.dgvDBA_TAB.Name = "dgvDBA_TAB";
            this.dgvDBA_TAB.Size = new System.Drawing.Size(743, 146);
            this.dgvDBA_TAB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "DBA_TAB_PRIVS";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbxSearchUserName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(74, 594);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 91);
            this.panel4.TabIndex = 33;
            // 
            // cbxSearchUserName
            // 
            this.cbxSearchUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchUserName.FormattingEnabled = true;
            this.cbxSearchUserName.Location = new System.Drawing.Point(65, 37);
            this.cbxSearchUserName.Name = "cbxSearchUserName";
            this.cbxSearchUserName.Size = new System.Drawing.Size(255, 25);
            this.cbxSearchUserName.TabIndex = 32;
            this.cbxSearchUserName.SelectedIndexChanged += new System.EventHandler(this.cbxSearchUserName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "User Name";
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(1367, 743);
            this.Load += new System.EventHandler(this.UCSearch_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBA_SYS_PRIVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBA_ROLE)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBA_TAB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private EventHandler GetRoleName_Load()
        {
            throw new NotImplementedException();

        }

        #endregion
        private System.Windows.Forms.Label lbEnter;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ComboBox cbxSearchRoleName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDBA_SYS_PRIVS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDBA_SYS_PRIVS;
        private System.Windows.Forms.DataGridView dgvDBA_ROLE;
        private System.Windows.Forms.DataGridView dgvDBA_TAB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxSearchUserName;
        private System.Windows.Forms.Label label1;
    }
}
