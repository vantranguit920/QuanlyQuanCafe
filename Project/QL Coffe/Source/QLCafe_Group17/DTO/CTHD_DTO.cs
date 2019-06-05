using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class CTHD_DTO
    {
        int idHD;
        int idCTHD;
        int idSP;
        int SL;
        float dongia;
        string name;

        public CTHD_DTO(DataRow data)
        {
            this.IdCTHD = int.Parse(data["MACTHD"].ToString());
            this.IdHD = int.Parse(data["MAHD"].ToString());
            this.IdSP = int.Parse(data["MASP"].ToString());
            this.SL1 = int.Parse(data["SL"].ToString());
            this.name = data["Name"].ToString();
            this.Dongia = float.Parse(data["Dongia"].ToString());
        }

        public int IdHD { get => idHD; set => idHD = value; }
        public int IdCTHD { get => idCTHD; set => idCTHD = value; }
        public int IdSP { get => idSP; set => idSP = value; }
        public int SL1 { get => SL; set => SL = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public string Name { get => name; set => name = value; }
    }
}
