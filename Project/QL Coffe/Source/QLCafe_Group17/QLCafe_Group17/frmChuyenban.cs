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
    public partial class frmChuyenban : Form
    {
        public delegate void change(bool stt);
        public event change changestt;

        public delegate void loadban();
        public event loadban loadstt;



        List<Ban_DTO> list = new List<Ban_DTO>();
        int id1;
        public frmChuyenban(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list.Clear();
            string id = cbbkv.SelectedItem.ToString();

            list = Ban_DAO.Instance.listTable(id);
            cbbban.Text = string.Empty;
            cbbban.DataSource = list;
            cbbban.DisplayMember = "Name";




        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (cbbban.SelectedItem as Ban_DTO).Id;
                bool stt = (cbbban.SelectedItem as Ban_DTO).Stt;

                if (stt == true)
                {
                    if (HoaDon_DAO.Instance.chuyenban(id1, id))
                    {
                        changestt(true);
                        Ban_DAO.Instance.updateTable(id1, 0);
                        Ban_DAO.Instance.updateTable(id, 1);
                        loadstt();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ban ban muon chuyen toi dang co khach");
                }
                
            }
            catch
            {

            }
           


            
            

        }
    }
}
