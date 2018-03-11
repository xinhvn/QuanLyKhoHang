using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAO
{
    public class HanghoaDAO
    {
        private static HanghoaDAO instance;
        public static HanghoaDAO Instance
        {
            get {if(instance == null) instance = new HanghoaDAO(); return HanghoaDAO.instance;}
            private set { HanghoaDAO.instance = value; }
        }
        private HanghoaDAO() { }

        public List<Hanghoa> GetListHanghoa()
        {
            List<Hanghoa> list = new List<Hanghoa>();
            string query = "SELECT * FROM HangTon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Hanghoa hanghoa = new Hanghoa(item);
                list.Add(hanghoa);

            }
            return list;

        }

        public List<Hanghoa> SearchHanghoaByName(string Tenhang)
        {
            List<Hanghoa> list = new List<Hanghoa>();
            string query = string.Format("SELECT * FROM HangTon WHERE Tenhang like N'%{0}%'",Tenhang);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Hanghoa hanghoa = new Hanghoa(item);
                list.Add(hanghoa);

            }
            return list;
        }



        public bool InsertHanghoa(string Idhang, string Tenhang, string Dvt, string SoLuong, string Gianhap, string Giaxuat)
        {
            string query = string.Format("INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat) VALUES('{0}', '{1}','{2}','{3}',N'{4}',N'{5}')", Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool UpdateHanghoa(string Idhang, string Tenhang, string Dvt, string SoLuong, string Gianhap, string Giaxuat)
        {
            string query = string.Format("UPDATE HangTon SET Tenhang ='{0}', Dvt = '{1}', SoLuong = {2}, Gianhap = N'{3}', Giaxuat =N'{4}' WHERE Idhang ='{5}' ", Tenhang, Dvt, SoLuong, Gianhap, Giaxuat, Idhang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteHanghoa(string Idhang) //string Tenhang, string Dvt, string SoLuong, string Gianhap, string Giaxuat
        {
            string query = string.Format("DELETE HangTon WHERE Idhang = {0} ", Idhang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        //internal bool InsretHanghoa(string Idhang, string Tenhang, string Dvt, string SoLuong, string Gianhap, string Giaxuat)
        //{
        //    string query = string.Format("NSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat) VALUES('{0}', '{1}','{2}','{3}',N'{4}',N'{5}')", Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat);
        //    int result = DataProvider.Instance.ExcuteNonQuery(query);
        //    return result > 0;
        //}
    }
}
