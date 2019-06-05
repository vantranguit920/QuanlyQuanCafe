using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class Kho_DAO
    {
        private static Kho_DAO instance;

        public static Kho_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Kho_DAO();
                }
                return Kho_DAO.instance;

            }
            set => instance = value;
        }
        private Kho_DAO() { }


        public DataTable getKho()
        {
            return DBConect_DAO.Instrance.ExecuteQuery("SELECT k.NAME AS N'Tên Sản Phẩm', k.SOL AS N'Số Lượng',k.DONGIA AS N'Đơn Giá' FROM dbo.Kho k");
        }
        public bool UpdateMenu(int id,int sl)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_updateSLmenu @ID , @SL ", new object[] { id, sl }) > 0;
        }
        public bool NhapKho(int id,int sl,float dongia)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_NhapSP @ID , @SOL , @DONGIA ", new object[] { id,sl,dongia}) > 0;
        }
        public List<Kho_DTO> getList()
        {
            List<Kho_DTO> list = new List<Kho_DTO>();
            DataTable dt = DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Kho");
            foreach(DataRow r in dt.Rows)
            {
                Kho_DTO k = new Kho_DTO(r);
                list.Add(k);
            }
            return list;
        }


        public bool TKnhap(int idsp,string namesp, int sl,float dongia, string nguoinhap , string nhacc, float tongtien)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_TKnhapI @IDsp , @Namesp , @SOL , @DOGIA , @Nguoinhap , @Nhacungcap , @Tongtien ", new object[] { idsp, namesp, sl, dongia,  nguoinhap,  nhacc,  tongtien }) > 0;
        }

        public bool TKxuat(int idsp,string namesp,int sl,string nguoinhan,string nguoixuat)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_TKxuatkho @IDsp , @Namesp , @SOL , @Nguoinhan , @Nguoixuat ", new object[] { idsp,namesp,sl,nguoinhan,nguoixuat }) > 0;
        }

        public bool xuatkho(int id , int sl)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_xuatkho @ID , @SOL ", new object[] { id, sl }) > 0;
        }

        public DataTable TKnhapkho(DateTime dt1,DateTime dt2)
        {
            return DBConect_DAO.Instrance.ExecuteQuery("EXEC dbo.usp_getTKnhap @start , @end ", new object[] {dt1,dt2 });
        }


        public DataTable TKXuatkho(DateTime dt1, DateTime dt2)
        {
            return DBConect_DAO.Instrance.ExecuteQuery("EXEC dbo.usp_getTKxuat @start , @end ",new object[] {dt1,dt2 });
        }

        public int getID()
        {
            int id = 0;
            DataTable dt = DBConect_DAO.Instrance.ExecuteQuery("SELECT MAX(ID) AS N'ID' FROM dbo.Kho ");
            foreach(DataRow r in dt.Rows)
            {
                id = int.Parse(r["ID"].ToString());
            }


            return id;

        }

        public bool themspmoi(string name , int sl, float dongia)
        {
             return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.ThemSPMoi @IDMENU , @Name , @SOL , @DONGIA ", new object[] { 1 , name , sl, dongia }) > 0;


        }
        public bool xoasp(int id)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("DELETE dbo.Kho WHERE ID = " + id.ToString()) > 0;
        }
        public bool xuatmenu(int id,int sl)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC usp_xuatmenu @IDMENU , @SOL ", new object[] { id, sl }) > 0;
        }
    }
}
