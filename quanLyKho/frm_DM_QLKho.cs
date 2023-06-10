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

        private void load_cbo_HangHoa()
        {
            try
            {
                string query = "Select lh.id, lh.tenLoai from loaiHang as lh";
                DataTable data = DataProvider.Instance.executeQuery(query);
                DataRow row = data.NewRow();
                row["tenLoai"] = "Chọn loại hàng hóa";
                data.Rows.InsertAt(row, 0);
                cbo_DM_Kho_HangHoa.DataSource = data;
                cbo_DM_Kho_HangHoa.ValueMember = "id";
                cbo_DM_Kho_HangHoa.DisplayMember = "tenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_DM_Kho_LamMoi_Click(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            load_cbo_HangHoa();
        }

        private void frm_DM_QLKho_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            load_cbo_HangHoa();
        }

        private void cbo_DM_Kho_HangHoa_SelectedValueChanged(object sender, EventArgs e)
        {
            int viTri = cbo_DM_Kho_HangHoa.SelectedIndex;
            string layGiaTri = cbo_DM_Kho_HangHoa.Text;
            if (viTri != 0) {
                string query1 = "select hangHoa.tenHangHoa, hangHoa.donViTinh, kho.soLuong, hangHoa.xuatXu from (kho inner join hangHoa on kho.idHangHoa = hangHoa.id) inner join loaiHang on hangHoa.idLoaiHang = loaiHang.id where loaiHang.tenLoai = N'" + layGiaTri + "'";
                DataTable data = DataProvider.Instance.executeQuery(query1);
                dgv_DM_Kho.DataSource = data;
                dinhDangLuoi();
            }
            ////string query = "select hh.tenHangHoa, hh.donViTinh, k.soLuong, hh.xuatXu from hangHoa as hh, kho as k, loaiHang as lh, (lh inner join hh on lh.id=hh.idLoaiHang) inner join k on hh.id=k.idHangHoa where lh.tenLoai = N'" + layGiaTri + "'";
        }
    }
}
