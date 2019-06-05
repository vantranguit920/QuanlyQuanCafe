namespace QLCafe_Group17
{
    partial class UCtable
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
            this.btngoi = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.pnstt = new System.Windows.Forms.Panel();
            this.lblBan = new System.Windows.Forms.Label();
            this.pnstt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngoi
            // 
            this.btngoi.BackColor = System.Drawing.Color.Silver;
            this.btngoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoi.Location = new System.Drawing.Point(89, 61);
            this.btngoi.Name = "btngoi";
            this.btngoi.Size = new System.Drawing.Size(53, 34);
            this.btngoi.TabIndex = 0;
            this.btngoi.Text = "Order";
            this.btngoi.UseVisualStyleBackColor = false;
            this.btngoi.Click += new System.EventHandler(this.btngoi_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.Silver;
            this.btnThanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhtoan.Location = new System.Drawing.Point(3, 61);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(80, 33);
            this.btnThanhtoan.TabIndex = 1;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.BackColor = System.Drawing.Color.Silver;
            this.btnChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyen.Location = new System.Drawing.Point(150, 61);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(80, 34);
            this.btnChuyen.TabIndex = 4;
            this.btnChuyen.Text = "Chuyển Bàn";
            this.btnChuyen.UseVisualStyleBackColor = false;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // pnstt
            // 
            this.pnstt.Controls.Add(this.lblBan);
            this.pnstt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnstt.Location = new System.Drawing.Point(0, 0);
            this.pnstt.Name = "pnstt";
            this.pnstt.Size = new System.Drawing.Size(236, 52);
            this.pnstt.TabIndex = 5;
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(93, 15);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(49, 19);
            this.lblBan.TabIndex = 0;
            this.lblBan.Text = "Bàn 1";
            // 
            // UCtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnstt);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btngoi);
            this.Name = "UCtable";
            this.Size = new System.Drawing.Size(236, 101);
            this.pnstt.ResumeLayout(false);
            this.pnstt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngoi;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Panel pnstt;
        private System.Windows.Forms.Label lblBan;
    }
}
