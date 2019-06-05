using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace QLCafe_Group17
{
    public partial class frmQLBan : Form
    {
        public delegate void loadall();
        public event loadall loada;



        List<Ban_DTO> list = new List<Ban_DTO>();
        public frmQLBan()
        {
            InitializeComponent();
        }

        private void frmQLBan_Load(object sender, EventArgs e)
        {
            load(1);
        }

        void load(int kv)
        {
            switch (kv)
            {
                case 1:btnKVI.BackColor = Color.Red;
                    break;
                case 2: btnKVII.BackColor = Color.Red;
                    break;
                case 3:btnKVIII.BackColor = Color.Red;
                    break;
                case 4: btnKVIV.BackColor = Color.Red;
                    break;
                default: break;

            }
            flListban.Controls.Clear();
            list = Ban_DAO.Instance.listTable(kv.ToString());

            foreach(Ban_DTO b in list)
            {
                UCBanII uC = new UCBanII();
                uC.Name1 = b.Name;
                uC.Id = b.Id;
                uC.Kv = b.Kv;
                uC.Stt = b.Stt;
                uC.loadkv += load;
                uC.loadinfo();
                flListban.Controls.Add(uC);

            }






        }

        private void btnKVI_Click(object sender, EventArgs e)
        {
            btnKVI.BackColor = Color.Red;
            btnKVII.BackColor = Color.White;
            btnKVIII.BackColor = Color.White;
            btnKVIV.BackColor = Color.White;
            load(1);

        }

        private void btnKVII_Click(object sender, EventArgs e)
        {
            btnKVI.BackColor = Color.White;
            btnKVII.BackColor = Color.Red;
            btnKVIII.BackColor = Color.White;
            btnKVIV.BackColor = Color.White;
            load(2);
        }

        private void btnKVIII_Click(object sender, EventArgs e)
        {
            btnKVI.BackColor = Color.White;
            btnKVIII.BackColor = Color.Red;
            btnKVII.BackColor = Color.White;
            btnKVIV.BackColor = Color.White;
            load(3);
        }

        private void btnKVIV_Click(object sender, EventArgs e)
        {

            btnKVI.BackColor = Color.White;
            btnKVIV.BackColor = Color.Red;
            btnKVII.BackColor = Color.White;
            btnKVIII.BackColor = Color.White;
            load(4);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddBan frm = new frmAddBan();
            frm.load += load;
            frm.ShowDialog();
        }

        private void frmQLBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            loada();
        }
    }
}
