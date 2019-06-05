namespace QLCafe_Group17
{
    partial class frmNhansu
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
            this.flNhansu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flNhansu
            // 
            this.flNhansu.AutoScroll = true;
            this.flNhansu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flNhansu.Location = new System.Drawing.Point(0, 0);
            this.flNhansu.Name = "flNhansu";
            this.flNhansu.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flNhansu.Size = new System.Drawing.Size(775, 385);
            this.flNhansu.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(293, 391);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(181, 47);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Thêm Nhân Viên";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmNhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.flNhansu);
            this.Name = "frmNhansu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhansu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flNhansu;
        private System.Windows.Forms.Button btnadd;
    }
}