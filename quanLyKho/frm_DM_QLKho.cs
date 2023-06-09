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
    public partial class frm_DM_QLKho : Form
    {
        public frm_DM_QLKho()
        {
            InitializeComponent();
        }

        private void dinhDangLuoi()
        {
            dgv_DM_Kho.Columns[0].HeaderText = "Tên hàng";
            dgv_DM_Kho.Columns[0].Width = 150;
            dgv_DM_Kho.Columns[1].HeaderText = "Đơn vị tính";
            dgv_DM_Kho.Columns[1].Width = 170;
            dgv_DM_Kho.Columns[2].HeaderText = "Số lượng";
            dgv_DM_Kho.Columns[2].Width = 170;
            dgv_DM_Kho.Columns[3].HeaderText = "Xuất xứ";
            dgv_DM_Kho.Columns[3].Width = 150;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select hh.tenHangHoa, hh.donViTinh, k.soLuong, hh.xuatXu from hangHoa as hh, kho as k where hh.id = k.idHangHoa";
            DataTable data = DataProvider.Instance.executeQuery(query);
            if (data != null && data.Rows.Count > 0)
            {
                dgv_DM_Kho.DataSource = data;
            }
            else
            {
                dgv_DM_Kho.DataSource = null;
            }
            dinhDangLuoi();
        }

        private void frm_DM_QLKho_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }

        private void btn_DM_Kho_LamMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
