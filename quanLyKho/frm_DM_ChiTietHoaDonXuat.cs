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
            string query = "Select hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat from chiTietPhieuXuat as ctpx, kho as k, hangHoa as hh, phieuXuat as px where ctpx.idKho = k.id and ctpx.idPhieuXuat = px.soPhieuXuat and k.idHangHoa = hh.id";

            DataTable data = getData(query);

            dgv_Main_DonXuat.DataSource = data;
            dinhDangLuoi();
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

        }

        
        private void addCustomer()
        {
            try
            {
                string query = "insert chiTietPhieuXuat" + " values ( '" + Convert.ToDecimal(txt_DonGia.Text.Trim()) + "" + Convert.ToDecimal(txt_SoLuongKho.Text.Trim()) + "" + Convert.ToDecimal(txt_GiaGoc.Text.Trim()) + "',  " + Convert.ToDecimal(txt_SoLuong.Text.Trim()) + ")";
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

        private void bnt_DM_LuuDonXuat_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void btn_DM_ThemDonXuat_Click(object sender, EventArgs e)
        {
            btn_DM_ThemDonXuat.Enabled = false;
            txt_DonGia.Focus();
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_InDonXuat.Enabled = true;

            txt_DonGia.Enabled = true;
            txt_GiaGoc.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_SoLuongKho.Enabled = true;
            txt_SoLuongKho.Text = "";
            txt_SoLuong.Text = "";
            txt_GiaGoc.Text = "";
            txt_DonGia.Text = "";
        }

        private void btn_DM_SuaDonXuat_Click(object sender, EventArgs e)
        {

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
            //try
            //{
            //    string tenHH = dgv_Main_DonXuat.Rows[i].Cells[0].Value.ToString();
            //    Object idHH = DataProvider.Instance.executeScalar("Select id from hangHoa where tenHangHoa = N'" + tenHH + "'");
            //    cbo_HangHoa.SelectedValue = idHH;
            //    object data = DataProvider.Instance.executeScalar("Select donViTinh from hangHoa where tenHangHoa = N'" + tenHH + "'");
            //    lbl_DonVi.Text = Convert.ToString(data);
            //    data = DataProvider.Instance.executeScalar("Select k.soLuong from hangHoa as hh, kho as k where hh.tenHangHoa = N'" + tenHH + "' and k.idHangHoa = hh.id");
            //    txt_SoLuongKho.Text = Convert.ToString(data);
            //    data = DataProvider.Instance.executeScalar("Select xuatXu from hangHoa where tenHangHoa = N'" + tenHH + "'");
            //    lbl_XuatXu.Text = Convert.ToString(data);
            //    data = DataProvider.Instance.executeScalar("Select ctpn.donGiaNhap from hangHoa as hh, chiTietPhieuNhap as ctpn where hh.tenHangHoa = N'" + tenHH + "' and ctpn.idHangHoa = hh.id");
            //    txt_GiaGoc.Text = Convert.ToString(data);
            //    data = DataProvider.Instance.executeScalar("Select ctpx.soLuongXuat * ctpx.donGiaXuat from hangHoa as hh, chiTietPhieuXuat as ctpx, kho as k where tenHangHoa = N'" + tenHH + "' and ctpx.idKho = k.id and k.idHangHoa = hh.id");
            //    lbl_ThanhTien.Text = Convert.ToString(data);
            //    txt_SoLuong.Text = dgv_Main_DonXuat.Rows[i].Cells[2].Value.ToString();
            //    txt_DonGia.Text = dgv_Main_DonXuat.Rows[i].Cells[3].Value.ToString();
            //    int soLuongXuat = Convert.ToInt32(txt_SoLuong.Text.ToString());
            //    object idChiTietPhieuXuat = DataProvider.Instance.executeScalar("select ctpx.idXuat from chiTietPhieuXuat as ctpx, hangHoa as hh, kho as k where hh.id = '"+idHH+"' and hh.id = k.idHangHoa and k.id = ctpx.idKho");
            //    object idPhieuXuat = DataProvider.Instance.executeScalar("Select px.soPhieuXuat from phieuXuat as px, chiTietPhieuXuat as ctpx where ctpx.idXuat = '"+idChiTietPhieuXuat+ "' and px.soPhieuXuat = ctpx.idPhieuXuat");
            //    lbl_DM_CTPX_SoHoaDon.Text = idPhieuXuat.ToString();
            //    data = DataProvider.Instance.executeScalar("Select px.ngayLap_Xuat from phieuXuat as px, chiTietPhieuXuat as ctpx where ctpx.idXuat = '" + idChiTietPhieuXuat + "' and px.soPhieuXuat = ctpx.idPhieuXuat");
            //    lbl_NgayLapHD.Text = Convert.ToDateTime(data).ToString("dd/MM/yyyy");
            //    data = DataProvider.Instance.executeScalar("Select kh.tenKhachHang from khachHang as kh, phieuXuat as px where kh.id = px.idKhachHang and px.soPhieuXuat = '" + lbl_DM_CTPX_SoHoaDon.Text+"'");
            //    lbl_KhachHang.Text = data.ToString();
            //    data = DataProvider.Instance.executeScalar("Select kh.soDienThoai from khachHang as kh, phieuXuat as px where kh.id = px.idKhachHang and px.soPhieuXuat = '" + lbl_DM_CTPX_SoHoaDon.Text + "'");
            //    lbl_SoDienThoai.Text = data.ToString();
            //    data = DataProvider.Instance.executeScalar("Select kh.diaChi from khachHang as kh, phieuXuat as px where kh.id = px.idKhachHang and px.soPhieuXuat = '" + lbl_DM_CTPX_SoHoaDon.Text + "'");
            //    lbl_DiaChi.Text = data.ToString();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
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
            getDongThuI(0);
        }
    }
}
