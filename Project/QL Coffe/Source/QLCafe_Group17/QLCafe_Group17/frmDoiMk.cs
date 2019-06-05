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
    public partial class frmDoiMk : Form
    {
        string us;
        string pas;
        string pasi;
        public frmDoiMk(string user)
        {
            InitializeComponent();
            us = user;

        }

        private void frmDoiMk_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            
            pas = txt_matkhau.Text.Trim();
            pasi = txtMk2.Text.Trim();
                    
            if (pas == string.Empty||pasi == string.Empty)
            {
                MessageBox.Show("Insert PassWord");
            }
            else if(!pas.Equals(pasi))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");

            }
            else
            {
                if(Login_DAO.Instance.Changepass(us, pas))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }

            }

        }
    }
}
