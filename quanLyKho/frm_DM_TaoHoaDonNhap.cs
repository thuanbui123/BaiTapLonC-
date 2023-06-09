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
    public partial class frm_DM_TaoHoaDonNhap : Form
    {
        bool isAddNew = false;
        bool isEdit = false;
        public frm_DM_TaoHoaDonNhap()
        {
            InitializeComponent();
        }

        private void dinhDangluoi()
        {
            dgvMain.Columns[0].HeaderText = "Số hóa đơn";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[1].HeaderText = "Nhà cung cấp";
            dgvMain.Columns[1].Width = 170;
            dgvMain.Columns[2].HeaderText = "Ngày lập";
            dgvMain.Columns[2].Width = 170;

        }
        private void LoadDuLieuLenLuoi()
        {
            string query = "Select pn.soPhieuNhap, ncc.tenNhaCungCap, pn.ngayLap_Nhap from phieuNhap as pn, nhaCungCap as ncc where pn.idNhaCungCap = ncc.id";
            DataTable data = DataProvider.Instance.executeQuery(query);
            if (data != null && data.Rows.Count > 0)
            {
                dgvMain.DataSource = data;
            }
            else
            {
                dgvMain.DataSource = null;
            }
            dinhDangluoi();
        }

        private void loadCombo ()
        {
            string query = "SELECT id, tenNhaCungCap FROM nhaCungCap";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            cboNhaCungCap.DataSource = dt;
            cboNhaCungCap.DisplayMember = "tenNhaCungCap";
            cboNhaCungCap.ValueMember = "id";
        }

        private void btnNhapHang_Click_1(object sender, EventArgs e)
        {
            frm_DM_ChiTietHoaDonNhap f = new frm_DM_ChiTietHoaDonNhap();
            f.ShowDialog();
        }

        private void frm_DM_TaoHoaDonNhap_Load_1(object sender, EventArgs e)
        {
            loadCombo();
            LoadDuLieuLenLuoi();
            setState("Reset");
            txtSoHoaDon.Enabled = false;
            cboNhaCungCap.Enabled = false;
            dtpNgayLap.Enabled = false;
        }

        private void setState(string state)
        {
            switch (state)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    txtSoHoaDon.Enabled = false;
                    cboNhaCungCap.Enabled = false;
                    dtpNgayLap.Enabled = false;
                    break;
                case "Adding":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtSoHoaDon.Text = "";
                    dtpNgayLap.Text = DateTime.Now.ToString();
                    cboNhaCungCap.Text = "";
                    txtSoHoaDon.Focus();
                    break;
                case "Editing":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtSoHoaDon.Enabled = true;
                    cboNhaCungCap.Enabled = true;
                    dtpNgayLap.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setState("Adding");
            isAddNew = true;
            txtSoHoaDon.Enabled = true;
            cboNhaCungCap.Enabled = true;
            dtpNgayLap.Enabled = true;
            txtSoHoaDon.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setState("Editing");
            isEdit = true;
            txtSoHoaDon.Focus();
        }

        private bool kiemTra()
        {


            if (txtSoHoaDon.Text == "")
            {
                MessageBox.Show("Chưa nhập số hóa đơn", "Thông báo");
                txtSoHoaDon.Focus();
                return false;
            }

            if (cboNhaCungCap.Text == "")
            {
                MessageBox.Show("Chưa chọn tên nhà sản xuất", "Thông báo");
                cboNhaCungCap.Focus();
                return false;
            }
            DateTime currentDate = DateTime.Now;
            String dateString = dtpNgayLap.Value.ToString("yyyy/MM/dd");
            DateTime inputDate = DateTime.ParseExact(dateString, "yyyy/MM/dd", null);
            DateTime date = DateTime.Parse(dateString);
            int ktDate = (currentDate - inputDate).Days;
            if (ktDate < 0)
            {
                MessageBox.Show("Nhập sai ngày, mời bạn nhập lại", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setState("Reset");
            txtSoHoaDon.Enabled = false;
            cboNhaCungCap.Enabled = false;
            dtpNgayLap.Enabled = false;
        }

        public void luuSua()

        {
            if (kiemTra() == true)
            {
                string query = @"update phieuNhap set idNhaCungCap = '" + cboNhaCungCap.SelectedValue + "', ngayLap_Nhap = '" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "'WHERE (soPhieuNhap = '" + txtSoHoaDon.Text + "')";

                var result = DataProvider.Instance.executeNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDuLieuLenLuoi();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        public void luuThem()
        {
            if (kiemTra() == true)
            {
                string query = @"INSERT INTO phieuNhap VALUES ('" + txtSoHoaDon.Text.Trim() + "','" + cboNhaCungCap.SelectedValue + "','" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "')";

                var result = DataProvider.Instance.executeNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    LoadDuLieuLenLuoi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                luuThem();
                isAddNew = false;
            }
            if (isEdit)
            {
                luuSua();
                isEdit = false;
            }
            setState("Reset");
        }

        private void getDong (int i)
        {
            txtSoHoaDon.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
            dtpNgayLap.Value = Convert.ToDateTime(dgvMain.Rows[i].Cells[2].Value);
            object id = DataProvider.Instance.executeScalar("Select id from nhaCungCap where tenNhaCungCap = N'"+dgvMain.Rows[i].Cells[1].Value.ToString()+"'");
            cboNhaCungCap.SelectedValue = id.ToString();
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentRow.Index;
            getDong(i);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.SelectedRows.Count == -1)
                {
                    MessageBox.Show("Vui long chon du lieu muon Xoa !");
                    return;
                }
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)

                {
                    string query = "delete from PhieuNhap where soPhieuNhap = '" + txtSoHoaDon.Text.Trim() + "'";
                    int kt = DataProvider.Instance.executeNonQuery(query);

                    if (kt > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        //  setState("Reset");
                        LoadDuLieuLenLuoi();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
