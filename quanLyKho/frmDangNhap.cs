using quanLyKho.DAO;
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

namespace quanLyKho
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool status = true;
            errorProvider1.Clear();
            object data = DataProvider.Instance.executeScalar("Select count (*) from taiKhoan where tenDangNhap = N'"+txtTenDangNhap.Text+ "' COLLATE SQL_Latin1_General_CP1_CS_AS");
            int soLuong = (int)data;
            if (txtTenDangNhap.Text.Length == 0)
            {
                errorProvider1.SetError(txtTenDangNhap, "Chưa điền tên đăng nhập!");
                txtTenDangNhap.Focus();
                status = false;
            }

            if (soLuong < 1)
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không đúng!");
                status = false;
            }
            else
            {
                data = DataProvider.Instance.executeScalar("Select count (*) from taiKhoan where tenDangNhap = N'" + txtTenDangNhap.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and matKhau = N'" + txtMatKhau.Text + "'");
                soLuong = (int)data;

                if (soLuong < 1)
                {
                    errorProvider1.SetError(txtMatKhau, "mật khẩu không đúng!");
                    txtMatKhau.Focus();
                    status = false;
                }
            }

            if (txtMatKhau.Text.Length == 0)
            {
                errorProvider1.SetError(txtMatKhau, "Chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                status = false;
            }

            if (status)
            {
                if (dangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    frmMain f = new frmMain(txtTenDangNhap.Text);
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = this.FindForm() as frmDangNhap;
            f.FormClosed += frmDangNhap_FormClosed;
            f.Close();
        }

        private bool dangNhap (string userName, string password) 
        {
            string query = "exec USP_login @userName , @password";
            DataTable table = new DataTable();
            table = DataProvider.Instance.executeQuery(query, new object[] {userName, password });
            return table.Rows.Count > 0;
        }

        public void resetControl()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            anHienMatKhau.Instance.anHoacHienMatKhau(txtMatKhau, btnXem);
        }

        private static bool isClose = true;
        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                isClose = false;
            }
        }
    }
}
