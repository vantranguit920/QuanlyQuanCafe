using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class NhanSu_DTO
    {
        int id;
        string name;
        string img;
        string phone;
        string idcard;
        string chucvu;
        public NhanSu_DTO(int iD,string naMe,string im,string pHone,string iDcard,string cHucvu)
        {
            this.id = iD;
            this.name = naMe;
            this.img = im;
            this.phone = pHone;
            this.idcard = iDcard;
            this.chucvu = cHucvu;

        }
        public NhanSu_DTO(DataRow data)
        {
            this.id = int.Parse(data["ID"].ToString());
            this.name = data["Name"].ToString();
            this.Img = data["img"].ToString();
            this.phone = data["Phone"].ToString();
            this.idcard = data["IDcard"].ToString();
            this.chucvu = data["Chucvu"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
      
        public string Phone { get => phone; set => phone = value; }
        public string Idcard { get => idcard; set => idcard = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Img { get => img; set => img = value; }
    }
}
