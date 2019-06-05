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
    public partial class frmQL : Form
    {
        public  int typeus;
        public static List<SanPhamGoi_DTO> listspg = new List<SanPhamGoi_DTO>();
        public static NhanSu_DTO nv;
        string cv=null;
        public frmQL(int typeuss)
        {
            InitializeComponent();
            typeus = typeuss;
            load();
        }

        void load()
        {
            if (typeus != 0)
            {
                nv = Nhansu_DAO.Instance.getnv(typeus);
                cv = nv.Chucvu;

            }
            
        }




        private void ucKhuVuc1_Load(object sender, EventArgs e)
        {
            
            ucKhuVuc1.NameKV = "Khu Vực I";
            ucKhuVuc1.Id = "1";


            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("1");
            foreach(Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }
            ucKhuVuc1.loada += loadall;

            ucKhuVuc1.Sl = list.Count;           
            ucKhuVuc1.Slemty = coutemty;
            ucKhuVuc1.loadinfo();
        }

        private void ucKhuVuc2_Load(object sender, EventArgs e)
        {
            ucKhuVuc2.NameKV = "Khu Vực II";

            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("2");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }
            ucKhuVuc2.loada += loadall;
            ucKhuVuc2.Sl = list.Count;
            ucKhuVuc2.Id = "2";
            ucKhuVuc2.Slemty = coutemty;
            ucKhuVuc2.loadinfo();
        }

        private void ucKhuVuc4_Load(object sender, EventArgs e)
        {
            ucKhuVuc4.NameKV = "Khu Vực IV";
           


            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("4");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }
            ucKhuVuc4.loada += loadall;

            ucKhuVuc4.Sl = list.Count;
            ucKhuVuc4.Id = "4";
            ucKhuVuc4.Slemty = coutemty;
            ucKhuVuc4.loadinfo();
        }

        private void ucKhuVuc3_Load(object sender, EventArgs e)
        {
            ucKhuVuc3.NameKV = "Khu Vực IV";
            

            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("3");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }

            ucKhuVuc3.loada += loadall;
            ucKhuVuc3.Sl = list.Count;
            ucKhuVuc3.Id = "3";
            ucKhuVuc3.Slemty = coutemty;
            ucKhuVuc3.loadinfo();
        }


        public void loadinfo1()
        {

            ucKhuVuc1.NameKV = "Khu Vực I";
            ucKhuVuc1.Id = "1";


            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("1");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }


            ucKhuVuc1.Sl = list.Count;
            ucKhuVuc1.Slemty = coutemty;
            ucKhuVuc1.loadinfo();

        }
        public void loadinfo2()
        {
            ucKhuVuc2.NameKV = "Khu Vực II";

            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("2");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }

            ucKhuVuc2.Sl = list.Count;
            ucKhuVuc2.Id = "2";
            ucKhuVuc2.Slemty = coutemty;
            ucKhuVuc2.loadinfo();

        }
        public void loadinfo3()
        {
            ucKhuVuc3.NameKV = "Khu Vực III";



            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("3");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }
            ucKhuVuc3.Sl = list.Count;
            ucKhuVuc3.Id = "3";
            ucKhuVuc3.Slemty = coutemty;
            ucKhuVuc3.loadinfo();

        }
        public void loadinfo4()
        {

            ucKhuVuc4.NameKV = "Khu Vực IV";


            int coutemty = 0;
            List<Ban_DTO> list = Ban_DAO.Instance.listTable("4");
            foreach (Ban_DTO b in list)
            {
                if (b.Stt == true)
                {
                    coutemty++;
                }
            }
            ucKhuVuc4.Sl = list.Count;
            ucKhuVuc4.Id = "4";
            ucKhuVuc4.Slemty = coutemty;
            ucKhuVuc4.loadinfo();
        }



        public void loadall()
        {
            loadinfo1();
            loadinfo2();
            loadinfo3();
            loadinfo4();
        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cv == null || cv == "Quản Lý")
            {
                frmNhansu frm = new frmNhansu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang nay");
            }

            
        }

        private void quảnLýCơSởToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (cv == null || cv == "Quản Lý")
            {
                frmQLBan frmQLBanc = new frmQLBan();
                frmQLBanc.loada += loadall;
                frmQLBanc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang nay");
            }
            
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cv == null||cv == "Quản Lý")
            {
              frmQLmenu frm = new frmQLmenu();
              frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang nay");
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            if (cv == null || cv == "Quản Lý")
            {
                frmThongKe frm = new frmThongKe();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang nay");
            }
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cv == null || cv == "Quản Lý")
            {
                frmKho frm = new frmKho();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang nay");
            }
           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            
            this.Close();
            frm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            frm.ShowDialog();
        }
    }
}
