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
    public partial class frm_BCK_HangTonKho : Form
    {
        public frm_BCK_HangTonKho()
        {
            InitializeComponent();
        }

        private void frm_BCK_HangTonKho_Load(object sender, EventArgs e)
        {
            LoadComBo();
            LoadData();
        }
        public void LoadData()
        {
            string query = "SELECT hangHoa.id, hangHoa.tenHangHoa, chiTietPhieuNhap.soLuongNhap, phieuNhap.ngayLap_Nhap FROM hangHoa,chiTietPhieuNhap,phieuNhap WHERE hangHoa.id = chiTietPhieuNhap.idHangHoa AND chiTietPhieuNhap.idSoPhieuNhap = phieuNhap.soPhieuNhap";
            DataTable dt = DataProvider.Instance.executeQuery(query);



            if (dt != null && dt.Rows.Count > 0)
            {
                dgvMain.DataSource = dt;
            }
            else
            {
                dgvMain.DataSource = null;
            }
            DinhDangLuoi();
        }


        private void DinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "Mã hàng hóa";
            dgvMain.Columns[0].Width = 200;
            dgvMain.Columns[1].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[1].Width = 250;
            dgvMain.Columns[2].HeaderText = "Số lượng nhập";
            dgvMain.Columns[2].Width = 250;
            dgvMain.Columns[3].HeaderText = "Ngày nhập";
            dgvMain.Columns[3].Width = 250;


        }
        public void LoadComBo()
        {

            DataTable dt = DataProvider.Instance.executeQuery("Select  tenLoai, id from loaiHang");
            cboLoaiHang.DataSource = dt;
            cboLoaiHang.ValueMember = "id";
            cboLoaiHang.DisplayMember = "tenLoai";

        }
        private bool kiemTra()
        {
            long kq;
            if (txtSoNgayLuuKho.Text == "")
            {
                MessageBox.Show("Chưa nhập số ngày lưu kho!", "Thông báo!");
                txtSoNgayLuuKho.Focus();
                return false;
            }
            if (!(long.TryParse(txtSoNgayLuuKho.Text, out kq)))
            {
                MessageBox.Show("Hãy nhập đúng định dạng số ngày lưu kho!", "Thông báo");
                txtSoNgayLuuKho.Clear();
                txtSoNgayLuuKho.Focus();
                return false;
            }
            if (kq < 0)
            {
                MessageBox.Show("Số ngày lưu kho không được âm!", "Thông báo");
                txtSoNgayLuuKho.Clear();
                txtSoNgayLuuKho.Focus();
                return false;
            }
            return true;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoAll.Checked == true || rdoLoaiHang.Checked == true)
            {
                if (kiemTra() == true)
                {
                    if (rdoAll.Checked)
                    {

                        string query = "SELECT hangHoa.id, hangHoa.tenHangHoa, chiTietPhieuNhap.soLuongNhap, phieuNhap.ngayLap_Nhap FROM hangHoa,chiTietPhieuNhap,phieuNhap WHERE hangHoa.id = chiTietPhieuNhap.idHangHoa AND chiTietPhieuNhap.idSoPhieuNhap = phieuNhap.soPhieuNhap AND  DATEDIFF(day, phieuNhap.ngayLap_Nhap,GETDATE()) >  '" + txtSoNgayLuuKho.Text + "'  ";
                        DataTable dt = DataProvider.Instance.executeQuery(query);
                        dgvMain.DataSource = dt;
                    }
                    else
                    {
                        if (rdoLoaiHang.Checked)
                        {
                            string query = "SELECT hangHoa.id, hangHoa.tenHangHoa, chiTietPhieuNhap.soLuongNhap, phieuNhap.ngayLap_Nhap FROM hangHoa,chiTietPhieuNhap,phieuNhap,loaiHang WHERE hangHoa.idLoaiHang = '" + cboLoaiHang.SelectedValue + "'   AND chiTietPhieuNhap.idSoPhieuNhap = phieuNhap.soPhieuNhap AND  hangHoa.id = chiTietPhieuNhap.idHangHoa AND  DATEDIFF(day, phieuNhap.ngayLap_Nhap,GETDATE()) > '" + txtSoNgayLuuKho.Text + "' ";
                            DataTable dt = DataProvider.Instance.executeQuery(query);
                            dgvMain.DataSource = dt;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mục tìm kiếm!", "Thông báo!");
            }

        }

    }
}
