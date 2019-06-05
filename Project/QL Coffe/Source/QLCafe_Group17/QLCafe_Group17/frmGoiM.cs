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
    public partial class frmGoiM : Form
    {
        public delegate void change(bool stt);
        public event change changestt;
        List<SanPham_DTO> listMenu= new List<SanPham_DTO>();


        List<CTHD_DTO> listCT = new List<CTHD_DTO>();
        List<SanPhamGoi_DTO> listSP = new List<SanPhamGoi_DTO>();


        List<SanPhamGoi_DTO> listdg = new List<SanPhamGoi_DTO>();
        List<SanPhamGoi_DTO> listSPTong = new List<SanPhamGoi_DTO>();

        List<CTHD_DTO> listHD = new List<CTHD_DTO>();


        
        int idban;
        int idkv;
        public frmGoiM(int maban,int makhv)
        {
            idban = maban;
            idkv = makhv;
            InitializeComponent();
            load();
        }



        public void AddSP(int idsp,int sl,string name)
        {
            bool flag = true;
            int index=0;
            foreach(SanPhamGoi_DTO spg in listSPTong)
            {
                if(idsp == spg.Id)
                {
                    index = listSPTong.IndexOf(spg);
                    flag = false;
                }
            }

            if (flag)
            {
                SanPhamGoi_DTO sp = new SanPhamGoi_DTO(idsp,idban,sl,name);
                //listSP.Add(sp);
                listSPTong.Add(sp);
            }
            else
            {
                listSPTong[index].Sl = sl;
                
            }

            fldagoi.Controls.Clear();
            foreach (SanPhamGoi_DTO spdg in listSPTong)
            {
                UCSpDG uCSp = new UCSpDG();
                uCSp.Name1 = spdg.Name;
                uCSp.Sl = spdg.Sl;
                uCSp.Idsp = spdg.Id;
                uCSp.delete += xoasp;
                uCSp.loadinfo();
                fldagoi.Controls.Add(uCSp);
            }






        }









        void load()
        {
            flMenu.Controls.Clear();
            listMenu.Clear();
            listMenu = Sanpham_DAO.Instance.getlist();
            foreach(SanPham_DTO sp in listMenu)
            {
                UCMenu uCMenu = new UCMenu();
                uCMenu.Name1 = sp.Name;
                uCMenu.Price = sp.Dongia;
                uCMenu.Sl = sp.Sl;
                uCMenu.Idban = idban;
                uCMenu.Id = sp.Id;
                uCMenu.addsp += AddSP;
                uCMenu.loadinfo();
                flMenu.Controls.Add(uCMenu);
            }

            listCT = CTHD_DAO.Instance.getbyid(idban);
            foreach(CTHD_DTO hd in listCT)
            {
                SanPhamGoi_DTO sp = new SanPhamGoi_DTO(hd.IdSP,idban,hd.SL1,hd.Name);
                listdg.Add(sp);
            }
            

            foreach(SanPhamGoi_DTO spdg in listdg)
            {
                UCSpDG uCSp = new UCSpDG();
                uCSp.Name1 = spdg.Name;
                uCSp.Sl = spdg.Sl;
                uCSp.Idsp = spdg.Id;
                uCSp.delete += xoasp;
                uCSp.loadinfo();
                fldagoi.Controls.Add(uCSp);

                listSPTong.Add(spdg);
            }

        }

        void xoasp(int idsp)
        {
            int index=-1;
            foreach (SanPhamGoi_DTO spdg in listSPTong)
            {

                if (spdg.Id == idsp)
                {
                    index = listSPTong.IndexOf(spdg);
                }
            }
            if (index != -1)
            {
                listSPTong.RemoveAt(index);

                CTHD_DAO.Instance.deleteCTHD(idban,idsp);

                fldagoi.Controls.Clear();

                foreach (SanPhamGoi_DTO spdg in listSPTong)
                {
                    UCSpDG uCSp = new UCSpDG();
                    uCSp.Name1 = spdg.Name;
                    uCSp.Sl = spdg.Sl;
                    uCSp.Idsp = spdg.Id;
                    uCSp.delete += xoasp;
                    uCSp.loadinfo();
                    fldagoi.Controls.Add(uCSp);
                }



                if (listdg.Count == 0)
                {
                    HoaDon_DAO.Instance.deleteHD(idban);
                    Ban_DAO.Instance.updateTable(idban,0);
                    changestt(true);
                }
            }

        }




        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listdg.Count == 0 && listSPTong.Count>0)
            {
                if (HoaDon_DAO.Instance.insertHD(idban, 1))
                {
                    foreach (SanPhamGoi_DTO sp in listSPTong)
                    {
                        CTHD_DAO.Instance.insertCTHD(sp.IdBan, sp.Id, sp.Sl);
                    }
                    MessageBox.Show("OK !");
                }
            }
            else
            {
                foreach(SanPhamGoi_DTO sp in listSPTong)
                {
                    bool flag = true;
                    foreach(SanPhamGoi_DTO spg in listdg)
                    {
                        if (sp.Id == spg.Id)
                        {
                            CTHD_DAO.Instance.update(idban,sp.Id,sp.Sl);
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        CTHD_DAO.Instance.insertCTHD(idban, sp.Id, sp.Sl);
                    }
                }
                MessageBox.Show("OK !");
            }




            foreach (SanPhamGoi_DTO sp in listSPTong)
            {
                if(idban == sp.IdBan)
                {
                    changestt(false);
                    Ban_DAO.Instance.updateTable(idban, 1);

                }
            }


            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void flMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fldagoi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
