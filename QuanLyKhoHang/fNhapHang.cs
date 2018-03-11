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
    public partial class fNhapHang : Form
    {
        public fNhapHang()
        {
            InitializeComponent();
            Load();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Method

        List<Nhaphang> SearchNhaphangByName(string Tenhang)
        {
            List<Nhaphang> nhaphang = NhaphangDAO.Instance.SearchNhaphangByName(Tenhang);

            return nhaphang;
        }

        void AddNhaphangBinding()
        {
            txbIDnhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Idphieun"));
            txbIDhang.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Idhang"));
            txbNCC.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Idncc"));
            txbTenHang.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Tenhang"));
            txbDvt.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Dvt"));
            txbLuongNhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Luongnhap"));
            txbGiaNhap.DataBindings.Add(new Binding("Text", datanhap.DataSource, "Gianhap"));
            txbThanhTien.DataBindings.Add(new Binding("Text", datanhap.DataSource, "ThanhTien"));
        }


        void Load()
        {
            LoadListNhaphang();
            AddNhaphangBinding();
        }

        void LoadListNhaphang()
        {
            datanhap.DataSource = NhaphangDAO.Instance.GetListNhaphang();
            //dataNCC.DataSource = NCCDAO.Instance.GetListNCC();
        }


        #endregion

        #region events

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Idphieun = txbIDnhap.Text;
            string Idhang = txbIDhang.Text;
            string Idncc = txbNCC.Text;
            string Tenhang = txbTenHang.Text;
            string Dvt = txbDvt.Text;
            string Luongnhap = txbLuongNhap.Text;
            string Gianhap = txbGiaNhap.Text;
            string ThanhTien = txbThanhTien.Text;


            if (NhaphangDAO.Instance.InsertNhaphang(Idphieun, Idhang, Idncc, Tenhang, Dvt, Luongnhap, Gianhap, ThanhTien))
            {
                MessageBox.Show("Thêm Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Idphieun = txbIDnhap.Text;
            //string Idhang = txbIDhang.Text;
            //string Tenhang = txbTenHang.Text;
            //string Dvt = txbDvt.Text;
            //string Luongxuat = txbLuongXuat.Text;
            //string Giaxuat = txbGiaXuat.Text;
            //string ThanhTien = txbThanhTien.Text;


            if (NhaphangDAO.Instance.DeleteNhaphang(Idphieun))
            {
                MessageBox.Show("Xoá Hàng Hóa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa Hàng Hóa");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListNhaphang();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            datanhap.DataSource = SearchNhaphangByName(txbTim.Text);
        }

        #endregion

    }
}
