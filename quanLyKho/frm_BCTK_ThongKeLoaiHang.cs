using Microsoft.Reporting.WinForms;
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
    public partial class frm_BCTK_ThongKeLoaiHang : Form
    {
        public frm_BCTK_ThongKeLoaiHang()
        {
            InitializeComponent();
        }
        private void DinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "Mã loại hàng";
            dgvMain.Columns[0].Width = 200;
            dgvMain.Columns[1].HeaderText = "Tên loại hàng";
            dgvMain.Columns[1].Width = 250;
            dgvMain.Columns[2].HeaderText = "Diễn giải";
            dgvMain.Columns[2].Width = 250;

        }
        private void frm_BCTK_ThongKeLoaiHang_Load(object sender, EventArgs e)
        {
            string query = "SELECT lh.id,lh.tenLoai,lh.dienGiai from loaiHang as lh";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = dt;
            DinhDangLuoi();
           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frm_BCK_InLoaiHang f = new frm_BCK_InLoaiHang();
            f.ShowDialog();
        }
    }
}
