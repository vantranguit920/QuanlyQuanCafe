using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class Ban_DTO
    {
        int id;
        string kv;
        string name;
        bool stt;
        List<SanPhamGoi_DTO> listsp;
        public Ban_DTO(int Id, string Name, bool Stt)
        {
            this.id = Id;
            this.name = Name;
            this.stt = Stt;
            
        }
        public Ban_DTO(DataRow data)
        {
            this.id = int.Parse(data["ID"].ToString());
            this.Kv = data["Khuvuc"].ToString();
            this.name = data["Name"].ToString();
            if(int.Parse(data["STT"].ToString())==0)
            {
                this.stt = true;
            }
            else
            {
                this.stt = false;
            }


        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Stt { get => stt; set => stt = value; }
        public string Kv { get => kv; set => kv = value; }
    }
}
