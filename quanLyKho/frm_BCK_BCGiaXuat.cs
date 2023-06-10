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
    public partial class frm_BCK_BCGiaXuat : Form
    {
        public frm_BCK_BCGiaXuat()
        {
            InitializeComponent();
        }

        private void dinhDangLuoi()
        {
            dgvBCK_BCGiaXuatKho.Columns[0].HeaderText = "Mã hàng hóa";
            dgvBCK_BCGiaXuatKho.Columns[0].Width = 150;
            dgvBCK_BCGiaXuatKho.Columns[1].HeaderText = "Tên hàng hóa";
            dgvBCK_BCGiaXuatKho.Columns[1].Width = 170;
            dgvBCK_BCGiaXuatKho.Columns[2].HeaderText = "Đơn vị tính";
            dgvBCK_BCGiaXuatKho.Columns[2].Width = 170;
            dgvBCK_BCGiaXuatKho.Columns[3].HeaderText = "Đơn giá xuất";
            dgvBCK_BCGiaXuatKho.Columns[3].Width = 150;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select hangHoa.id, hangHoa.tenHangHoa, hangHoa.donViTinh, chiTietPhieuXuat.donGiaXuat from chiTietPhieuXuat inner join kho on chiTietPhieuXuat.idKho = kho.id inner join hangHoa on kho.idHangHoa = hangHoa.id";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvBCK_BCGiaXuatKho.DataSource = data;
            dinhDangLuoi();
        }

        private void frm_BCK_BCGiaXuat_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            rdbBCK_LamMoi.Checked = true;
            load_cbo_HangHoa();
        }

        private void load_cbo_HangHoa()
        {
            try
            {
                string query = "Select lh.id, lh.tenLoai from loaiHang as lh";
                DataTable data = DataProvider.Instance.executeQuery(query);
                DataRow row = data.NewRow();
                row["tenLoai"] = "Chọn loại hàng hóa";
                data.Rows.InsertAt(row, 0);
                cboBCK_LoaiHang.DataSource = data;
                cboBCK_LoaiHang.ValueMember = "id";
                cboBCK_LoaiHang.DisplayMember = "tenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboBCK_LoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            int viTri = cboBCK_LoaiHang.SelectedIndex;
            string layGiaTri = cboBCK_LoaiHang.Text;

            if (viTri != 0)
            {
                string query = "select hangHoa.id, hangHoa.tenHangHoa, hangHoa.donViTinh, chiTietPhieuXuat.donGiaXuat from chiTietPhieuXuat inner join kho on chiTietPhieuXuat.idKho = kho.id inner join hangHoa on kho.idHangHoa = hangHoa.id inner join loaiHang on hangHoa.idLoaiHang = loaiHang.id where loaiHang.tenLoai = N'"+layGiaTri+"'";
                DataTable data = DataProvider.Instance.executeQuery(query);
                dgvBCK_BCGiaXuatKho.DataSource = data;
                dinhDangLuoi();
            }
        }
    }
}
