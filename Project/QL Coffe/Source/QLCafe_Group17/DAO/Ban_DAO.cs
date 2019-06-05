using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class Ban_DAO
    {
        private static Ban_DAO instance;

        public static Ban_DAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Ban_DAO();
                }
                return Ban_DAO.instance;

            } 
            set => instance = value;
        }
        private Ban_DAO() { }
        public DataTable getalltable(string kv)
        {
            return DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Ban WHERE Khuvuc = N'" + kv + " '");
        }


        public DataTable getalltable()
        {
            return DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Ban ");
        }



        public bool insertTable(string name, string kv, int stt)
        {
            
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_insertBan @Name , @Khuvuc , @Stt ",new object[] {name,kv,stt }) > 0;
           
        }
        public bool deleteTable(int id)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_deleteban @ID ",new object[] { id}) > 0;
        }
        public bool updateTable(int id,int stt)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_updatestt @ID , @Stt ",new object[] {id,stt }) > 0;
        }

        public List<Ban_DTO> listTable(string kv)
        {
            List<Ban_DTO> list = new List<Ban_DTO>();
            DataTable data = DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Ban WHERE Khuvuc = N'" + kv + " '");
            foreach(DataRow row in data.Rows)
            {
                Ban_DTO table = new Ban_DTO(row);
                list.Add(table);
            }
            return list;
        }




        public List<Ban_DTO> listTable()
        {
            List<Ban_DTO> list = new List<Ban_DTO>();
            DataTable data = DBConect_DAO.Instrance.ExecuteQuery("SELECT * FROM dbo.Ban");
            foreach (DataRow row in data.Rows)
            {
                Ban_DTO table = new Ban_DTO(row);
                list.Add(table);
            }
            return list;
        }
    }
}
