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
    public partial class frm_DM_ChiTietHoaDonXuat : Form
    {
        public frm_DM_ChiTietHoaDonXuat()
        {
            InitializeComponent();
        }

        public void loadDuLieuLenLuoi()
        {
            string query = "Select hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat, ctpx.idXuat " +
                "from chiTietPhieuXuat as ctpx, kho as k, hangHoa as hh, phieuXuat as px" +
                " where ctpx.idKho = k.id and ctpx.idPhieuXuat = px.soPhieuXuat and k.idHangHoa = hh.id and ctpx.idPhieuXuat = '" + GlobalDataChiTietHoaDonXuat.soHoaDon + "'";

            DataTable data = getData(query);

            if (data != null && data.Rows.Count > 0)
            {
                dgv_Main_DonXuat.DataSource = data;
                dinhDangLuoi();
            }
            else
            {
                dgv_Main_DonXuat.DataSource = null;
                dinhDangLuoi();
            }
        }

        private DataTable getData(string query)
        {
            DataTable data;

            data = DataProvider.Instance.executeQuery(query);

            return data;
        }

        private void dinhDangLuoi()
        {
            dgv_Main_DonXuat.Columns[0].HeaderText = "Tên hàng hóa";
            dgv_Main_DonXuat.Columns[0].Width = 300;
            dgv_Main_DonXuat.Columns[1].HeaderText = "Đơn vị tính";
            dgv_Main_DonXuat.Columns[1].Width = 200;
            dgv_Main_DonXuat.Columns[2].HeaderText = "Số lượng";
            dgv_Main_DonXuat.Columns[2].Width = 200;
            dgv_Main_DonXuat.Columns[3].HeaderText = "Đơn giá";
            dgv_Main_DonXuat.Columns[3].Width = 250;
            dgv_Main_DonXuat.Columns[4].HeaderText = "id xuất";
            dgv_Main_DonXuat.Columns[4].Visible = false;

        }

        
        private void addCustomer()
        {
            try
            {

                object idKho = DataProvider.Instance.executeScalar("Select id from kho where idHangHoa = '"+cbo_HangHoa.SelectedValue+"'");
                string query = "insert into chiTietPhieuXuat values ('"+idKho +"', '"+lbl_DM_CTPX_SoHoaDon.Text+"',  "+ Convert.ToInt32(txt_SoLuong.Text) +", "+ Convert.ToDecimal(txt_DonGia.Text) +")";
                int i = DataProvider.Instance.executeNonQuery(query);
                if (i > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loadDuLieuLenLuoi();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void editStudent()
        {
            try
            {
                string query = "update KhachHang" + " set  tenkhachHang = N'" + txt_SoLuong.Text.Trim() + "', diaChi = '" + txt_SoLuongKho.Text.Trim() + "', soDienThoai = " + Convert.ToDecimal(txt_DonGia.Text.Trim()) + " where id = " + txt_GiaGoc.Text.Trim() + "";
                int i = DataProvider.Instance.executeNonQuery(query);

                if (i > 0)
                {
                    MessageBox.Show("thành công");
                    loadDuLieuLenLuoi();
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        

        private void btn_DM_ThemDonXuat_Click(object sender, EventArgs e)
        {
            btn_DM_ThemDonXuat.Enabled = false;
            cbo_HangHoa.Enabled = true;
            txt_DonGia.Focus();
            btn_DM_LuuDonXuat.Enabled = true;
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_InDonXuat.Enabled = true;

            txt_DonGia.Enabled = true;
            txt_GiaGoc.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_SoLuong.Text = "";
            txt_GiaGoc.Text = "";
            txt_DonGia.Text = "";
        }

        public int getSoLuong ()
        {
            string id = cbo_HangHoa.SelectedValue.ToString();
            object soLuong = DataProvider.Instance.executeScalar("select k.soLuong from kho as k where k.idHangHoa = '"+id+"'");
            return Convert.ToInt32(soLuong);
        }

        public double getGiaGoc()
        {
            string id = cbo_HangHoa.SelectedValue.ToString();
            object giaGoc = DataProvider.Instance.executeScalar("select ctpn. donGiaNhap from chiTietPhieuNhap as ctpn where ctpn.idHangHoa = '" + id.ToString() + "'");
            return Convert.ToDouble(giaGoc);
        }

        private void btn_DM_SuaDonXuat_Click(object sender, EventArgs e)
        {
            btn_DM_ThemDonXuat.Enabled = false;
            cbo_HangHoa.Enabled = true;
            txt_DonGia.Focus();
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_InDonXuat.Enabled = true;

            txt_DonGia.Enabled = true;
            txt_SoLuong.Enabled = true;
        }

        private void loadCboHangHoa ()
        {
            string query = "Select hh.id, hh.tenHangHoa from hangHoa as hh";
            DataTable data = DataProvider.Instance.executeQuery(query);
            cbo_HangHoa.DataSource = data;
            cbo_HangHoa.ValueMember = "id";
            cbo_HangHoa.DisplayMember = "tenHangHoa";
        }

        private void getDongThuI(int i)
        {
            try
            {
                string tenHH = dgv_Main_DonXuat.Rows[i].Cells[0].Value.ToString();
                Object idHH = DataProvider.Instance.executeScalar("Select id from hangHoa where tenHangHoa = N'" + tenHH + "'");
                cbo_HangHoa.SelectedValue = idHH;
                object data = DataProvider.Instance.executeScalar("Select donViTinh from hangHoa where tenHangHoa = N'" + tenHH + "'");
                lbl_DonVi.Text = Convert.ToString(data);
                data = DataProvider.Instance.executeScalar("Select k.soLuong from hangHoa as hh, kho as k where hh.tenHangHoa = N'" + tenHH + "' and k.idHangHoa = hh.id");
                txt_SoLuongKho.Text = Convert.ToString(data);
                data = DataProvider.Instance.executeScalar("Select xuatXu from hangHoa where tenHangHoa = N'" + tenHH + "'");
                lbl_XuatXu.Text = Convert.ToString(data);
                data = DataProvider.Instance.executeScalar("Select ctpx.soLuongXuat * ctpx.donGiaXuat from hangHoa as hh, chiTietPhieuXuat as ctpx, kho as k where tenHangHoa = N'" + tenHH + "' and ctpx.idKho = k.id and k.idHangHoa = hh.id");
                lbl_ThanhTien.Text = Convert.ToString(data);
                txt_SoLuong.Text = dgv_Main_DonXuat.Rows[i].Cells[2].Value.ToString();
                txt_DonGia.Text = dgv_Main_DonXuat.Rows[i].Cells[3].Value.ToString();
                int soLuongXuat = Convert.ToInt32(txt_SoLuong.Text.ToString());
                object idPhieuXuat = DataProvider.Instance.executeScalar("Select px.soPhieuXuat from phieuXuat as px, chiTietPhieuXuat as ctpx where ctpx.idXuat = '"+dgv_Main_DonXuat.Rows[i].Cells[4].Value.ToString()+ "' and px.soPhieuXuat = ctpx.idPhieuXuat");
                lbl_DM_CTPX_SoHoaDon.Text = idPhieuXuat.ToString();
                data = DataProvider.Instance.executeScalar("Select px.ngayLap_Xuat from phieuXuat as px, chiTietPhieuXuat as ctpx where ctpx.idXuat = '" + dgv_Main_DonXuat.Rows[i].Cells[4].Value.ToString() + "' and px.soPhieuXuat = ctpx.idPhieuXuat");
                lbl_NgayLapHD.Text = Convert.ToDateTime(data).ToString("dd/MM/yyyy");
                data = DataProvider.Instance.executeScalar("Select kh.tenKhachHang from khachHang as kh, phieuXuat as px where kh.id = px.idKhachHang and px.soPhieuXuat = '" + lbl_DM_CTPX_SoHoaDon.Text+"'");
                lbl_KhachHang.Text = data.ToString();
                data = DataProvider.Instance.executeScalar("Select kh.soDienThoai from khachHang as kh, phieuXuat as px where kh.id = px.idKhachHang and px.soPhieuXuat = '" + lbl_DM_CTPX_SoHoaDon.Text + "'");
                lbl_SoDienThoai.Text = data.ToString();
                data = DataProvider.Instance.executeScalar("Select kh.diaChi from khachHang as kh, phieuXuat as px where kh.id = px.idKhachHang and px.soPhieuXuat = '" + lbl_DM_CTPX_SoHoaDon.Text + "'");
                lbl_DiaChi.Text = data.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgv_Main_DonXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_Main_DonXuat.CurrentCell.RowIndex;
            getDongThuI(i);

        }

        private void frm_DM_ChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            loadCboHangHoa();
            loadDuLieuLenLuoi();
            lbl_DM_CTPX_SoHoaDon.Text = GlobalDataChiTietHoaDonXuat.soHoaDon;
            lbl_KhachHang.Text = GlobalDataChiTietHoaDonXuat.tenKhachHang;
            lbl_NgayLapHD.Text = GlobalDataChiTietHoaDonXuat.NgayLapHD;
            lbl_SoDienThoai.Text = GlobalDataChiTietHoaDonXuat.soDienThoai;
            lbl_DiaChi.Text = GlobalDataChiTietHoaDonXuat.diaChi;
        }

        private void btn_DM_HuyDonXuat_Click(object sender, EventArgs e)
        {

        }

        private void btn_DM_LuuDonXuat_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void cbo_HangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_SoLuongKho.Text = getSoLuong().ToString();
            txt_GiaGoc.Text = getGiaGoc().ToString();
        }

        private void btn_DM_LuuDonXuat_Click_1(object sender, EventArgs e)
        {
            addCustomer();
        }
    }
}
