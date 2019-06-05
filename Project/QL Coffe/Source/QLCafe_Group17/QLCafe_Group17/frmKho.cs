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

namespace QLCafe_Group17
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTong.Text = "";
            frminputkho frm = new frminputkho();
            frm.ShowDialog();
            //frmNhapkho frm = new frmNhapkho();
            //frm.ShowDialog();
        }
        void load()
        {
            dataGridView1.DataSource = Kho_DAO.Instance.getKho();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            String.Format("{0:d}", dt1);
            String.Format("{0:d}", dt2);





            dataGridView1.DataSource = Kho_DAO.Instance.TKnhapkho(dt1,dt2);




            float Tongtien = 0;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Tongtien += float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            CultureInfo cutural = new CultureInfo("vi-VN");
            txtTong.Text = Tongtien.ToString("c",cutural);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTong.Text = "";
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTong.Text = "";
            frmXuatkho frm = new frmXuatkho();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTong.Text = "";
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            String.Format("{0:d}", dt1);
            String.Format("{0:d}", dt2);
            dataGridView1.DataSource = Kho_DAO.Instance.TKXuatkho(dt1,dt2);

            //float Tongtien = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    Tongtien += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            //}
            //CultureInfo cutural = new CultureInfo("vi-VN");
            //txtTong.Text = Tongtien.ToString("c", cutural);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmXoakho frm = new frmXoakho();
            frm.ShowDialog();
        }
    }
}
