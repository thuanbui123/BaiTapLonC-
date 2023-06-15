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

        private void dinhDangLuoi()
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

        public void loadDuLieu ()
        {
            string query = "Select hh.id, hh.tenHangHoa, hh.donViTinh, lh.tenLoai, hh.xuatXu from hangHoa as hh, loaiHang as lh where hh.idLoaiHang = lh.id";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvMain.DataSource = dt;
            } else
            {
                dgvMain.DataSource = null;
            }
            dinhDangLuoi();
        }

        private void frm_BCTK_HangHoa_Load(object sender, EventArgs e)
        {
            loadDuLieu();   
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frm_In_BCTKHangHoa f = new frm_In_BCTKHangHoa();
            f.Show();
        }
    }
}
