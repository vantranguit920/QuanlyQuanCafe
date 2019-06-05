namespace QLCafe_Group17
{
    partial class frmBan
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
            this.flbBan = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flbBan
            // 
            this.flbBan.AutoScroll = true;
            this.flbBan.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.flbBan.BackColor = System.Drawing.Color.LightGray;
            this.flbBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbBan.Location = new System.Drawing.Point(0, 0);
            this.flbBan.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flbBan.Name = "flbBan";
            this.flbBan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flbBan.Size = new System.Drawing.Size(782, 562);
            this.flbBan.TabIndex = 0;
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.flbBan);
            this.MaximizeBox = false;
            this.Name = "frmBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBan_FormClosing);
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flbBan;
    }
}