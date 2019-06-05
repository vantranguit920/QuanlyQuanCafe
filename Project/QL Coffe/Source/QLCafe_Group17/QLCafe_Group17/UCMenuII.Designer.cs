namespace QLCafe_Group17
{
    partial class UCMenuII
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
            this.btndelete = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(107, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 37);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(13, 93);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(40, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.Location = new System.Drawing.Point(13, 109);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(28, 16);
            this.lblgia.TabIndex = 3;
            this.lblgia.Text = "Gia";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Location = new System.Drawing.Point(107, 49);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 37);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // pctMenu
            // 
            this.pctMenu.BackgroundImage = global::QLCafe_Group17.Properties.Resources.Menu;
            this.pctMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctMenu.Location = new System.Drawing.Point(4, 4);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(100, 82);
            this.pctMenu.TabIndex = 0;
            this.pctMenu.TabStop = false;
            // 
            // UCMenuII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblgia);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.pctMenu);
            this.Name = "UCMenuII";
            this.Size = new System.Drawing.Size(188, 128);
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.Button btnupdate;
    }
}
