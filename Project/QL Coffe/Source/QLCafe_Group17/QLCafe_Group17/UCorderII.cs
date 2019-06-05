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
    public partial class UCorderII : UserControl
    {
        public string name;
        public int sl;
        public UCorderII()
        {
            InitializeComponent();
    
        }
        public void load()
        {
            txtName.Text = name;
            txtsl.Text = sl.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
