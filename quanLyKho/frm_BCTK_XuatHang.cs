using quanLyKho.DAO;
using System;
using System.Data;
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
            dgvMain.Columns[5].HeaderText = "Số phiếu xuất";
            dgvMain.Columns[5].Visible = false;
            dgvMain.Columns[6].HeaderText = "Tên khách hàng";
            dgvMain.Columns[6].Visible = false;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "Select hh.id, hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat, px.soPhieuXuat, kh.tenKhachHang" +
                " from hangHoa as hh, chiTietPhieuXuat as ctpx, kho as k, phieuXuat as px, khachHang as kh" +
                " Where (k.idHangHoa = hh.id and ctpx.idKho = k.id and px.soPhieuXuat = ctpx.idPhieuXuat) and px.idKhachHang = kh.id ";
            DataTable data = DataProvider.Instance.executeQuery(query);
            if (data != null && data.Rows.Count > 0)
            {
                dgvMain.DataSource = data;
            } else
            {
                dgvMain.DataSource = null;
            }
            dinhDangLuoi();
        }

        private void frm_BCTK_XuatHang_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            dgvMain.Show();
        }

        private void chkKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhachHang.Checked)
            {
                txtTimKiemKhachHang.Enabled = true;
            }
            else
            {
                txtTimKiemKhachHang.Enabled = false;
            }
        }

        private void chkHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoaDon.Checked)
            {
                txtTimKiemHoaDon.Enabled = true;
            }
            else
            {
                txtTimKiemHoaDon.Enabled = false;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.Instance.executeQuery("Exec USP_ThongKe @tuNgay , @denNgay", new object[] { dtpTuNgay.Value.ToString("yyyy-MM-dd"), dtpDenNgay.Value.ToString("yyyy-MM-dd") });
            if (chkKhachHang.Checked)
            {
                dt.DefaultView.RowFilter = string.Format("{0} like '{1}'", "tenKhachHang", "*" + txtTimKiemKhachHang.Text + "*");
                if (chkHoaDon.Checked)
                {
                    dt.DefaultView.RowFilter = string.Format("{0} like '{1}'", "soPhieuXuat", "*" + txtTimKiemHoaDon.Text + "*");
                }
            }
            dgvMain.DataSource = dt;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dtpDenNgay.Enabled = true;
            dtpTuNgay.Enabled = true;
            chkKhachHang.Enabled = true;
            chkHoaDon.Enabled = true;
            btnThucHien.Enabled = true;
            btnIn.Enabled = true;
            loadDuLieuLenLuoi();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dtpDenNgay.Enabled = false;
            dtpTuNgay.Enabled = false;
            chkKhachHang.Enabled = false;
            chkHoaDon.Enabled = false;
            btnThucHien.Enabled = false;
            btnIn.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frm_In_ThongKeXuatHang f = new frm_In_ThongKeXuatHang();
            f.ShowDialog();
        }
    }
}
