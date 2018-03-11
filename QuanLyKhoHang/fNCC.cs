using QuanLyKhoHang.DAO;
using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class fNCC : Form
    {
        public fNCC()
        {
            InitializeComponent();
            Load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Method

        List<NCC> SearchNccByName(string Tenncc)
        {
            List<NCC> ncc = NCCDAO.Instance.SearchNccByName(Tenncc);
            return ncc;
        }

        void AddNCCBinding()
        {
            
            txbMaNCC.DataBindings.Add(new Binding("text", dataNCC.DataSource, "IdNCC"));
            txbTenNCC.DataBindings.Add(new Binding("Text", dataNCC.DataSource, "TenNCC"));
            txbDiaChi.DataBindings.Add(new Binding("Text", dataNCC.DataSource, "Diachi"));
            txbSDT.DataBindings.Add(new Binding("Text", dataNCC.DataSource, "SDT"));
        }

        void Load()
        {
            LoadListNCC();
            AddNCCBinding();
        }

        void LoadListNCC()
        {
            dataNCC.DataSource = NCCDAO.Instance.GetListNCC();
            //dataNCC.DataSource = NCCDAO.Instance.GetListNCC();
        }


        #endregion


        #region events

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Idncc = txbMaNCC.Text;
            string Tenncc = txbTenNCC.Text;
            string Diachi = txbDiaChi.Text;
            string Sdt = txbSDT.Text;
         

            if (NCCDAO.Instance.InsertNCC(Idncc, Tenncc, Diachi, Sdt))
            {
                MessageBox.Show("Thêm Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Idncc = txbMaNCC.Text;
            string Tenncc = txbTenNCC.Text;
            string Diachi = txbDiaChi.Text;
            string Sdt = txbSDT.Text;


            if (NCCDAO.Instance.UpdateNCC(Idncc, Tenncc, Diachi, Sdt))
            {
                MessageBox.Show("Sửa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Idncc = txbMaNCC.Text;


            if (NCCDAO.Instance.DeleteNCC(Idncc))
            {
                MessageBox.Show("Xóa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataNCC.DataSource = SearchNccByName(txbTim.Text);
        }

        #endregion
    }
}
