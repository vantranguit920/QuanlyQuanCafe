using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace QLCafe_Group17
{
    public partial class UCtable : UserControl
    {
        int id;
        string name;
        bool status=true;
        public delegate void load();
        public event load loadstt;
        public UCtable()
        {
            InitializeComponent();
        }
       
        public int Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }



        public void loadban()
        {
            loadstt();
        }
        public void loadinfo()
        {
            lblBan.Text = Name1;
            if(Status == true)
            {
                pnstt.BackColor = Color.Blue;

            }
            else
            {
                pnstt.BackColor = Color.Red;
            }
        }
       
        public void changestatus(bool stt)
        {
            //this.status = stt;
            status = stt;
            if (stt == true)
            {
                pnstt.BackColor = Color.Blue;

            }
            else
            {
                pnstt.BackColor = Color.Red;
            }
            
            
        }
        
        private void btngoi_Click(object sender, EventArgs e)
        {
            frmGoiM frmGoi = new frmGoiM(id,5);
            frmGoi.changestt += changestatus;
            frmGoi.ShowDialog();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                frmThanhToan frm = new frmThanhToan(Id);
                frm.loadtable += changestatus;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bàn trống !");
            }
           
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (status==false)
            {
                frmChuyenban frm = new frmChuyenban(id);
                frm.changestt += changestatus;
                frm.loadstt += loadban;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bàn hiện đang trống!");
            }
           
        }
    }
}
