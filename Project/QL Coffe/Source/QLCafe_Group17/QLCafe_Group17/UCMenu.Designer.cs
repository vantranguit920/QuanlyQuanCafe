namespace QLCafe_Group17
{
    partial class UCMenu
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
            this.cbbSL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.pctImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSL
            // 
            this.cbbSL.FormattingEnabled = true;
            this.cbbSL.Location = new System.Drawing.Point(90, 106);
            this.cbbSL.Name = "cbbSL";
            this.cbbSL.Size = new System.Drawing.Size(68, 21);
            this.cbbSL.TabIndex = 1;
            this.cbbSL.SelectedIndexChanged += new System.EventHandler(this.cbbSL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Lượng";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(3, 80);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(40, 16);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(87, 80);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(37, 16);
            this.lblprice.TabIndex = 4;
            this.lblprice.Text = "Price";
            this.lblprice.Click += new System.EventHandler(this.label2_Click);
            // 
            // pctImage
            // 
            this.pctImage.BackgroundImage = global::QLCafe_Group17.Properties.Resources.Menu;
            this.pctImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctImage.Location = new System.Drawing.Point(31, 3);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(101, 69);
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSL);
            this.Controls.Add(this.pctImage);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(167, 132);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.ComboBox cbbSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblprice;
    }
}
