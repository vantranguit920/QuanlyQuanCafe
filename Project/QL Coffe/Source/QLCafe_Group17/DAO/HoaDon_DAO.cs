using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class HoaDon_DAO
    {
        private static HoaDon_DAO instance;

        public static HoaDon_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDon_DAO();
                }
                return HoaDon_DAO.instance;

            }
            set => instance = value;
        }
        private HoaDon_DAO() { }

        public HoaDon_DTO getHD(int idban)
        {
            HoaDon_DTO hd = null;
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery(" EXEC dbo.usp_getHD @MABAN ", new object[] { idban });
            foreach(DataRow r in tb.Rows)
            {
                hd = new HoaDon_DTO(r);
                return hd;
            }


            return hd;
        }
        public List<HoaDon_DTO> getlist()
        {
            List<HoaDon_DTO> list = new List<HoaDon_DTO>();
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery(" SELECT * FROM dbo.HoaDon WHERE STT = 0 ");
            foreach (DataRow r in tb.Rows)
            {
                HoaDon_DTO hd = new HoaDon_DTO(r);
                list.Add(hd);
            }


            return list;
        }
        public bool insertHD(int maban,int manv)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_InsertHDII @MABAN , @MANV ", new object[] { maban,manv}) > 0;
        }


        public bool deleteHD(int idban)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_deleteHD @Maban ", new object[] { idban }) > 0;
        }



        public bool update(int idhd,int stt)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_updateHD @STT , @ID ", new object[] { stt ,idhd }) > 0;
        }



        public bool chuyenban(int id1,int id2)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_chuyenban @idban1 , @idban2 ", new object[] { id1, id2 }) > 0;
        }
    }
}
