namespace QLCafe_Group17
{
    partial class frmChuyenban
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbkv = new System.Windows.Forms.ComboBox();
            this.cbbban = new System.Windows.Forms.ComboBox();
            this.btnchuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu vực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn";
            // 
            // cbbkv
            // 
            this.cbbkv.FormattingEnabled = true;
            this.cbbkv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbkv.Location = new System.Drawing.Point(102, 37);
            this.cbbkv.Name = "cbbkv";
            this.cbbkv.Size = new System.Drawing.Size(121, 21);
            this.cbbkv.TabIndex = 2;
            this.cbbkv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbban
            // 
            this.cbbban.FormattingEnabled = true;
            this.cbbban.Location = new System.Drawing.Point(102, 78);
            this.cbbban.Name = "cbbban";
            this.cbbban.Size = new System.Drawing.Size(121, 21);
            this.cbbban.TabIndex = 3;
            // 
            // btnchuyen
            // 
            this.btnchuyen.Location = new System.Drawing.Point(97, 129);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(92, 34);
            this.btnchuyen.TabIndex = 4;
            this.btnchuyen.Text = "Chuyển";
            this.btnchuyen.UseVisualStyleBackColor = true;
            this.btnchuyen.Click += new System.EventHandler(this.btnchuyen_Click);
            // 
            // frmChuyenban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 175);
            this.Controls.Add(this.btnchuyen);
            this.Controls.Add(this.cbbban);
            this.Controls.Add(this.cbbkv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbkv;
        private System.Windows.Forms.ComboBox cbbban;
        private System.Windows.Forms.Button btnchuyen;
    }
}