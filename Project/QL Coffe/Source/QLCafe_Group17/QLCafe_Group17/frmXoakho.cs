using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QLCafe_Group17
{
    public partial class frmXoakho : Form
    {
        private Label label1;
        private ComboBox cbbname;
        private Button button1;
        List<Kho_DTO> list = new List<Kho_DTO>();
        public frmXoakho()
        {
            InitializeComponent();
            load();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbname = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // cbbname
            // 
            this.cbbname.FormattingEnabled = true;
            this.cbbname.Location = new System.Drawing.Point(118, 42);
            this.cbbname.Name = "cbbname";
            this.cbbname.Size = new System.Drawing.Size(121, 21);
            this.cbbname.TabIndex = 1;
            this.cbbname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmXoakho
            // 
            this.ClientSize = new System.Drawing.Size(306, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbname);
            this.Controls.Add(this.label1);
            this.Name = "frmXoakho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        void load()
        {
            list = Kho_DAO.Instance.getList();
            cbbname.DataSource = list;
            cbbname.DisplayMember = "name";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=0;
            foreach (Kho_DTO k in list)
            {

                if (cbbname.Text.ToString() == k.Name)
                {
                    id = k.Id;

                }

            }

            if (Kho_DAO.Instance.xoasp(id))
            {
                MessageBox.Show("Xoa thanh cong!");
                load();
            }
        }
    }
}
