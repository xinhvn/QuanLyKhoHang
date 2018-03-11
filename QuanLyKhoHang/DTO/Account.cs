using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DTO
{
    public class Account
    {
        public Account(string idLogin, string TenHienThi, int LoaiTK, string Pass = null)
        {
            this.idlogin = idLogin;
            this.tenhienthi = TenHienThi;
            this.loaitk = LoaiTK;
            this.pass = Pass;
        }

        public Account(DataRow row)
        {
            this.idlogin = row["idLogin"].ToString();
            this.tenhienthi = row["TenHienThi"].ToString();
            this.loaitk = (int)row["LoaiTK"];
            this.pass = row["Pass"].ToString();
        }

        private int LoaiTK;
        public int loaitk
        {
            get { return LoaiTK; }
            set { LoaiTK = value; }
        }

        private string Pass;
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        private string TenHienThi;
        public string tenhienthi
        {
            get { return TenHienThi; }
            set { TenHienThi = value; }
        }

        private string idLogin;
        public string idlogin
        {
            get { return idLogin; }
            set { idLogin = value; }
        }

        
    }
}
