﻿namespace QLCafe_Group17
{
    partial class frmDoiMk
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
            this.grb_DangNhap = new System.Windows.Forms.GroupBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.txtMk2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_DangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_DangNhap
            // 
            this.grb_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_DangNhap.Controls.Add(this.txtMk2);
            this.grb_DangNhap.Controls.Add(this.label1);
            this.grb_DangNhap.Controls.Add(this.txt_matkhau);
            this.grb_DangNhap.Controls.Add(this.btn_thoat);
            this.grb_DangNhap.Controls.Add(this.lbl_matkhau);
            this.grb_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_DangNhap.Location = new System.Drawing.Point(23, 38);
            this.grb_DangNhap.Name = "grb_DangNhap";
            this.grb_DangNhap.Size = new System.Drawing.Size(459, 189);
            this.grb_DangNhap.TabIndex = 2;
            this.grb_DangNhap.TabStop = false;
            this.grb_DangNhap.Text = "ĐỔI MẬT KHẨU";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(176, 69);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(223, 26);
            this.txt_matkhau.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.White;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Location = new System.Drawing.Point(293, 144);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 38);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Đổi mật khẩu";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_matkhau.Location = new System.Drawing.Point(18, 72);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(78, 20);
            this.lbl_matkhau.TabIndex = 4;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // txtMk2
            // 
            this.txtMk2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk2.Location = new System.Drawing.Point(176, 103);
            this.txtMk2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMk2.Name = "txtMk2";
            this.txtMk2.PasswordChar = '*';
            this.txtMk2.Size = new System.Drawing.Size(223, 26);
            this.txtMk2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // frmDoiMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 264);
            this.Controls.Add(this.grb_DangNhap);
            this.Name = "frmDoiMk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMk";
            this.Load += new System.EventHandler(this.frmDoiMk_Load);
            this.grb_DangNhap.ResumeLayout(false);
            this.grb_DangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_DangNhap;
        private System.Windows.Forms.TextBox txtMk2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_matkhau;
    }
}