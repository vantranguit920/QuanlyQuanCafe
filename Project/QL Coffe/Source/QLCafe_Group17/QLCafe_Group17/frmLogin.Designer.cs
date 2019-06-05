namespace QLCafe_Group17
{
    partial class frmLogin
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
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_tendn = new System.Windows.Forms.Label();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.grb_DangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_DangNhap
            // 
            this.grb_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_DangNhap.Controls.Add(this.txt_tendn);
            this.grb_DangNhap.Controls.Add(this.txt_matkhau);
            this.grb_DangNhap.Controls.Add(this.lbl_tendn);
            this.grb_DangNhap.Controls.Add(this.btn_dangnhap);
            this.grb_DangNhap.Controls.Add(this.btn_thoat);
            this.grb_DangNhap.Controls.Add(this.lbl_matkhau);
            this.grb_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_DangNhap.Location = new System.Drawing.Point(32, 32);
            this.grb_DangNhap.Name = "grb_DangNhap";
            this.grb_DangNhap.Size = new System.Drawing.Size(459, 189);
            this.grb_DangNhap.TabIndex = 1;
            this.grb_DangNhap.TabStop = false;
            this.grb_DangNhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.grb_DangNhap.Enter += new System.EventHandler(this.grb_DangNhap_Enter);
            // 
            // txt_tendn
            // 
            this.txt_tendn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendn.Location = new System.Drawing.Point(176, 50);
            this.txt_tendn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(223, 26);
            this.txt_tendn.TabIndex = 0;
            this.txt_tendn.TextChanged += new System.EventHandler(this.txt_tendn_TextChanged);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(176, 87);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(223, 26);
            this.txt_matkhau.TabIndex = 1;
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // lbl_tendn
            // 
            this.lbl_tendn.AutoSize = true;
            this.lbl_tendn.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tendn.Location = new System.Drawing.Point(54, 53);
            this.lbl_tendn.Name = "lbl_tendn";
            this.lbl_tendn.Size = new System.Drawing.Size(116, 20);
            this.lbl_tendn.TabIndex = 3;
            this.lbl_tendn.Text = "Tên đăng nhập";
            this.lbl_tendn.Click += new System.EventHandler(this.lbl_tendn_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.White;
            this.btn_dangnhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dangnhap.Location = new System.Drawing.Point(176, 144);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(103, 38);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
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
            this.lbl_matkhau.Location = new System.Drawing.Point(54, 90);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(78, 20);
            this.lbl_matkhau.TabIndex = 4;
            this.lbl_matkhau.Text = "Mật khẩu";
            this.lbl_matkhau.Click += new System.EventHandler(this.lbl_matkhau_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::QLCafe_Group17.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef0221;
            this.ClientSize = new System.Drawing.Size(524, 258);
            this.Controls.Add(this.grb_DangNhap);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.grb_DangNhap.ResumeLayout(false);
            this.grb_DangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_DangNhap;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_tendn;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_matkhau;
    }
}