﻿using quanLyKho.DAO;
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
        bool state;
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
                string id = cbo_HangHoa.SelectedValue.ToString();
                object idKho = DataProvider.Instance.executeScalar("select k.id from kho as k where k.idHangHoa = '" + id + "'");
                string query = "insert into chiTietPhieuXuat values ("+ Convert.ToInt32(idKho) +", '"+lbl_DM_CTPX_SoHoaDon.Text+"',  "+ Convert.ToInt32(txt_SoLuong.Text) +", "+ Convert.ToDecimal(txt_DonGia.Text) +")";
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

            txt_DonGia.Enabled = true;
            txt_GiaGoc.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_SoLuong.Text = "";
            txt_GiaGoc.Text = "";
            txt_DonGia.Text = "";
        }

        private bool error()
        {
            bool error = true;
            int dg, sl, slk, gg;
            if (txt_DonGia.Text == "")
            {
                errorProvider1.SetError(txt_DonGia, "Chưa nhập thông tin");
                txt_DonGia.Focus();
                error = false;
            }
            else

                if (int.TryParse(txt_DonGia.Text, out dg) == false)
            {
                errorProvider1.SetError(txt_DonGia, "Sai định dạng");
                txt_DonGia.Focus();
                error = false;
            }

            if (txt_GiaGoc.Text == "")
            {
                errorProvider1.SetError(txt_GiaGoc, "Chưa nhập thông tin");
                txt_GiaGoc.Focus();
                error = false;
            }
            else

                if (int.TryParse(txt_GiaGoc.Text, out gg) == false)
            {
                errorProvider1.SetError(txt_GiaGoc, "Sai định dạng");
                txt_DonGia.Focus();
                error = false;
            }



            if (txt_SoLuong.Text == "")
            {
                errorProvider1.SetError(txt_SoLuong, "Chưa nhập thông tin");
                txt_SoLuong.Focus();
                error = false;
            }
            else

                if (int.TryParse(txt_SoLuong.Text, out sl) == false)
            {
                errorProvider1.SetError(txt_SoLuong, "Sai định dạng");
                txt_SoLuong.Focus();
                error = false;
            }


            if (txt_SoLuongKho.Text == "")
            {
                errorProvider1.SetError(txt_SoLuongKho, "Chưa nhập thông tin");
                txt_SoLuongKho.Focus();
                error = false;
            }
            else

                if (int.TryParse(txt_SoLuongKho.Text, out slk) == false)
            {
                errorProvider1.SetError(txt_SoLuongKho, "Sai định dạng");
                txt_SoLuongKho.Focus();
                error = false;
            }

            return error;
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
            errorProvider1.Clear();
            state = true;

            btn_DM_ThemDonXuat.Enabled = true;
            btn_DM_SuaDonXuat.Enabled = true;
            btn_DM_XoaDonXuat.Enabled = true;
            btn_DM_HuyDonXuat.Enabled = false;
            btn_DM_LuuDonXuat.Enabled = false;
            txt_SoLuongKho.Text = "";
            txt_SoLuong.Text = "";
            txt_GiaGoc.Text = "";
            txt_DonGia.Text = "";
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
            errorProvider1.Clear();
            if (error() == false)
            {
                error();
            }
            else
            {
                if (state == true)


                {
                    addCustomer();

                }
                else
                {
                    editStudent();
                }
            }
        }

        private void btn_DM_InDonXuat_Click(object sender, EventArgs e)
        {
            frm_DM_IN_CTPX f = new frm_DM_IN_CTPX();
            f.ShowDialog();
        }
        public object idchitietphieuxuat()
        {
            object idChiTietPhieuXuat = DataProvider.Instance.executeScalar("select ctpx.idXuat from chiTietPhieuXuat as ctpx, hangHoa as hh, kho as k where hh.id = '" + id() + "' and hh.id = k.idHangHoa and k.id = ctpx.idKho");
            return idChiTietPhieuXuat;
        }
        public string id()
        {
            string id = cbo_HangHoa.SelectedValue.ToString();
            return id;
        }
        public object idkho1()
        {

            object idKho = DataProvider.Instance.executeScalar("Select id from kho where idHangHoa = '" + id() + "'");
            return idKho;
        }
        public object idPhieuXuat()
        {
            object idPhieuXuat = DataProvider.Instance.executeScalar("Select px.soPhieuXuat from phieuXuat as px, chiTietPhieuXuat as ctpx where ctpx.idXuat = '" + idchitietphieuxuat() + "' and px.soPhieuXuat = ctpx.idPhieuXuat");
            return idPhieuXuat;
        }
        private void btn_DM_XoaDonXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete from chiTietPhieuXuat where idPhieuXuat = '" + idPhieuXuat() + "'";

                    var result = DataProvider.Instance.executeNonQuery(query);

                    if (result > 0)
                    {
                        MessageBox.Show("Delete success");
                        loadDuLieuLenLuoi();
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                    loadDuLieuLenLuoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
