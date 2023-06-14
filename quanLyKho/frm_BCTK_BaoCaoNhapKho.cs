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
    public partial class frm_BCTK_BaoCaoNhapKho : Form
    {
        public frm_BCTK_BaoCaoNhapKho()
        {
            InitializeComponent();
        }
        public class GlobaldataNhapKho
        {
            public static string SelectedIdSoPhieuNhap { get; set; }
            public static string SelectedIdNhaCungCap { get; set; }
            public static string SelectedNgayLap { get; set; }
        }
        private void dinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "Tên nhà cung cấp";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[1].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[1].Width = 170;
            dgvMain.Columns[2].HeaderText = "Đơn vị tính";
            dgvMain.Columns[2].Width = 170;
            dgvMain.Columns[3].HeaderText = "Số lượng nhập";
            dgvMain.Columns[3].Width = 150;
            dgvMain.Columns[4].HeaderText = "Đơn giá nhập";
            dgvMain.Columns[4].Width = 170;
            dgvMain.Columns[5].HeaderText = "Ngày lập";
            dgvMain.Columns[5].Width = 170;
            dgvMain.Columns[6].HeaderText = "Số phiếu nhập";
            //dgvMain.Columns[6].Width = 170;
            dgvMain.Columns[6].Visible = false;

        }

        private void LoadLenLuoi()
        {
            string query = "Select ncc.tenNhaCungCap, hh.tenHangHoa, hh.donViTinh, ctpn.soLuongNhap, ctpn.donGiaNhap, pn.ngayLap_Nhap, pn.soPhieuNhap" +
               " from hangHoa as hh, chiTietPhieuNhap as ctpn, phieuNhap as pn, nhaCungCap as ncc" +
               " Where ncc.id = pn.idNhaCungCap and pn.soPhieuNhap = ctpn.idSoPhieuNhap and ctpn.idHangHoa = hh.id";

            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = data;
            dinhDangLuoi();

        }

        private void frm_BCTK_BaoCaoNhapKho_Load(object sender, EventArgs e)
        {
            LoadLenLuoi();
            txtTheoHoaDon.Enabled = false;
            txtTheoNhaCungCap.Enabled = false;
            dgvMain.Show();
        }

        private void chkTheoNhaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTheoNhaCungCap.Checked)
            {
                txtTheoNhaCungCap.Enabled = true;
                txtTheoNhaCungCap.Focus();
            }
            else
            {
                txtTheoNhaCungCap.Enabled = false;
                txtTheoNhaCungCap.Text = "";
            }
        }

        private void chkTheoHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTheoHoaDon.Checked)
            {
                txtTheoHoaDon.Enabled = true;
                txtTheoHoaDon.Focus();
            }
            else
            {
                txtTheoHoaDon.Enabled = false;
                txtTheoHoaDon.Text = "";
            }
        }

        

        private void btnIn_Click(object sender, EventArgs e)
        {
            frm_InBCTK_NhapKho a = new frm_InBCTK_NhapKho();
            a.Show();
        }

        private void btnThucHien_Click_1(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.Instance.executeQuery("Exec USP_BCTKNhapKho @tuNgay , @denNgay", new object[] { dtpTuNgay.Value.ToString("yyyy-MM-dd"), dtpDenNgay.Value.ToString("yyyy-MM-dd") });
            if (chkTheoNhaCungCap.Checked)
            {

                dt.DefaultView.RowFilter = string.Format("{0} like '{1}'", "tenNhaCungCap", "*" + txtTheoNhaCungCap.Text + "*");
                if (chkTheoHoaDon.Checked)
                {
                    dt.DefaultView.RowFilter = string.Format("{0} like '{1}'", "soPhieuNhap", "*" + txtTheoHoaDon.Text + "*");
                }
            }
            else
            {
                if (chkTheoHoaDon.Checked)
                {
                    dt.DefaultView.RowFilter = string.Format("{0} like '{1}'", "soPhieuNhap", "*" + txtTheoHoaDon.Text + "*");
                }
            }
            dgvMain.DataSource = dt;
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            frm_InBCTK_NhapKho a = new frm_InBCTK_NhapKho();
            a.Show();
        }
    }
}
