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
    public partial class frmQLmenu : Form
    {
        List<SanPham_DTO> list = new List<SanPham_DTO>();
        public frmQLmenu()
        {
            InitializeComponent();
            load();
        }




        public void load()
        {
            list.Clear();
            flMenu.Controls.Clear();
            list = Sanpham_DAO.Instance.getlist();
            foreach(SanPham_DTO sp in list)
            {
                UCMenuII uC = new UCMenuII();
                uC.Id = sp.Id;
                uC.Name1 = sp.Name;
                uC.Gia = sp.Dongia;
                uC.laodinfo();
                uC.loadmn += load;
                flMenu.Controls.Add(uC);
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddmenu frm = new frmAddmenu();
            frm.loadmn += load;
            
           
            frm.ShowDialog();
        }
    }


    
}
