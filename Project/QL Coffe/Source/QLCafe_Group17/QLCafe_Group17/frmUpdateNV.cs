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
    
    public partial class frmUpdateNV : Form
    {
        int id;
        string name;
        string phone;
        string idcard;
        string chucvu;

        public delegate void update();
        public event update updatenv;

        public frmUpdateNV(int id, string name,string phone,string idcard,string chucvu)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.idcard = idcard;
            this.chucvu = chucvu;
            load();
        }
       
        void load()
        {
            txtName.Text = name;
            txtPhone.Text = phone;
            txtIdcard.Text = idcard;
            comboBox1.Text = chucvu;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Nhansu_DAO.Instance.updateNV(id, txtName.Text, txtIdcard.Text, txtPhone.Text, comboBox1.Text))
            {
                MessageBox.Show("Thành công !");
                updatenv();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Thất bại!  Có thể các dữ liệu nhập vào không hợp lệ !");
            }
            
        }
    }
}
