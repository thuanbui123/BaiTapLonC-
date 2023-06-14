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
    public partial class frm_BC_ThongKeKhachHang : Form
    {
        public frm_BC_ThongKeKhachHang()
        {
            InitializeComponent();
        }
        private void dinhDangLuoi()
        {
            dgv_Main_ThongKeKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgv_Main_ThongKeKhachHang.Columns[0].Width = 200;
            dgv_Main_ThongKeKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgv_Main_ThongKeKhachHang.Columns[1].Width = 250;
            dgv_Main_ThongKeKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgv_Main_ThongKeKhachHang.Columns[2].Width = 310;
            dgv_Main_ThongKeKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgv_Main_ThongKeKhachHang.Columns[3].Width = 200;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "Select * from khachHang";
            DataTable data = DataProvider.Instance.executeQuery(query);
            if(data != null && data.Rows.Count > 0)
            {
                dgv_Main_ThongKeKhachHang.DataSource = data;
            } 
            else
            {
                dgv_Main_ThongKeKhachHang.DataSource = null;
            }
            dinhDangLuoi();
        }

        private void frm_BC_ThongKeKhachHang_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            Frm_IN_ThongKeKhachHang f = new Frm_IN_ThongKeKhachHang();
            f.ShowDialog();
        }
    }
}
