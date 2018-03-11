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
    public partial class fTableManager : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount.loaitk); }
        }
            

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
        }

        void ChangeAccount(int LoaiTK)
        {
            adminToolStripMenuItem.Enabled = LoaiTK == 0;
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }


        #region Events

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHanghoa f = new fHanghoa();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNCC f = new fNCC();
            f.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapHang f = new fNhapHang();
            f.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXuatHang f = new fXuatHang();
            f.ShowDialog();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGioiThieu f = new fGioiThieu();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#endregion

    }
}