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
    public partial class UCMenu : UserControl
    {
        int id;
        int sl;
        string image;
        string name;
        float price;
        int idban;


        public delegate void add(int id, int sl,string name);
        public event add addsp;
        public UCMenu()
        {
            InitializeComponent();
        }
        public void loadinfo()
        {
            lblname.Text = name+" : ";
            lblprice.Text = price.ToString() + "  VND";
            int limit = 0;
            if (sl > 20)
            {
                limit = 20;

            }
            else
            {
                limit = sl;
            }
            for(int i = 1; i < limit; i++)
            {
                cbbSL.Items.Add(i);
            }
        }
        public int Id { get => id; set => id = value; }
        public int Sl { get => sl; set => sl = value; }
        public string Image { get => image; set => image = value; }
        public string Name1 { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Idban { get => idban; set => idban = value; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbSL_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int x = int.Parse(cbbSL.SelectedItem.ToString());

                addsp(Id,x,name);



                //bool flag = false;
                //for(int i =0; i < frmQL.listspg.Count; i++)
                //{
                //    if(frmQL.listspg[i].IdBan == Idban && frmQL.listspg[i].Id == Id)
                //    {
                //        frmQL.listspg[i].Sl = x;
                //        flag = true;
                //    }
                //}
                //if (!flag)
                //{
                //    SanPhamGoi_DTO sp = new SanPhamGoi_DTO(Id, Idban, x, Name1);
                //    frmQL.listspg.Add(sp);
                //}
                

          
        }
    }
}
