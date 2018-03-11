using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAO
{
    public class XuathangDAO
    {
        private static XuathangDAO instance;
        public static XuathangDAO Instance
        {
            get {if(instance == null) instance = new XuathangDAO(); return XuathangDAO.instance;}
            private set { XuathangDAO.instance = value; }
        }
        private XuathangDAO() { }

        public List<Xuathang> GetListXuathang()
        {
            List<Xuathang> list = new List<Xuathang>();
            string query = "SELECT * FROM PhieuXuat";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Xuathang xuathang = new Xuathang(item);
                list.Add(xuathang);

            }
            return list;

        }


        public List<Xuathang> SearchXuathangByName(string Tenhang)
        {
            List<Xuathang> list = new List<Xuathang>();
            string query = string.Format("SELECT * FROM PhieuXuat WHERE Tenhang like N'%{0}%'", Tenhang);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xuathang xuathang = new Xuathang(item);
                list.Add(xuathang);

            }
            return list;
        }



        public bool InsertXuathang(string Idphieux, string Idhang, string Tenhang, string Dvt, String Luongxuat, string Giaxuat, string ThanhTien)
        {
            string query = string.Format("INSERT INTO PhieuXuat (Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat, ThanhTien) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat, ThanhTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        //public bool UpdateNCC(string Idncc, string Tenncc, string Diachi, string Sdt)
        //{
        //    string query = string.Format("UPDATE NCC SET Tenncc ='{0}', Diachi = '{1}', Sdt = {2} WHERE Idncc ='{3}' ",Tenncc, Diachi, Sdt, Idncc);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}

        public bool DeleteXuathang(string Idphieux)
        {
            string query = string.Format("DELETE PhieuXuat WHERE Idphieux = {0} ", Idphieux);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        
    }
}
