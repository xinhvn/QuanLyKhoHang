using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DTO
{
    public class Nhaphang
    {
         public Nhaphang(string Idphieun, string Idhang, string Idncc, string Tenhang, string Dvt, String Luongnhap, string Gianhap, string ThanhTien)
        {
            this.idphieun = Idphieun;
            this.idhang = Idhang;
            this.idncc = Idncc;
            this.tenhang = Tenhang;
            this.dvt = Dvt;
            this.luongnhap = Luongnhap;
            this.gianhap = Gianhap;
            this.thanhtien = ThanhTien;
        }

        public Nhaphang(DataRow row)
        {
            this.idphieun = row["Idphieun"].ToString();
            this.idhang = row["Idhang"].ToString();
            this.idncc = row["Idncc"].ToString();
            this.tenhang = row["Tenhang"].ToString();
            this.dvt = row["Dvt"].ToString();
            this.luongnhap = row["Luongnhap"].ToString();
            this.gianhap = row["Gianhap"].ToString();
            this.thanhtien = row["ThanhTien"].ToString();
        
        }


        private string Idphieun;
        public string idphieun
        {
            get { return Idphieun; }
            set { Idphieun = value; }
        }

        private string Idhang;
        public string idhang
        {
            get { return Idhang; }
            set { Idhang = value; }
        }

        private string Idncc;
        public string idncc
        {
            get { return Idncc; }
            set { Idncc = value; }
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

        private string Luongnhap;
        public string luongnhap
        {
            get { return Luongnhap; }
            set { Luongnhap = value; }
        }

        private string Gianhap;
        public string gianhap
        {
            get { return Gianhap; }
            set { Gianhap = value; }
        }

        private string ThanhTien;
        public string thanhtien
        {
            get { return ThanhTien; }
            set { ThanhTien = value; }
        }
    }
}
