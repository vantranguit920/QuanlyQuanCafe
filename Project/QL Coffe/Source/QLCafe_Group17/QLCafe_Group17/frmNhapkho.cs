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
    public partial class frmNhapkho : Form
    {
        List<Kho_DTO> list = new List<Kho_DTO>();
        List<Kho_DTO> listnhap = new List<Kho_DTO>();
        public frmNhapkho()
        {
            InitializeComponent();
            load();
        }



        void load()
        {
            list = Kho_DAO.Instance.getList();
            cbbname.DataSource = list;
            cbbname.DisplayMember = "name";
        }

        private void cbbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kho_DTO k = cbbname.SelectedItem as Kho_DTO;
            //listnhap.Add(k);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Kho_DTO k = cbbname.SelectedItem as Kho_DTO;
            listnhap.Add(k);
            dtgkho.Controls.Clear();
            dtgkho.DataSource = listnhap;
        }
    }
}
