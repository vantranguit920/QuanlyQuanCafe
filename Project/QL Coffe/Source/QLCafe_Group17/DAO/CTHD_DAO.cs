using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class CTHD_DAO
    {
        private static CTHD_DAO instance;

        public static CTHD_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CTHD_DAO();
                }
                return CTHD_DAO.instance;

            }
            set => instance = value;
        }
        private CTHD_DAO() { }

        public bool ThanhToan(int idban)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_ThanhToan @IDban ", new object[] { idban }) > 0;

        }
        public List<CTHD_DTO> getbyid(int idban)
        {
            List<CTHD_DTO> list = new List<CTHD_DTO>();
            DataTable dt = DBConect_DAO.Instrance.ExecuteQuery("EXEC dbo.usp_getCTHDII @MABAN ",new object[] { idban });
            foreach(DataRow r in dt.Rows)
            {
                CTHD_DTO cthd = new CTHD_DTO(r);
                list.Add(cthd);
            }
            return list;

        }
        public DataTable getHDTT(int idban)
        {
            return DBConect_DAO.Instrance.ExecuteQuery("EXEC dbo.usp_getHDTT @Idban ",new object[] { idban });
        }
        public bool deleteCTHD(int idban,int idsp)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_deleteCTHD @IDBan , @IDSP  ", new object[] { idban,idsp }) > 0;
        }
        public bool update(int idban,int idsp,int sl)
        {

            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_updateCTHD @Maban , @Masp , @Sl  ", new object[] { idban, idsp, sl }) > 0;
        }
        public bool insertCTHD(int maban,int masp,int sl)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.insertCTHDbyID @IDBAN , @MASP , @SL  ", new object[] { maban, masp,sl }) > 0;
        }
        public List<CTHD_DTO> getlist(int idhd)
        {
            List<CTHD_DTO> list = new List<CTHD_DTO>();
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.CTHoaDon WHERE MAHD = " + idhd.ToString());

            foreach (DataRow r in tb.Rows)
            {
                CTHD_DTO hd = new CTHD_DTO(r);
                list.Add(hd);
            }


            return list;

        }
    }
}
