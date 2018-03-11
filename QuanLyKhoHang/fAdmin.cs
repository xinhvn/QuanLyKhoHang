using QuanLyKhoHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.TaiKhoan";

            //DataProvider provider = new DataProvider();

            dataAdmin.DataSource = DataProvider.Instance.ExecuteQuery(query);
     }



        public SqlCommand command { get; set; }
    }
}
