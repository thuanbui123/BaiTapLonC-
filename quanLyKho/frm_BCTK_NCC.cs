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
    public partial class frm_BCTK_NCC : Form
    {
        public frm_BCTK_NCC()
        {
            InitializeComponent();
        }
        private void dinhDangLuoi()
        {
            dgv_BCTK_NCC.Columns[0].HeaderText = "Mã Nhà cung cấp";
            dgv_BCTK_NCC.Columns[0].Width = 150;
            dgv_BCTK_NCC.Columns[1].HeaderText = "Tên Nhà cung cấp";
            dgv_BCTK_NCC.Columns[1].Width = 170;
            dgv_BCTK_NCC.Columns[2].HeaderText = "Địa chỉ";
            dgv_BCTK_NCC.Columns[2].Width = 170;
            dgv_BCTK_NCC.Columns[3].HeaderText = "Số điện thoại";
            dgv_BCTK_NCC.Columns[3].Width = 150;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select ncc.id, ncc.tenNhaCungCap, ncc.diaChi, ncc.soDienThoai from nhaCungCap as ncc";
            DataTable data = DataProvider.Instance.executeQuery(query);
            if (data != null && data.Rows.Count > 0)
            {
                dgv_BCTK_NCC.DataSource = data;
            } else
            {
                dgv_BCTK_NCC.DataSource = null;
            }
            dinhDangLuoi();
        }

        private void frm_BCTK_NCC_Load_1(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }

        private void btn_BCTK_NCC_In_Click(object sender, EventArgs e)
        {
            frm_rp_BCTK_NCC f = new frm_rp_BCTK_NCC();
            f.Show();
        }
    }
}
