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
    public partial class frm_DM_ThongTinLoaiHang : Form
    {
        public frm_DM_ThongTinLoaiHang()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string query = "SELECT lh.id,lh.tenLoai,lh.dienGiai from loaiHang as lh";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = dt;
            DinhDangLuoi();
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

        private bool kiemTra()
        {
            if (txtMaLoaiHang.Text == "")
            {
                MessageBox.Show("Chua nhap ma loai hang ", "Thong bao");
                Focus();
                return false;
            }
            if (txtTenLoaiHang.Text == "")
            {
                MessageBox.Show("Chua nhap ten loai hang ", "Thong bao");
                Focus();
                return false;
            }
            if (txtDienGiai.Text == "")
            {
                MessageBox.Show("Chua nhap ten loai hang ", "Thong bao");
                Focus();
                return false;
            }
            return true;
        }

        public void InsertData()
        {
            if (kiemTra() == true)
            {
                try
                {
                    String query = "INSERT INTO loaiHang VALUES  ( '" + txtMaLoaiHang.Text.Trim() + " ', N' " + txtTenLoaiHang.Text + "' , N'" + txtDienGiai.Text + "' )";
                    var result = DataProvider.Instance.executeNonQuery(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thông báo!");
                    }


                    DinhDangLuoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Delete()
        {
            try
            {


                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string query = "DELETE from loaiHang WHERE id = '" + txtMaLoaiHang.Text + "' ";
                    int i = DataProvider.Instance.executeNonQuery(query);
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        bool stateThem = false;
        bool stateSua = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaLoaiHang.Enabled = true;
            txtTenLoaiHang.Enabled = true;
            txtDienGiai.Enabled = true;

            txtMaLoaiHang.Text = "";
            txtTenLoaiHang.Text = "";
            txtDienGiai.Text = "";

            txtMaLoaiHang.Focus();

            stateThem = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaLoaiHang.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
                txtTenLoaiHang.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
                txtDienGiai.Text = dgvMain.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void frm_DM_ThongTinLoaiHang_Load(object sender, EventArgs e)
        {
            LoadData();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;


            txtMaLoaiHang.Enabled = false;
            txtTenLoaiHang.Enabled = false;
            txtDienGiai.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (stateThem)
            {
                InsertData();
                stateThem = false;
            }

            if (stateSua)
            {
                update();
                stateSua = false;
            }

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaLoaiHang.Enabled = false;
            txtTenLoaiHang.Enabled = false;
            txtDienGiai.Enabled = false;
        }

        

        public void update()
        {
            try
            {
                string query = "update loaiHang set tenLoai = N'" + txtTenLoaiHang.Text.Trim() + "', dienGiai = N'" + txtDienGiai.Text.Trim() + "' where id = '" + txtMaLoaiHang.Text.Trim() + "'";
                int i = DataProvider.Instance.executeNonQuery(query);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;


            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaLoaiHang.Enabled = false;
            txtTenLoaiHang.Enabled = true;
            txtDienGiai.Enabled = true;

            stateSua = true;

            txtTenLoaiHang.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaLoaiHang.Enabled = false;
            txtTenLoaiHang.Enabled = false;
            txtDienGiai.Enabled = false;


            rdoTimKiemTheoMa.Checked = false;
            rdoTimKiemTheoTen.Checked = false;

            txtTimKiem.Text = "";

            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            btnHuy.Enabled = true;
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm!", "Thông báo");
            }
            if (rdoTimKiemTheoMa.Checked == true || rdoTimKiemTheoTen.Checked == true)
            {
                if (rdoTimKiemTheoMa.Checked)
                {
                    try

                    {
                        string query = "SELECT * FROM loaiHang where ID like '%" + txtTimKiem.Text.Trim() + "%'";
                        DataTable dt = DataProvider.Instance.executeQuery(query);
                        dgvMain.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (rdoTimKiemTheoTen.Checked)
                {
                    try
                    {
                        string query = "SELECT * FROM loaiHang where tenLoai like '%" + txtTimKiem.Text.Trim() + "%'";
                        DataTable dt = DataProvider.Instance.executeQuery(query);
                        dgvMain.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục điều kiện tìm kiếm!", "Thông báo");

            }
        }
    }
}
