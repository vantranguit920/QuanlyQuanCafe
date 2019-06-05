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
    public partial class frmNhansu : Form
    {
        List<NhanSu_DTO> list = new List<NhanSu_DTO>();
        public frmNhansu()
        {
            InitializeComponent();
            load();
            




        }
        void load()
        {
            flNhansu.Controls.Clear();
            list.Clear();
            list = Nhansu_DAO.Instance.getList();
            foreach(NhanSu_DTO ns in list)
            {
                UCNhanVien uCNhan = new UCNhanVien();
                uCNhan.Name1 = ns.Name;
                uCNhan.Phone = ns.Phone;
                uCNhan.Id = ns.Id;
                uCNhan.Idcard = ns.Idcard;
                uCNhan.Dc = ns.Chucvu;
                uCNhan.loadnv += load;
               
                uCNhan.loadInfo();
                flNhansu.Controls.Add(uCNhan);
            }
        }

        //private void btnrefes_Click(object sender, EventArgs e)
        //{
        //    load();
        //}

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmAddNV frmAddNV = new frmAddNV();
            frmAddNV.loadnvform += load;
            frmAddNV.ShowDialog();
        }
    }
}
