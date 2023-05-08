namespace Demo
{
    partial class FormUpdateDA
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maDA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tenDA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phong = new System.Windows.Forms.TextBox();
            this.ngayBD = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đề án:";
            // 
            // maDA
            // 
            this.maDA.AutoSize = true;
            this.maDA.Location = new System.Drawing.Point(168, 40);
            this.maDA.Name = "maDA";
            this.maDA.Size = new System.Drawing.Size(44, 16);
            this.maDA.TabIndex = 2;
            this.maDA.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(143, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tenDA
            // 
            this.tenDA.Location = new System.Drawing.Point(171, 70);
            this.tenDA.Name = "tenDA";
            this.tenDA.Size = new System.Drawing.Size(200, 22);
            this.tenDA.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phòng:";
            // 
            // phong
            // 
            this.phong.Location = new System.Drawing.Point(171, 152);
            this.phong.Name = "phong";
            this.phong.Size = new System.Drawing.Size(79, 22);
            this.phong.TabIndex = 9;
            // 
            // ngayBD
            // 
            this.ngayBD.Location = new System.Drawing.Point(171, 110);
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.Size = new System.Drawing.Size(200, 22);
            this.ngayBD.TabIndex = 11;
            // 
            // FormUpdateDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 264);
            this.Controls.Add(this.ngayBD);
            this.Controls.Add(this.phong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tenDA);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateDA";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.FormUpdateDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tenDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phong;
        private System.Windows.Forms.DateTimePicker ngayBD;
    }
}