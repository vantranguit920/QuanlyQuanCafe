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

namespace QLCafe_Group17
{
    public partial class frmAddmenu : Form
    {
        public delegate void load();
        public event load loadmn;
        public frmAddmenu()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string name = "";
            float dongia = 0.0f;
            if (txtname.Text.ToString()==string.Empty)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            try
            {
                name = txtname.Text.ToString();
                dongia = float.Parse(txtDongia.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào sai !");
                return;
            }


            if (Sanpham_DAO.Instance.insert(name, 0, dongia, ""))
            {
                MessageBox.Show("Thêm thành công ! ");
                txtname.Text = "";
                txtDongia.Text = "";

                loadmn();
            }
        }
    }
}
