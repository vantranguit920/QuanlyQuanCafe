namespace QLCafe_Group17
{
    partial class frmOrder
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
            this.flOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flOrder
            // 
            this.flOrder.AutoScroll = true;
            this.flOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flOrder.Location = new System.Drawing.Point(0, 0);
            this.flOrder.Name = "flOrder";
            this.flOrder.Size = new System.Drawing.Size(644, 419);
            this.flOrder.TabIndex = 0;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 419);
            this.Controls.Add(this.flOrder);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flOrder;
    }
}