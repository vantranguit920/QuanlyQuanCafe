using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QLCafe_Group17
{
    public partial class UCMenuII : UserControl
    {
        int id;
        string name;
        float gia;
        public delegate void load();
        public event load loadmn;
        public UCMenuII()
        {
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public float Gia { get => gia; set => gia = value; }


        public void laodinfo()
        {
            lblname.Text = "Name:  " + Name1;
            lblgia.Text = "Gia:   " + Gia.ToString() + "   VND";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Sanpham_DAO.Instance.delete(Id))
            {
                MessageBox.Show("Xóa thành công !");
                loadmn();
            }
        }
        public void loadmenu()
        {
            loadmn();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            frmUpdateMenu frm = new frmUpdateMenu(Id);
            frm.loadmn += loadmenu;
            frm.ShowDialog();
        }
    }
}
