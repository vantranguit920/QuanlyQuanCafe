using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace QLCafe_Group17
{
    public partial class ULCOrder : UserControl
    {
        int idorder;
        List<CTHD_DTO> list = new List<CTHD_DTO>();
        int idban;
        string nametable;
        string khV;
        public delegate void load();
        public event load loadfrm;

        public ULCOrder(int id,int idban1,string nameban,string kv)
        {
            InitializeComponent();
            idorder = id;
            idban = idban1;
            nametable = nameban;
            khV = kv;
            loadinfo();
        }
        void loadinfo()
        {




            list = CTHD_DAO.Instance.getbyid(idban);


            lblban.Text = nametable + "   KV:  " + khV;


            foreach (CTHD_DTO sp in list)
            {
                UCorderII uc = new UCorderII();
                uc.name = sp.Name;
                uc.sl = sp.SL1;
                uc.load();             
                flowLayoutPanel1.Controls.Add(uc);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ULCOrder_Load(object sender, EventArgs e)
        {
            





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(HoaDon_DAO.Instance.update(idorder, 1))
            {
                MessageBox.Show("Giao mon thanh cong !");
                loadfrm();
            }



        }
    }
}
