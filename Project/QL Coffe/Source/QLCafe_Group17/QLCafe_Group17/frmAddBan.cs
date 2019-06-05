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
    public partial class frmAddBan : Form
    {
        public delegate void loadtable(int kv);
        public event loadtable load;
        public frmAddBan()
        {
            InitializeComponent();
        }

        private void frmAddBan_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Ban_DAO.Instance.insertTable(txtName.Text, cbbkv.SelectedItem.ToString(), 0))
            {
                MessageBox.Show("OK");
                this.Close();
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void frmAddBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load(int.Parse(cbbkv.SelectedItem.ToString()));
            }
            catch { }
           
        }
    }
}
