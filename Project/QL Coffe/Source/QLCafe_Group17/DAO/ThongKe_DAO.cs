using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class ThongKe_DAO
    {
        private static ThongKe_DAO instance;

        public static ThongKe_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKe_DAO();
                }
                return ThongKe_DAO.instance;

            }
            set => instance = value;
        }
        private ThongKe_DAO() { }
        public bool insert(int idban, float tongtien)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_insertBaoCao @IDBan , @Tongtien ", new object[] { idban, tongtien}) > 0;
        }




        public bool delete(int idban)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_deleteBaoCao @IDban ", new object[] { idban}) > 0;
        }
        public DataTable GetBaoCao(DateTime dt1, DateTime dt2)
        {

            return DBConect_DAO.Instrance.ExecuteQuery("EXEC dbo.usp_GetBaoCaoIII @Start , @End  ", new object[] { dt1 , dt2 });

        }


        public List<Thongke_DTO> getlist(DateTime dt1, DateTime dt2)
        {
            List<Thongke_DTO> list = new List<Thongke_DTO>();
            DataTable dt = DBConect_DAO.Instrance.ExecuteQuery("EXEC dbo.usp_GetBaoCaoIII @Start , @End  ", new object[] { dt1, dt2 });
            foreach(DataRow r in dt.Rows)
            {
                Thongke_DTO tk = new Thongke_DTO(r);
                list.Add(tk);
            }
            return list;
        }



    }
}
