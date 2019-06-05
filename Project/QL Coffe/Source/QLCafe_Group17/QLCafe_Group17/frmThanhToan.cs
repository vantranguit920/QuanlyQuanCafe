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
using System.Globalization;

namespace QLCafe_Group17
{
    public partial class frmThanhToan : Form
    {
        int id;
        int giagiam = 0;
        bool Tinhtruoc = false;
        float money=0;
        public delegate void loadII(bool stt);
        public event loadII loadtable;
        List<CTHD_DTO> listTT = new List<CTHD_DTO>();
        public frmThanhToan(int idban)
        {
            InitializeComponent();
            this.id = idban;
            load();
        }
        void load()
        {
            dtgCTHD.DataSource = CTHD_DAO.Instance.getHDTT(id);
            listTT = CTHD_DAO.Instance.getbyid(id);
            foreach(CTHD_DTO hd in listTT)
            {
                money += hd.Dongia * hd.SL1;
            }
            CultureInfo cutural = new CultureInfo("vi-VN");
            txtTongtien.Text = money.ToString("c",cutural);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(txtgiam.Text.ToString()!=string.Empty)
            {
                try
                {
                    giagiam = int.Parse(txtgiam.Text.ToString());

                }
                catch
                {
                    giagiam = 0;
                    flag = false;
                }
            }
            else
            {
                giagiam = 0;
            }

            
            
            if(flag == false)
            {
                MessageBox.Show("Gia giam sai! ");
            }
            else
            {
                if (giagiam != 0)
                {
                    money = money - (money * giagiam) / 100;
                }

                prtWdialog.Document = prtDocumentHD;
                CTHD_DAO.Instance.ThanhToan(id);


                if (!Tinhtruoc)
                {
                    Ban_DAO.Instance.updateTable(id, 0);
                    loadtable(true);
                }
                
                //DateTime dt = DateTime.Today;



                //String.Format("{0:d}", dt);

                ThongKe_DAO.Instance.insert(id, money);

                foreach (CTHD_DTO hd in listTT)
                {
                    Kho_DAO.Instance.xuatkho(hd.IdSP, hd.SL1);
                    Kho_DAO.Instance.xuatmenu(hd.IdSP, hd.SL1);

                }




                

                this.Close();
                prtWdialog.ShowDialog();
            }
            
        }

        private void prtDocumentHD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            CultureInfo cutural = new CultureInfo("vi-VN");
            e.Graphics.DrawString(@" Cafe Truyền Thuyết ", new Font("Brush", 25, FontStyle.Italic), Brushes.Black, 250, 100);
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 300, 200);
            Bitmap bmt = new Bitmap(dtgCTHD.Width,dtgCTHD.Height);
            dtgCTHD.DrawToBitmap(bmt,new Rectangle(0,0,dtgCTHD.Width,dtgCTHD.RowCount*dtgCTHD.RowTemplate.Height));
            e.Graphics.DrawImage(bmt, 150, 300);
            e.Graphics.DrawString(" Người thanh toán:"+ frmQL.nv.Name, new Font("Brush", 20, FontStyle.Italic), Brushes.Black, 300, 350 + dtgCTHD.RowCount * dtgCTHD.RowTemplate.Height);
            e.Graphics.DrawString(" Ngày thanh toán:   " + DateTime.Now.ToString(), new Font("Brush", 20, FontStyle.Italic), Brushes.Black, 300, 350 + dtgCTHD.RowCount * dtgCTHD.RowTemplate.Height+50);

            e.Graphics.DrawString(" Tổng Tiền:  " + money.ToString("c", cutural) , new Font("Brush", 20, FontStyle.Italic), Brushes.Black, 400, 350 + dtgCTHD.RowCount * dtgCTHD.RowTemplate.Height+100);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Tinhtruoc = true;
            }
            else
            {
                Tinhtruoc = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ban_DAO.Instance.updateTable(id, 0);
            loadtable(true);

        }
    }
}
