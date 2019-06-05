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
    public partial class UCBanII : UserControl
    {
        int id;
        string name;
        string kv;
        bool stt;
        public delegate void load(int kv);
        public event load loadkv;
        public UCBanII()
        {
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public string Kv { get => kv; set => kv = value; }
        public bool Stt { get => stt; set => stt = value; }

        public void loadinfo()
        {
            lblname.Text = name;
        }
        private void UCBanII_Load(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (stt == false)
            {
                MessageBox.Show("Ban dang co khach");
                return;
            }
            try
            {
                ThongKe_DAO.Instance.delete(id);

            }catch
            {
                
            }
            if (Ban_DAO.Instance.deleteTable(id))
            {
                MessageBox.Show("Xoa thanh cong!");
                loadkv(int.Parse(kv));
            }
        }
    }
}
