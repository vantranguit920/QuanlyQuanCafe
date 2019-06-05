using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCafe_Group17
{
    public partial class UCSpDG : UserControl
    {
        string name;
        int sl;
        int idsp;
        public  delegate void deletesp(int id);
        public event deletesp delete;
        public UCSpDG()
        {
            InitializeComponent();
        }
        public void loadinfo()
        {
            lblname.Text = Name1;
            lblSL.Text = sl.ToString();
        }
        public string Name1 { get => name; set => name = value; }
        public int Sl { get => sl; set => sl = value; }
        public int Idsp { get => idsp; set => idsp = value; }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            delete(Idsp);
        }

        private void lblSL_Click(object sender, EventArgs e)
        {

        }
    }
}
