using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class Login_DAO
    {

        private static Login_DAO instance;

        public static Login_DAO Instance {
            get
            {
                if (instance == null)
                    instance = new Login_DAO();
                return instance;
            }

            set
            {
                Login_DAO.instance = value;
            }
        }
        private Login_DAO() { }
        public bool Login(string user,string pass)
        {
            string query = "SELECT * FROM dbo.UserLog WHERE UserName=N'" + user + " ' AND Pass=N'" + pass + " '";
            DataTable result = DBConect_DAO.Instrance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public Login_DTO getaccout(string us,string pas)
        {
            string query = "SELECT * FROM dbo.UserLog WHERE UserName=N'" + us + " ' AND Pass=N'" + pas + " '";
            Login_DTO acc;
            DataTable tb = DBConect_DAO.Instrance.ExecuteQuery(query);
            
            acc = new Login_DTO(tb.Rows[0]);
            return acc;
           
        }
        public bool CreateAccout(string user, string pass, string type)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_AddUser @IDcart , @US , @MK ", new object[] { type, user, pass, }) > 0;
        }


        public bool Changepass(string user, string pass)
        {
            return DBConect_DAO.Instrance.ExecuteNonQuery("EXEC dbo.usp_changePass @us , @pass ", new object[] {user, pass, }) > 0;
        }
    }
}
