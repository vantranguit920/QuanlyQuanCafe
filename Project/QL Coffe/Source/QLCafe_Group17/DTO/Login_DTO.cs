using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Login_DTO
    {
        string username;
        string pass;
        int id, typeUse;
        public Login_DTO() { }
        public Login_DTO(string us,string pas,int id,int type)
        {

            Username = us;
            Pass = pas;
            Id = id;
            TypeUse = type;

        }
        public Login_DTO(DataRow data)
        {
            //Username = data["UserName"].ToString();
            //Pass = data["Pass"].ToString();
            //Id = int.Parse(data["ID"].ToString());
            TypeUse = int.Parse(data["TypeUser"].ToString()); 

        }

        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Id { get => id; set => id = value; }
        public int TypeUse { get => typeUse; set => typeUse = value; }
    }
}
