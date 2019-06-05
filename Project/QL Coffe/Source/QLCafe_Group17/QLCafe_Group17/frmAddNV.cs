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
    public partial class frmAddNV : Form
    {
        public delegate void loadnv();
        public event loadnv loadnvform;
        bool iscreatus=true;
        public frmAddNV()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            string us = txtuser.Text;
            string mk = txtmk.Text;
            string type = txtIdcard.Text;

            if (us == string.Empty||mk==string.Empty||type==string.Empty||txtName.Text.ToString()==string.Empty||txtPhone.Text.ToString()==string.Empty)
            {
                MessageBox.Show("Hãy điền đầy đủ các thông tin !");
                return;
            }

            if (Nhansu_DAO.Instance.insertP(txtName.Text, txtIdcard.Text, txtPhone.Text, cbbCV.SelectedItem.ToString(), "No img")) 
            {
                if (iscreatus)
                {
                    if (Login_DAO.Instance.CreateAccout(us, mk, type))
                    {
                        MessageBox.Show("Thêm thành công !");
                        this.Close();
                        loadnvform();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại ! các dữ liệu nhập vào không hợp lệ! ");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thành công !");
                    this.Close();
                    loadnvform();
                }
               



            }


            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCV.Text == "Tạp Vụ")
            {
                txtuser.Visible = false;
                txtmk.Visible = false;
                lblus.Visible = false;
                lblmk.Visible = false;
                iscreatus = false;
            }
            else
            {
                txtuser.Visible = true;
                txtmk.Visible = true;
                lblus.Visible = true;
                lblmk.Visible = true;
                iscreatus = true;
            }
        }
    }
}
