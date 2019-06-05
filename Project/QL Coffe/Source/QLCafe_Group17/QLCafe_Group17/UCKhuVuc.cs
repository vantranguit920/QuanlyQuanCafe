using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCafe_Group17
{
    
    public partial class UCKhuVuc : UserControl
    {

        public delegate void loadall();
        public event loadall loada;


        string nameKV;
        int sl;
        int slemty;
        string id;
        public UCKhuVuc()
        {
            InitializeComponent();
        }

        public string NameKV { get => nameKV; set => nameKV = value; }
        public int Sl { get => sl; set => sl = value; }
        public int Slemty { get => slemty; set => slemty = value; }
        public string Id { get => id; set => id = value; }


        public void loadKV()
        {
            loada();
        }


        public void loadinfo()
        {
            lblName.Text = nameKV;
            lblSL.Text = sl.ToString();
            lblEmty.Text = slemty.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            click();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            click();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            click();
        }
        void click()
        {
            frmBan _frmban = new frmBan(id);
            
            _frmban.loadkv += loadKV;
            _frmban.ShowDialog();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            click();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            click();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            click();
        }

        private void lblEmty_Click(object sender, EventArgs e)
        {
            click();
        }

        private void lblSL_Click(object sender, EventArgs e)
        {
            click();
        }
    }
}
