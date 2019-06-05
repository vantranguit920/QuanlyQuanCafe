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
    public partial class frmXuatkho : Form
    {
        List<Kho_DTO> list = new List<Kho_DTO>();
        public frmXuatkho()
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
            string nx = "";
            int soluong = 0;
            try
            {
                soluong = int.Parse(txtSL.Text);
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập sai! ");
                return;
            }
           


            foreach (Kho_DTO k in list)
            {

                if (cbbName.Text.ToString() == k.Name)
                {
                    id = k.Id;

                }

            }
            try
            {
                nx = frmQL.nv.Name;
            }
            catch
            {

            }

            if (Kho_DAO.Instance.xuatkho(id, soluong))
            {
                if (Kho_DAO.Instance.TKxuat(id, cbbName.Text.ToString(),soluong,txtNhan.Text.ToString(),nx))
                {
                    MessageBox.Show("Xuat thanh cong");
                    txtNhan.Text = "";
                    txtSL.Text = "";
                }
            }

        }
    }
}
