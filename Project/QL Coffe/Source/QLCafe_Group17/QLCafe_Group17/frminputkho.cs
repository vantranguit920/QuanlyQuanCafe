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
    public partial class frminputkho : Form
    {
        List<Kho_DTO> list = new List<Kho_DTO>();
        bool isspmoi = false;
        public frminputkho()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            list = Kho_DAO.Instance.getList();
            cbbName.DataSource = list;
            cbbName.DisplayMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            float dongia;
            int soluong;
            string nn = "";
            try
            {
                nn = frmQL.nv.Name;
            }
            catch
            {

            }
            try
            {
                 dongia = float.Parse(txtDonGia.Text);
                 soluong = int.Parse(txtSL.Text);
            }
            catch
            {
                MessageBox.Show("Thong tin khong chinh xac");
                return;
            }
            
            if (!isspmoi)
            {
                foreach (Kho_DTO k in list)
                {

                    if (cbbName.Text.ToString() == k.Name)
                    {
                        id = k.Id;

                    }

                }
                if (Kho_DAO.Instance.NhapKho(id, soluong, dongia))
                {
                    
                   
                    if (Kho_DAO.Instance.TKnhap(id, cbbName.Text.ToString(), soluong, dongia, nn , txtNhacc.Text.ToString(), soluong * dongia))
                    {

                        MessageBox.Show("Nhập thành công! ");
                        txtDonGia.Text = "";
                     
                        txtNhacc.Text = "";
                        txtSL.Text = "";
                    }



                }
            }
            else
            {
                if (Kho_DAO.Instance.themspmoi(txtnamesp.Text.ToString(), soluong, dongia))
                {
                    int idsp = Kho_DAO.Instance.getID();

                   if( Kho_DAO.Instance.TKnhap(idsp, txtnamesp.Text.ToString(), soluong, dongia, nn, txtNhacc.Text.ToString(), soluong * dongia))
                    {
                        MessageBox.Show("Nhập thành công !");
                        txtDonGia.Text = "";
                        txtnamesp.Text = "";
                        txtNhacc.Text = "";
                        txtSL.Text = "";

                    }



                }

            }

            

        }

        private void cbbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtnamesp.Visible = true;
                isspmoi = true;
            }
            else
            {
                txtnamesp.Visible = false;
                isspmoi = false;
            }
        }
    }
}
