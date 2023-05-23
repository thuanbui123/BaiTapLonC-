using quanLyKho.DAO;
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
    public partial class frmMain : Form
    {
        public string userName;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string userName)
        {
            InitializeComponent();
            btnThongTinTaiKhoan.Text = userName;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            formManager fm = formManager.GetInstance(this);

            frmDoiMatKhau f = new frmDoiMatKhau(btnThongTinTaiKhoan.Text);

            fm.showForm(pnlContainer, f);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.resetControl();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            formManager fm = formManager.GetInstance(this);
            frmThongTinTaiKhoan frm = new frmThongTinTaiKhoan(btnThongTinTaiKhoan.Text);
            fm.showForm(pnlContainer,frm);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            formManager fm = formManager.GetInstance(this);
            fm.showForm(pnlContainer, frm);
        }

        private void btn_BCTK_HangHoa_Click(object sender, EventArgs e)
        {
            frm_BCTK_HangHoa f = new frm_BCTK_HangHoa();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_DM_HangHoa_Click(object sender, EventArgs e)
        {
            frm_DM_ThongTinHangHoa f = new frm_DM_ThongTinHangHoa();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_BCTK_XuatHang_Click(object sender, EventArgs e)
        {
            frm_BCTK_XuatHang f = new frm_BCTK_XuatHang();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void tcThanhDieuHuong_Click(object sender, EventArgs e)
        {
            if(tcThanhDieuHuong.SelectedIndex == 0)
            {
                frmTrangChu f = new frmTrangChu();
                formManager fm = new formManager();
                fm.showForm(pnlContainer, f);
            } else if (tcThanhDieuHuong.SelectedIndex == 1)
            {
                frm_DM_KhachHang f = new frm_DM_KhachHang();
                formManager fm = new formManager();
                fm.showForm(pnlContainer, f);
            } else if (tcThanhDieuHuong.SelectedIndex == 2)
            {
                frm_BC_ThongKeKhachHang f = new frm_BC_ThongKeKhachHang();
                formManager fm = new formManager();
                fm.showForm(pnlContainer, f);
            } else if (tcThanhDieuHuong.SelectedIndex == 3)
            {

            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_DM_KhachHang_Click(object sender, EventArgs e)
        {
            frm_DM_KhachHang f = new frm_DM_KhachHang();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_BCTK_KhachHang_Click(object sender, EventArgs e)
        {
            frm_BC_ThongKeKhachHang f = new frm_BC_ThongKeKhachHang();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_DM_NhaCungCap_Click(object sender, EventArgs e)
        {
            frm_DM_NCC f = new frm_DM_NCC();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_DM_LoaiHang_Click(object sender, EventArgs e)
        {
            frm_DM_ThongTinLoaiHang f = new frm_DM_ThongTinLoaiHang();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_DM_NhapHang_Click(object sender, EventArgs e)
        {
            frm_DM_TaoHoaDonNhap f = new frm_DM_TaoHoaDonNhap();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_DM_XuatHang_Click(object sender, EventArgs e)
        {
            frm_DM_TaoHoaDonXuat f = new frm_DM_TaoHoaDonXuat();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_DM_Kho_Click(object sender, EventArgs e)
        {
            frm_DM_QLKho f = new frm_DM_QLKho();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_BCTK_NhaCungCap_Click(object sender, EventArgs e)
        {
            frm_BCTK_NCC f = new frm_BCTK_NCC();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_BCTK_LoaiHang_Click(object sender, EventArgs e)
        {
            frm_BCTK_ThongKeLoaiHang f = new frm_BCTK_ThongKeLoaiHang();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_BCTK_NhapHang_Click(object sender, EventArgs e)
        {
            frm_BCTK_BaoCaoNhapKho f = new frm_BCTK_BaoCaoNhapKho();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }

        private void btn_BCTK_Kho_Click(object sender, EventArgs e)
        {
            frm_BCTK_BaoCaoKho f = new frm_BCTK_BaoCaoKho();
            formManager fm = new formManager();
            fm.showForm(pnlContainer, f);
        }
    }
}
