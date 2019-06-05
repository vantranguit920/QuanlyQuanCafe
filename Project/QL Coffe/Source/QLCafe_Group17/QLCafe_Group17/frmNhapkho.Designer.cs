namespace QLCafe_Group17
{
    partial class frmNhapkho
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
            this.dtgkho = new System.Windows.Forms.DataGridView();
            this.lblnhacc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbname = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkho)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgkho
            // 
            this.dtgkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgkho.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgkho.Location = new System.Drawing.Point(0, 0);
            this.dtgkho.Name = "dtgkho";
            this.dtgkho.Size = new System.Drawing.Size(568, 315);
            this.dtgkho.TabIndex = 1;
            // 
            // lblnhacc
            // 
            this.lblnhacc.AutoSize = true;
            this.lblnhacc.Location = new System.Drawing.Point(25, 325);
            this.lblnhacc.Name = "lblnhacc";
            this.lblnhacc.Size = new System.Drawing.Size(75, 13);
            this.lblnhacc.TabIndex = 2;
            this.lblnhacc.Text = "Nha cung cap";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "San pham ";
            // 
            // cbbname
            // 
            this.cbbname.FormattingEnabled = true;
            this.cbbname.Location = new System.Drawing.Point(131, 356);
            this.cbbname.Name = "cbbname";
            this.cbbname.Size = new System.Drawing.Size(131, 21);
            this.cbbname.TabIndex = 5;
            this.cbbname.SelectedIndexChanged += new System.EventHandler(this.cbbname_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmNhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblnhacc);
            this.Controls.Add(this.dtgkho);
            this.Name = "frmNhapkho";
            this.Text = "frmNhapkho";
            ((System.ComponentModel.ISupportInitialize)(this.dtgkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgkho;
        private System.Windows.Forms.Label lblnhacc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbname;
        private System.Windows.Forms.Button btnAdd;
    }
}