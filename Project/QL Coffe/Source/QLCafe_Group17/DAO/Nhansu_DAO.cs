using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class Nhansu_DAO
    {
        private static Nhansu_DAO instance;

        public static Nhansu_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Nhansu_DAO();
                return instance;
            }

            set
            {
                Nhansu_DAO.instance = value;
            }
        }
        private Nhansu_DAO() { }


        public bool insertP(string name, string idcard, string phone, string chucvu,string img)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_insertNV @Name , @Phone , @IDcard , @Chucvu , @img ",new object[] {name,phone,idcard,chucvu,img }) >0;
        }
        public bool deleteP()
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("") > 0;
        }

        public List<NhanSu_DTO> getList()
        {
            List<NhanSu_DTO> list = new List<NhanSu_DTO>();
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Nhanvien");
            foreach(DataRow row in tb.Rows)
            {
                list.Add(new NhanSu_DTO(row));
            }
            return list;
        }
        public bool updateNV(int id, string name,string idcard,string phone,string chucvu)
        {
            int n = DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_updateNV @ID , @Name , @Phone , @IDcard , @Chucvu ",new object[] {id,name,phone,idcard,chucvu });
            return n > 0;
        }
        public bool deleteNV(int id)
        {
            int n = DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_deleteNV @ID ", new object[] { id });
            return n > 0;
        }

        public NhanSu_DTO getnv(int id)
        {
            
            NhanSu_DTO nv;
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Nhanvien WHERE ID = "+ id.ToString());
            
            nv = new NhanSu_DTO(tb.Rows[0]);
            return nv;
           
          
        }




    }
}
