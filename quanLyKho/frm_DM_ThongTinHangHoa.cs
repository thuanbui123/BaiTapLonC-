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
    public partial class frm_DM_ThongTinHangHoa : Form
    {
        public frm_DM_ThongTinHangHoa()
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

        private void loadComobobox(ComboBox cbo, string query, string valueMember, string displayMember)
        {
            DataTable data = DataProvider.Instance.executeQuery(query);
            cbo.DataSource = data;
            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
        }

        private void loadDuLieuLenLuoi()
        {
            try
            {
                string query = "Select hh.id, hh.tenHangHoa, lh.tenLoai, hh.donViTinh, hh.XuatXu from hangHoa as hh, loaiHang as lh where hh.idLoaiHang = lh.id";
                DataTable data = DataProvider.Instance.executeQuery(query);
                if (data != null && data.Rows.Count > 0)
                {
                    dgvMain.DataSource = data;
                }
                else
                {
                    dgvMain.DataSource = null;
                }
                dinhDangLuoi();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getDongThuI(int i)
        {
            try
            {
                string tenLoai = dgvMain.Rows[i].Cells[2].Value.ToString();
                Object data = DataProvider.Instance.executeScalar("Select * from loaiHang where tenLoai = N'" + tenLoai + "'");
                cboMaLoai.SelectedValue = data;
                txtMaHangHoa.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
                txtTenHangHoa.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
                txtDonViTinh.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
                txtXuatXu.Text = dgvMain.Rows[i].Cells[4].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void frm_DM_ThongTinHangHoa_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            loadComobobox(cboMaLoai, "Select lh.id, lh.tenLoai from loaiHang as lh", "id", "tenLoai");
            getDongThuI(0);
            txtTenHangHoa.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtXuatXu.Enabled = false;
            txtMaHangHoa.Enabled = false;
            cboMaLoai.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private bool kiemTraDuLieu()
        {
            bool status = true;
            errorProvider1.Clear();

            if (txtXuatXu.Text.Length == 0)
            {
                errorProvider1.SetError(txtXuatXu, "Chưa nhập xuất xứ!");
                txtXuatXu.Focus();
                status = false;
            }
            else
            {
                if (Int32.TryParse(txtXuatXu.Text.ToString(), out int result))
                {
                    errorProvider1.SetError(txtXuatXu, "Xuất xứ không được nhập số!");
                    txtXuatXu.Focus();
                    status = false;
                }
            }

            if (txtDonViTinh.Text.Length == 0)
            {
                errorProvider1.SetError(txtDonViTinh, "Chưa nhập đơn vị tính!");
                txtDonViTinh.Focus();
                status = false;
            }
            else
            {
                if (Int32.TryParse(txtDonViTinh.Text.ToString(), out int result))
                {
                    errorProvider1.SetError(txtDonViTinh, "Đơn vị tính không được nhập số!");
                    txtDonViTinh.Focus();
                    status = false;
                }
            }

            if (txtTenHangHoa.Text.Length == 0)
            {
                errorProvider1.SetError(txtTenHangHoa, "Chưa nhập tên hàng hóa!");
                txtTenHangHoa.Focus();
                status = false;
            }
            else
            {
                if (Int32.TryParse(txtTenHangHoa.Text.ToString(), out int result))
                {
                    errorProvider1.SetError(txtTenHangHoa, "Tên hàng hóa không được nhập số!");
                    txtTenHangHoa.Focus();
                    status = false;
                }
            }

            txtMaHangHoa.Text = txtMaHangHoa.Text.Trim();
            String[] s = new string[10];
            s[0] = txtMaHangHoa.Text.Substring(0, 1);
            s[1] = txtMaHangHoa.Text.Substring(1, txtMaHangHoa.Text.Length - 1);
            txtMaHangHoa.Text = s[0].ToUpper() + s[1].ToLower();


            if (txtMaHangHoa.Text.Length == 0)
            {
                errorProvider1.SetError(txtMaHangHoa, "Chưa nhập mã hàng hóa!");
                txtMaHangHoa.Focus();
                status = false;
            }
            else
            {
                if (Int32.TryParse(txtMaHangHoa.Text.ToString(), out int result))
                {
                    errorProvider1.SetError(txtMaHangHoa, "Mã hàng hóa không được nhập số!");
                    txtMaHangHoa.Focus();
                    status = false;
                }
                else
                {
                    if (txtMaHangHoa.Text.Contains(cboMaLoai.SelectedValue.ToString()) == false)
                    {
                        errorProvider1.SetError(txtMaHangHoa, "Loại hàng " + cboMaLoai.SelectedValue.ToString() + " không có " + txtMaHangHoa.Text);
                        txtMaHangHoa.Focus();
                        status = false;
                    }
                    else if (txtMaHangHoa.Text.IndexOf(" ") != -1)
                    {
                        errorProvider1.SetError(txtMaHangHoa, "Mã hàng không chứa ' '!");
                        txtMaHangHoa.Focus();
                        status = false;
                    }
                }
            }

            return status;
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentCell.RowIndex;
            getDongThuI(i);
        }

        bool state = true;

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenHangHoa.Enabled = true;
            txtMaHangHoa.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtXuatXu.Enabled = true;
            cboMaLoai.Enabled = true;
            txtMaHangHoa.Focus();
            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            txtDonViTinh.Text = "";
            txtXuatXu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboMaLoai.Enabled = true;
            txtTenHangHoa.Enabled = true;
            txtTenHangHoa.Focus();
            txtDonViTinh.Enabled = true;
            txtXuatXu.Enabled = true;
            if (txtTenHangHoa.Text == "" && txtDonViTinh.Text == "" && txtXuatXu.Text == "")
            {
                getDongThuI(0);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenHangHoa.Text == "" && txtDonViTinh.Text == "" && txtXuatXu.Text == "")
            {
                MessageBox.Show("Chọn dòng cần xóa");
            } else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string query = "Delete from hangHoa where id = '" + txtMaHangHoa.Text + "'";
                        int i = DataProvider.Instance.executeNonQuery(query);
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                            loadDuLieuLenLuoi();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
            getDongThuI(0);
        }

        private bool themHangHoa()
        {
            bool status = false;

            try
            {
                object kiemTraTonTai = DataProvider.Instance.executeScalar("select COUNT(*) from hangHoa as hh where tenHangHoa = N'" + txtTenHangHoa.Text + "'");
                if (Convert.ToInt32(kiemTraTonTai) <= 0)
                {
                    string query = "Insert into hangHoa values ('" + txtMaHangHoa.Text + "', N'" + txtTenHangHoa.Text + "', N'" + txtDonViTinh.Text + "', '" + cboMaLoai.SelectedValue.ToString() + "', N'" + txtXuatXu.Text + "')";
                    int i = DataProvider.Instance.executeNonQuery(query);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công.");
                        status = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                        status = false;
                    }
                }
                else
                {
                    MessageBox.Show("Mặt hàng " + txtTenHangHoa.Text + " đã tồn tại!");
                    status = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return status;
        }

        private bool suaHangHoa()
        {
            bool status = false;

            try
            {
                string query = "Update hangHoa set tenHangHoa = N'" + txtTenHangHoa.Text + "', donViTinh = N'" + txtDonViTinh.Text + "', idLoaiHang = '" + cboMaLoai.SelectedValue.ToString() + "', xuatXu = N'" + txtXuatXu.Text + "' where id = '" + txtMaHangHoa.Text + "'";
                int i = DataProvider.Instance.executeNonQuery(query);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    status = true;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    status = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return status;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieu())
            {
                if (state == true)
                {
                    bool status = themHangHoa();
                    if (status)
                    {
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnTimKiem.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        cboMaLoai.Enabled = false;
                        txtMaHangHoa.Enabled = false;
                        txtTenHangHoa.Enabled = false;
                        txtDonViTinh.Enabled = false;
                        txtXuatXu.Enabled = false;
                        loadDuLieuLenLuoi();
                    }
                }
                else if (state == false)
                {
                    bool status = suaHangHoa();
                    if (status)
                    {
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnTimKiem.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        cboMaLoai.Enabled = false;
                        txtMaHangHoa.Enabled = false;
                        txtTenHangHoa.Enabled = false;
                        txtDonViTinh.Enabled = false;
                        txtXuatXu.Enabled = false;
                        loadDuLieuLenLuoi();
                    }
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnTimKiem.Enabled = true;
            txtTenHangHoa.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtXuatXu.Enabled = false;
            cboMaLoai.Enabled = false;
            txtMaHangHoa.Enabled = false;
            loadDuLieuLenLuoi();
            getDongThuI(0);
            errorProvider1.Clear();
            if (rdoTheoMa.Checked)
            {
                rdoTheoMa.Checked = false;
            }
            else
            {
                rdoTheoTen.Checked = false;
            }
            txtTimKiem.Text = "";
            loadDuLieuLenLuoi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdoTheoMa.Checked == false && rdoTheoTen.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm");
            }
            else
            {
                if (rdoTheoTen.Checked)
                {
                    string rowFilter = string.Format("{0} like '{1}'", "tenHangHoa", "*" + txtTimKiem.Text + "*");
                    (dgvMain.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                }
                else
                {
                    string rowFilter = string.Format("{0} like '{1}'", "id", "*" + txtTimKiem.Text + "*");
                    (dgvMain.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                }
            }
        }
    }
}
