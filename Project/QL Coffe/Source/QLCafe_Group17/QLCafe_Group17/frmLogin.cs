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
namespace QLCafe_Group17
{
    public partial class frmLogin : Form
    {
        string us;
        string pas;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            us = txt_tendn.Text.Trim();
            pas = txt_matkhau.Text.Trim();

            if(us == string.Empty)
            {
                MessageBox.Show("Insert Username");
            }else if(pas == string.Empty)
            {
                MessageBox.Show("Insert PassWord");
            }
            else
            {
                if (Login_DAO.Instance.Login(us, pas))
                {
                    Login_DTO accout = Login_DAO.Instance.getaccout(us,pas);
                    
                    frmQL frmql = new frmQL(accout.TypeUse);
                    frmql.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Connect fail !!!");
                }
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            us = txt_tendn.Text.Trim();
            pas = txt_matkhau.Text.Trim();

            if(us == string.Empty)
            {
                MessageBox.Show("Insert Username");
            }else if(pas == string.Empty)
            {
                MessageBox.Show("Insert PassWord");
            }
            else
            {
                if (Login_DAO.Instance.Login(us, pas))
                {
                    frmDoiMk frm = new frmDoiMk(us);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Connect fail !!!");
                }
            }
        }

        private void grb_DangNhap_Enter(object sender, EventArgs e)
        {

        }

        private void txt_tendn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tendn_Click(object sender, EventArgs e)
        {

        }

        private void lbl_matkhau_Click(object sender, EventArgs e)
        {

        }
    }
}
