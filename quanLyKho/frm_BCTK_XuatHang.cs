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
    public partial class frm_BCTK_XuatHang : Form
    {
        public frm_BCTK_XuatHang()
        {
            InitializeComponent();
        }

        private void dinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "Mã hàng hóa";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[1].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[1].Width = 170;
            dgvMain.Columns[2].HeaderText = "Đơn vị tính";
            dgvMain.Columns[2].Width = 170;
            dgvMain.Columns[3].HeaderText = "Số lượng xuất";
            dgvMain.Columns[3].Width = 150;
            dgvMain.Columns[4].HeaderText = "Đơn giá xuất";
            dgvMain.Columns[4].Width = 170;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select hh.id, hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat from hangHoa as hh, chiTietPhieuXuat as ctpx, kho as k where hh.id = k.idHangHoa and k.id = ctpx.idKho";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = data;
            dinhDangLuoi();
        }

        private void frm_BCTK_XuatHang_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }

        private void chkKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhachHang.Checked)
            {
                txtTimKiemKhachHang.Enabled = true;
            } else
            {
                txtTimKiemKhachHang.Enabled = false;
            }
        }

        private void chkHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoaDon.Checked)
            {
                txtTimKiemHoaDon.Enabled = true;
            } else
            {
                txtTimKiemHoaDon.Enabled = false;
            }
        }
    }
}
