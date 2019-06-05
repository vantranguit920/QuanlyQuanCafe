using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class Sanpham_DAO
    {
        private static Sanpham_DAO instance;

        public static Sanpham_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sanpham_DAO();
                return instance;
            }

            set
            {
                Sanpham_DAO.instance = value;
            }
        }
        private Sanpham_DAO() { }
        public bool insert(string name,int sl,float dongia,string img)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery(" EXEC dbo.usp_insertMenu @Name , @Sl , @Dongia , @Img  ",new object[] {name,sl,dongia,img }) >0;
        }
        public bool delete(int id)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_deleteMenu @ID ",new object[] {id }) > 0;
        }
        public bool update(int id,float sl)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_updateMenu @ID , @Dongia ", new object[] { id , sl}) > 0;
        }
        public List<SanPham_DTO> getlist()
        {
            List<SanPham_DTO> list = new List<SanPham_DTO>();
            string query = "SELECT * FROM dbo.Menu";
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery(query);
            foreach(DataRow row in tb.Rows)
            {
                list.Add(new SanPham_DTO(row));
            }
            return list;
        }
    }
}
