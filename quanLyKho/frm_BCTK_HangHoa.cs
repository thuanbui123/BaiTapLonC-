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
    public partial class frm_BCTK_HangHoa : Form
    {
        public frm_BCTK_HangHoa()
        {
            InitializeComponent();
        }

        private void dinhDangLuoi ()
        {
            dgvMain.Columns[0].HeaderText = "Mã hàng hóa";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[1].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[1].Width = 170;
            dgvMain.Columns[2].HeaderText = "Tên loại";
            dgvMain.Columns[2].Width = 170;
            dgvMain.Columns[3].HeaderText = "Đơn vị tính";
            dgvMain.Columns[3].Width = 170;
            dgvMain.Columns[4].HeaderText = "Xuất xứ";
            dgvMain.Columns[4].Width = 150;
        }

        private void loadDuLieuLenLuoi ()
        {
            string query = "Select hh.id, hh.tenHangHoa, lh.tenLoai, hh.donViTinh, hh.XuatXu from hangHoa as hh, loaiHang as lh where hh.idLoaiHang = lh.id";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = data;
            dinhDangLuoi();
        }

        private void frm_BCTK_HangHoa_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }
    }
}
