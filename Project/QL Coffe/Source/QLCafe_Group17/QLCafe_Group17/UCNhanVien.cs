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

namespace QLCafe_Group17
{
    
    public partial class UCNhanVien : UserControl
    {
        private string name1;
        private string phone;
        private string idcard;
        private int id;
        private string dc;
        string img;
        public delegate void load();
        public event load loadnv;

        public string Name1 { get => name1; set => name1 = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Idcard { get => idcard; set => idcard = value; }
        public int Id { get => id; set => id = value; }
        public string Dc { get => dc; set => dc = value; }
        public string Img { get => img; set => img = value; }

        public UCNhanVien()
        {
            InitializeComponent();
        }
        public void loadInfo()
        {
            txtName.Text = Name1;
            txtAdress.Text = Dc;
            txtIdcard.Text = Idcard;
            txtphone.Text = Phone;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            frmUpdateNV frm = new frmUpdateNV(id,name1,phone,idcard,dc);
            frm.updatenv += loadnvdelegate;
            frm.ShowDialog();
        }
        public void loadnvdelegate()
        {
            loadnv();
        }
        private void btnDele_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Nhan vien nayf se xoa khoi he thong!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (Nhansu_DAO.Instance.deleteNV(id))
                {
                    MessageBox.Show("OK");
                    loadnv();
                    
                }
            }
        }
    }
}
