using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDon_DTO
    {
        int ID;
        int IDBan;
        int IDNV;
        public HoaDon_DTO(DataRow data)
        {
            this.ID1 = int.Parse(data["MAHD"].ToString());
            this.IDBan1 = int.Parse(data["MABAN"].ToString());
            this.IDNV1 = int.Parse(data["MANV"].ToString());
        }

        public int ID1 { get => ID; set => ID = value; }
        public int IDBan1 { get => IDBan; set => IDBan = value; }
        public int IDNV1 { get => IDNV; set => IDNV = value; }
    }
}
