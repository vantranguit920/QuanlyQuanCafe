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
    public partial class frmOrder : Form
    {


        List<HoaDon_DTO> list;
        List<Ban_DTO> listban;
        string nameban;
        string kv;
        public frmOrder()
        {
            InitializeComponent();
            load();
        }

        void load()
        {

            listban = Ban_DAO.Instance.listTable();

            list = HoaDon_DAO.Instance.getlist();

            flOrder.Controls.Clear();

            foreach(HoaDon_DTO hd in list)
            {
                foreach (Ban_DTO ban in listban)
                {
                    if (ban.Id == hd.IDBan1)
                    {
                        nameban = ban.Name;
                        kv = ban.Kv;

                        
                    }

                }
                ULCOrder uc = new ULCOrder(hd.ID1,hd.IDBan1,nameban,kv);
                uc.loadfrm += load;
                flOrder.Controls.Add(uc);

                
            }

        }


  
    }
}
