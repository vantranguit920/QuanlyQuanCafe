using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Thongke_DTO
    {
        float money;

        public float Money { get => money; set => money = value; }


        //public NhanSu_DTO(DataRow data)
        //{
        //    this.id = int.Parse(data["ID"].ToString());
        //    this.name = data["Name"].ToString();
        //    this.Img = data["img"].ToString();
        //    this.phone = data["Phone"].ToString();
        //    this.idcard = data["IDcard"].ToString();
        //    this.chucvu = data["Chucvu"].ToString();
        //}



        public Thongke_DTO(DataRow dt)
        {
            this.money = float.Parse(dt["Tổng Tiền"].ToString());
        }

    }
}
