using quanLyKho.DAO;
using quanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKho
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        public frmThongTinTaiKhoan(string value)
        {
            InitializeComponent();
            txtTenDangNhap.Text = value;
        }

        public Account getAccount()
        {
            Account account;

            string query = "select * from taiKhoan where tenDangNhap = N'" + txtTenDangNhap.Text + "'";

            DataTable data = DataProvider.Instance.executeQuery(query);

            account = new Account(data.Rows[0]);

            return account;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            Account account = getAccount();
            txtTenNguoiDung.Text = account.TenNguoiDung;
            txtMatKhau.Text = account.MatKhau;
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            anHienMatKhau.Instance.anHoacHienMatKhau(txtMatKhau, btnXem);
        }
    }
}
