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
    public partial class frmBan : Form
    {
        public delegate void loadall();
        public event loadall loadkv;


        public List<Ban_DTO> listBan = new List<Ban_DTO>();
        int sl;
        string id;
        public frmBan(string id)
        {
            InitializeComponent();
            this.id = id;
            loadban();
        }

        void loadban()
        {
            flbBan.Controls.Clear();
            listBan.Clear();
            listBan = Ban_DAO.Instance.listTable(id.ToString());


            foreach(Ban_DTO table in listBan)
            {
                UCtable ucTable = new UCtable();
                ucTable.Name1 = table.Name;
                ucTable.Status = table.Stt;
                ucTable.Id = table.Id;


                ucTable.loadstt += loadban;
                //ucTable.Tag = table;
                ucTable.loadinfo();
                flbBan.Controls.Add(ucTable);
            }
        }

        private void frmBan_Load(object sender, EventArgs e)
        {

        }

        private void frmBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadkv();
        }
    }
}
