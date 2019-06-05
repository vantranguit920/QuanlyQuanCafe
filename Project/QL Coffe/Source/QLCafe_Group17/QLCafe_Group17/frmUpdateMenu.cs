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
    public partial class frmUpdateMenu : Form
    {
        int id;
        public delegate void load();
        public event load loadmn;
        public frmUpdateMenu(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Sanpham_DAO.Instance.update(id, float.Parse(textBox1.Text)))
            {
                MessageBox.Show("Thành công");
                loadmn();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dữ liệu giá không hợp lệ ");
            }
        }

        private void frmUpdateMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
