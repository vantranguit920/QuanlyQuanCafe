namespace QLCafe_Group17
{
    partial class UCNhanVien
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtIdcard = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(136, 41);
            this.txtphone.Name = "txtphone";
            this.txtphone.ReadOnly = true;
            this.txtphone.Size = new System.Drawing.Size(167, 20);
            this.txtphone.TabIndex = 2;
            // 
            // txtIdcard
            // 
            this.txtIdcard.Location = new System.Drawing.Point(136, 69);
            this.txtIdcard.Name = "txtIdcard";
            this.txtIdcard.ReadOnly = true;
            this.txtIdcard.Size = new System.Drawing.Size(167, 20);
            this.txtIdcard.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(136, 95);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(167, 20);
            this.txtAdress.TabIndex = 4;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(136, 121);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 37);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(230, 121);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(75, 37);
            this.btnDele.TabIndex = 6;
            this.btnDele.Text = "Delete";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::QLCafe_Group17.Properties.Resources.Manager_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnDele);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtIdcard);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(316, 161);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtIdcard;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDele;
    }
}
