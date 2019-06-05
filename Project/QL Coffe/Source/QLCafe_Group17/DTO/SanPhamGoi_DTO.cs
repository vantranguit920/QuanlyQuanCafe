using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamGoi_DTO 
    {
        int id;
        int idBan;
        int sl;
        string name;
        public SanPhamGoi_DTO(int iD,int idb,int sL,string nAme)
        {
            Id = iD;
            Sl = sL;
            Name = nAme;
            IdBan = idb;

        }
        public int Id { get => id; set => id = value; }
        public int Sl { get => sl; set => sl = value; }
        public string Name { get => name; set => name = value; }
        public int IdBan { get => idBan; set => idBan = value; }
    }
}
