using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class SanPham_DTO
    {
        int id;
        string name;
        int sl;
        string image;
        float dongia;
        public SanPham_DTO(int iD,string nAme,int sL,string iMage,float Dg)
        {
            Id = iD;
            Name = nAme;
            Sl = sL;
            Image = iMage;
            Dongia = Dg;

        }
        public SanPham_DTO(DataRow data)
        {
            Id =  int.Parse(data["ID"].ToString());
            Name = data["Name"].ToString();
            Sl =  int.Parse(data["SL"].ToString());
            Image = data["ImageM"].ToString();
            Dongia = float.Parse(data["Dongia"].ToString());
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Sl { get => sl; set => sl = value; }
        public string Image { get => image; set => image = value; }
        public float Dongia { get => dongia; set => dongia = value; }
    }
}
