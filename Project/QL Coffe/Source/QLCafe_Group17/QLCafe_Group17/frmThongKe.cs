using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QLCafe_Group17
{
    public partial class frmThongKe : Form
    {
        List<Thongke_DTO> list = new List<Thongke_DTO>();
        float sumoney = 0.0f;
        public frmThongKe()
        {
            InitializeComponent();
            load();
        }


        public void load()
        {
            dtGThongke.DataSource = ThongKe_DAO.Instance.GetBaoCao(dateTimePicker1.Value,dateTimePicker2.Value);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            sumoney = 0;
            DateTime dt =  dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            String.Format("{0:d}", dt);
            String.Format("{0:d}", dt2);
            dtGThongke.DataSource = ThongKe_DAO.Instance.GetBaoCao(dt, dt2);

            list = ThongKe_DAO.Instance.getlist(dt, dt2);


            foreach (Thongke_DTO tk in list)
            {
                sumoney += tk.Money;
            }
            CultureInfo cutural = new CultureInfo("vi-VN");
            textBox1.Text = "Tổng doanh thu :  " + sumoney.ToString("c",cutural);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            CultureInfo cutural = new CultureInfo("vi-VN");
            e.Graphics.DrawString(@" Cafe Truyền Thuyết ", new Font("Brush", 25, FontStyle.Italic), Brushes.Black, 250, 100);
            e.Graphics.DrawString("THỐNG KÊ", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 300, 200);
            Bitmap bmt = new Bitmap(dtGThongke.Width, dtGThongke.Height);
            dtGThongke.DrawToBitmap(bmt, new Rectangle(0, 0, dtGThongke.Width, list.Count * dtGThongke.RowTemplate.Height));
            e.Graphics.DrawImage(bmt, 150, 300);
            e.Graphics.DrawString(" Tổng Tiền:  " + sumoney.ToString("c", cutural), new Font("Brush", 20, FontStyle.Italic), Brushes.Black, 400, 300 + list.Count * dtGThongke.RowTemplate.Height + 50);




        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;




            printPreviewDialog1.ShowDialog();
        }
    }
}
