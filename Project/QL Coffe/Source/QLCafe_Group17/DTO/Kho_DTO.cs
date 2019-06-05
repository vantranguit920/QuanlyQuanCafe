using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Kho_DTO
    {
        int id;
        string name;
        int sl;
        float dongia;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Sl { get => sl; set => sl = value; }
        public float Dongia { get => dongia; set => dongia = value; }

        public Kho_DTO(DataRow row)
        {
            Id = int.Parse(row["ID"].ToString());
            name = row["NAME"].ToString();
            Sl = int.Parse(row["SOL"].ToString());
            Dongia = float.Parse(row["DONGIA"].ToString());
        }
    }
}
