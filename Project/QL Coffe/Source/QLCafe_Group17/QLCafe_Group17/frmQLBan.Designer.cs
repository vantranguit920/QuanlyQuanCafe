namespace QLCafe_Group17
{
    partial class frmQLBan
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
            this.flListban = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKVI = new System.Windows.Forms.Button();
            this.btnKVII = new System.Windows.Forms.Button();
            this.btnKVIII = new System.Windows.Forms.Button();
            this.btnKVIV = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flListban
            // 
            this.flListban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flListban.Dock = System.Windows.Forms.DockStyle.Left;
            this.flListban.Location = new System.Drawing.Point(0, 0);
            this.flListban.Name = "flListban";
            this.flListban.Size = new System.Drawing.Size(531, 428);
            this.flListban.TabIndex = 0;
            // 
            // btnKVI
            // 
            this.btnKVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKVI.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKVI.Location = new System.Drawing.Point(537, 12);
            this.btnKVI.Name = "btnKVI";
            this.btnKVI.Size = new System.Drawing.Size(146, 63);
            this.btnKVI.TabIndex = 1;
            this.btnKVI.Text = "Khu Vực I";
            this.btnKVI.UseVisualStyleBackColor = false;
            this.btnKVI.Click += new System.EventHandler(this.btnKVI_Click);
            // 
            // btnKVII
            // 
            this.btnKVII.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKVII.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKVII.Location = new System.Drawing.Point(537, 96);
            this.btnKVII.Name = "btnKVII";
            this.btnKVII.Size = new System.Drawing.Size(146, 63);
            this.btnKVII.TabIndex = 2;
            this.btnKVII.Text = "Khu Vực II";
            this.btnKVII.UseVisualStyleBackColor = true;
            this.btnKVII.Click += new System.EventHandler(this.btnKVII_Click);
            // 
            // btnKVIII
            // 
            this.btnKVIII.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKVIII.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKVIII.Location = new System.Drawing.Point(537, 178);
            this.btnKVIII.Name = "btnKVIII";
            this.btnKVIII.Size = new System.Drawing.Size(146, 63);
            this.btnKVIII.TabIndex = 3;
            this.btnKVIII.Text = "Khu Vực III";
            this.btnKVIII.UseVisualStyleBackColor = true;
            this.btnKVIII.Click += new System.EventHandler(this.btnKVIII_Click);
            // 
            // btnKVIV
            // 
            this.btnKVIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKVIV.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKVIV.Location = new System.Drawing.Point(537, 259);
            this.btnKVIV.Name = "btnKVIV";
            this.btnKVIV.Size = new System.Drawing.Size(146, 63);
            this.btnKVIV.TabIndex = 4;
            this.btnKVIV.Text = "Khu Vực IV";
            this.btnKVIV.UseVisualStyleBackColor = true;
            this.btnKVIV.Click += new System.EventHandler(this.btnKVIV_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(537, 343);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 63);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Bàn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 428);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnKVIV);
            this.Controls.Add(this.btnKVIII);
            this.Controls.Add(this.btnKVII);
            this.Controls.Add(this.btnKVI);
            this.Controls.Add(this.flListban);
            this.Name = "frmQLBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLBan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQLBan_FormClosed);
            this.Load += new System.EventHandler(this.frmQLBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flListban;
        private System.Windows.Forms.Button btnKVI;
        private System.Windows.Forms.Button btnKVII;
        private System.Windows.Forms.Button btnKVIII;
        private System.Windows.Forms.Button btnKVIV;
        private System.Windows.Forms.Button btnThem;
    }
}