using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAO
{
    public class NCCDAO
    {
        private static NCCDAO instance;
        public static NCCDAO Instance
        {
            get {if(instance == null) instance = new NCCDAO(); return NCCDAO.instance;}
            private set { NCCDAO.instance = value; }
        }
        private NCCDAO() { }

        public List<NCC> GetListNCC()
        {
            List<NCC> list = new List<NCC>();
            string query = "SELECT * FROM NCC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                NCC ncc = new NCC(item);
                list.Add(ncc);

            }
            return list;

        }


        public List<NCC> SearchNccByName(string Tenncc)
        {
            List<NCC> list = new List<NCC>();
            string query = string.Format("SELECT * FROM NCC WHERE Tenncc like N'%{0}%'", Tenncc);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NCC ncc = new NCC(item);
                list.Add(ncc);

            }
            return list;
        }



        public bool InsertNCC(string Idncc, string Tenncc, string Diachi, string Sdt)
        {
            string query = string.Format("INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt) VALUES('{0}', '{1}','{2}','{3}')", Idncc, Tenncc, Diachi, Sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool UpdateNCC(string Idncc, string Tenncc, string Diachi, string Sdt)
        {
            string query = string.Format("UPDATE NCC SET Tenncc ='{0}', Diachi = '{1}', Sdt = {2} WHERE Idncc ='{3}' ",Tenncc, Diachi, Sdt, Idncc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteNCC(string Idncc)
        {
            string query = string.Format("DELETE NCC WHERE Idncc = {0} ", Idncc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
