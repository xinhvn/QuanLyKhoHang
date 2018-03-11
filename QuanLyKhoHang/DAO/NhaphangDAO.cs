using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAO
{
    public class NhaphangDAO
    {
        private static NhaphangDAO instance;
        public static NhaphangDAO Instance
        {
            get {if(instance == null) instance = new NhaphangDAO(); return NhaphangDAO.instance;}
            private set { NhaphangDAO.instance = value; }
        }
        private NhaphangDAO() { }

        public List<Nhaphang> GetListNhaphang()
        {
            List<Nhaphang> list = new List<Nhaphang>();
            string query = "SELECT * FROM PhieuNhap";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Nhaphang nhaphang = new Nhaphang(item);
                list.Add(nhaphang);

            }
            return list;

        }


        public List<Nhaphang> SearchNhaphangByName(string Tenhang)
        {
            List<Nhaphang> list = new List<Nhaphang>();
            string query = string.Format("SELECT * FROM PhieuNhap WHERE Tenhang like N'%{0}%'", Tenhang);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Nhaphang nhaphang = new Nhaphang(item);
                list.Add(nhaphang);

            }
            return list;
        }



        public bool InsertNhaphang(string Idphieun, string Idhang, string Idncc, string Tenhang, string Dvt, String Luongnhap, string Gianhap, string ThanhTien)
        {
            string query = string.Format("INSERT INTO PhieuNhap (Idphieun, Idhang, Idncc, Tenhang, Dvt, Luongnhap, Gianhap, ThanhTien) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})", Idphieun, Idhang, Idncc, Tenhang, Dvt, Luongnhap, Gianhap, ThanhTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        //public bool UpdateNCC(string Idncc, string Tenncc, string Diachi, string Sdt)
        //{
        //    string query = string.Format("UPDATE NCC SET Tenncc ='{0}', Diachi = '{1}', Sdt = {2} WHERE Idncc ='{3}' ",Tenncc, Diachi, Sdt, Idncc);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}

        public bool DeleteNhaphang(string Idphieun)
        {
            string query = string.Format("DELETE PhieuNhap WHERE Idphieun = {0} ", Idphieun);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
