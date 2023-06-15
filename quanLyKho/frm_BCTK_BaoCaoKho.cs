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
    public partial class frm_BCTK_BaoCaoKho : Form
    {
        public frm_BCTK_BaoCaoKho()
        {
            InitializeComponent();
        }

        private void DinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "Mã loại hàng";
            dgvMain.Columns[0].Width = 200;
            dgvMain.Columns[1].HeaderText = "Tên loại hàng";
            dgvMain.Columns[1].Width = 250;
            dgvMain.Columns[2].HeaderText = "Đơn vị";
            dgvMain.Columns[2].Width = 200;
            dgvMain.Columns[3].HeaderText = "Số lượng";
            dgvMain.Columns[3].Width = 150;
        }

        private void frm_BCTK_BaoCaoKho_Load(object sender, EventArgs e)
        {
            string query = "SELECT hangHoa.id,hangHoa.tenHangHoa,hangHoa.donViTinh,kho.soLuong FROM hangHoa,kho WHERE hangHoa.id = kho.idHangHoa";
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            frm_BCK_InBaoCaoKho f = new frm_BCK_InBaoCaoKho();
            f.ShowDialog();
        }
    }
}
