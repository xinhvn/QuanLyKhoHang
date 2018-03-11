using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query="SELECT * FROM TaiKhoan WHERE idLogin = N'"+ userName +"' AND Pass = N'"+ passWord +"'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count >0;
        }

        public Account GetAccountByIdLogin(string idLogin)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TaiKhoan where idLogin ='"+ idLogin +"'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        internal bool UpdateAccount(string userName, string displayName, string password, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, password, newpass });

            return result > 0;
        }

        internal Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
    }
}
