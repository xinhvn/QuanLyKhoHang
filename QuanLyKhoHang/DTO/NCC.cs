using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DTO
{
    public class NCC
    {
        public NCC(string Idncc, string Tenncc, string Diachi, string Sdt)
        {
            this.idncc = Idncc;
            this.tenncc = Tenncc;
            this.diachi = Diachi;
            this.sdt = Sdt;
        }

        public NCC(DataRow row)
        {
            this.idncc = row["Idncc"].ToString();
            this.tenncc = row["Tenncc"].ToString();
            this.diachi = row["Diachi"].ToString();
            this.sdt = row["Sdt"].ToString();
        
        }


        private string Idncc;
        public string idncc
        {
            get { return Idncc; }
            set { Idncc = value; }
        }

        private string Tenncc;
        public string tenncc
        {
            get { return Tenncc; }
            set { Tenncc = value; }
        }

        private string Diachi;
        public string diachi
        {
            get { return Diachi; }
            set { Diachi = value; }
        }

        private string Sdt;
        public string sdt
        {
            get { return Sdt; }
            set { Sdt = value; }
        }

        
    }
}
