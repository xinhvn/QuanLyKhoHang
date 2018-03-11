using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DTO
{
    public class Hanghoa
    {
        public Hanghoa(string Idhang, string Tenhang, string Dvt , string SoLuong, string Gianhap, string Giaxuat)
        {
            this.idhang = Idhang;
            this.tenhang = Tenhang;
            this.dvt = Dvt;
            this.soluong = SoLuong;
            this.gianhap = Gianhap;
            this.giaxuat = Giaxuat;
        }

        public Hanghoa(DataRow row)
        {
            this.idhang = row["Idhang"].ToString();
            this.tenhang = row["Tenhang"].ToString();
            this.dvt = row["Dvt"].ToString();
            this.soluong = row["SoLuong"].ToString();
            this.gianhap = row["Gianhap"].ToString();
            this.gianhap = row["Giaxuat"].ToString();
        }

        private string Idhang;
        public string idhang
        {
            get { return Idhang; }
            set { Idhang = value; }
        }

        private string Tenhang;
        public string tenhang
        {
            get { return Tenhang; }
            set { Tenhang = value; }
        }

        private string Dvt;
        public string dvt
        {
            get { return Dvt; }
            set { Dvt = value; }
        }


        private string SoLuong;
        public string soluong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }


        private string Gianhap;
        public string gianhap
        {
            get { return Gianhap; }
            set { Gianhap = value; }
        }

        private string Giaxuat;
        public string giaxuat
        {
            get { return Giaxuat; }
            set { Giaxuat = value; }
        }



      

      

        
    }
}
