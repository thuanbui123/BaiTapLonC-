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
    public partial class frm_DM_ChiTietHoaDonNhap : Form
    {
        public frm_DM_ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }
        bool isAddNew = false;
        bool isEdit = false;
        public void dinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "ID Nhập";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[0].Visible = false;
            dgvMain.Columns[1].HeaderText = "Tên phiếu nhập";
            dgvMain.Columns[1].Width = 170;
            dgvMain.Columns[2].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[2].Width = 170;
            dgvMain.Columns[3].HeaderText = "Số lượng";
            dgvMain.Columns[3].Width = 170;
            dgvMain.Columns[4].HeaderText = "Đơn giá";
            dgvMain.Columns[4].Width = 170;
        }
        private void loadLenLuoi()
        {
            string query = "select ctpn.idNhap, pn.soPhieuNhap, hh.tenHangHoa, ctpn.soLuongNhap, ctpn.donGiaNhap from chiTietPhieuNhap as ctpn, NhaCungCap as ncc, hangHoa as hh, phieuNhap as pn where ctpn.idSoPhieuNhap = pn.soPhieuNhap and pn.idNhaCungCap = ncc.id and ctpn.idHangHoa = hh.id and pn.soPhieuNhap = '" + class_ChiTietHoaDonNhap.SelectedIdSoPhieuNhap + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            if (dt != null)
            {
                dgvMain.DataSource = dt;
            }
            else
            {
                dgvMain = null;
            }
            dinhDangLuoi();
        }
        public void loadComBo()
        {
            DataTable dt = DataProvider.Instance.executeQuery("Select id, tenHangHoa from hangHoa");
            cboHangHoa.DataSource = dt;
            cboHangHoa.ValueMember = "ID";
            cboHangHoa.DisplayMember = "tenHangHoa";
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            frm_InChiTietPhieuNhap a = new frm_InChiTietPhieuNhap();
            a.Show();
        }

        private void frm_DM_ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            lblSoHoaDon.Text = class_ChiTietHoaDonNhap.SelectedIdSoPhieuNhap.ToString();
            lblNhaCungCap.Text = class_ChiTietHoaDonNhap.SelectedIdNhaCungCap.ToString();
            lblNgayLap.Text = class_ChiTietHoaDonNhap.SelectedNgayLap.ToString();
            loadLenLuoi();
            setState("Reset");
            loadComBo();
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
                    txtDonGia.Enabled = false;
                    cboHangHoa.Enabled = false;
                    txtSoLuong.Enabled = false;

                    break;
                case "Adding":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtSoLuong.Enabled = true;
                    txtDonGia.Enabled = true;
                    cboHangHoa.Enabled = true;
                    lblDonVi.Text = "";
                    lblThanhTien.Text = "";
                    txtSoLuong.Text = "";
                    cboHangHoa.Text = "";
                    txtDonGia.Text = "";
                    cboHangHoa.Focus();
                    break;
                case "Editing":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtSoLuong.Enabled = true;
                    txtDonGia.Enabled = true;
                    cboHangHoa.Enabled = true;
                    cboHangHoa.Focus();
                    break;
                default:
                    break;
            }
        }
        private bool error()
        {

            //bool error = true;
            int hangHoa, soLuong, donGia;
            if (txtDonGia.Text == "")
            {

                errorProvider1.SetError(txtDonGia, " Chưa nhập thông tin");
                txtDonGia.Focus();
                return false;
            }
            //else
            ////if (decimal.tryparse(txtdongia.text, out decimal dongia) == false) ;
            //   if (int.tryparse(txtdongia.text, out dongia) == false)
            //{
            //    errorprovider1.seterror(txtdongia, "sai định dạng");
            //    txtdongia.focus();
            //    return false;
            //}
            if (txtSoLuong.Text == "")
            {

                errorProvider1.SetError(txtSoLuong, " Chưa nhập thông tin");
                txtSoLuong.Focus();
                return false;
            }
            //else
            //    if (int.TryParse(txtSoLuong.Text, out soLuong) == false)
            //{
            //    errorProvider1.SetError(txtSoLuong, "Sai định dạng");
            //    txtSoLuong.Focus();
            //    return false;
            //}
            if (cboHangHoa.SelectedValue == "")
            {

                errorProvider1.SetError(cboHangHoa, " Chưa nhập thông tin");
                cboHangHoa.Focus();
                return false;
            }
            //else
            //    if (int.TryParse(cboHangHoa.Text, out hangHoa) == false)
            //{
            //    errorProvider1.SetError(cboHangHoa, "Sai định dạng");
            //    cboHangHoa.Focus();
            //    return false;
            //}
            return true;
        }
        private void getDongThuI(int i)
        {
            try
            {
                string tenHH = dgvMain.Rows[i].Cells[2].Value.ToString();
                Object idHH = DataProvider.Instance.executeScalar("Select id from hangHoa where tenHangHoa = N'" + tenHH + "'");
                cboHangHoa.SelectedValue = idHH;
                object data = DataProvider.Instance.executeScalar("Select donViTinh from hangHoa where tenHangHoa = N'" + tenHH + "'");
                lblDonVi.Text = Convert.ToString(data);
                data = DataProvider.Instance.executeScalar("Select k.soLuong from hangHoa as hh, kho as k where hh.tenHangHoa = N'" + tenHH + "' and k.idHangHoa = hh.id");
                txtSoLuong.Text = Convert.ToString(data);
                data = DataProvider.Instance.executeScalar("Select ctpn.soLuongNhap * ctpn.donGiaNhap from  chiTietPhieuNhap as ctpn, hangHoa as hh where ctpn.idHangHoa = '" + idHH + "'");
                lblThanhTien.Text = Convert.ToString(data);
                txtSoLuong.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
                txtDonGia.Text = dgvMain.Rows[i].Cells[4].Value.ToString();
                int soLuongNhap = Convert.ToInt32(txtSoLuong.Text.ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentRow.Index;

            getDongThuI(i);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setState("Adding");
            isAddNew = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setState("Editing");
            isEdit = true;
        }

        public void luuThem()
        {
            //  if (error() == true)
            {
                string query = @"INSERT INTO chiTietPhieuNhap VALUES ('" + lblSoHoaDon.Text + "','" + cboHangHoa.SelectedValue + "'," + txtSoLuong.Text.Trim() + "," + Convert.ToDecimal(txtDonGia.Text) + ")";
                var result = DataProvider.Instance.executeNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loadLenLuoi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
        }
        public string id()
        {
            string id = cboHangHoa.SelectedValue.ToString();
            return id;
        }
        public object idnhap()
        {

            object idnhap = DataProvider.Instance.executeScalar("Select idNhap from chiTietPhieuNhap where idHangHoa = '" + id() + "'");
            return idnhap;
        }
        public void luuSua()
        {
            //if (error() == true)
            {
                int i = dgvMain.CurrentRow.Index;
                string query = @"update chiTietPhieuNhap set idSoPhieuNhap = '" + lblSoHoaDon.Text + @"', idHangHoa = '" + id() + @"', soLuongNhap = " + txtSoLuong.Text + @", donGiaNhap = " + Convert.ToDecimal(txtDonGia.Text) + @" where (idNhap = '" + dgvMain.Rows[i].Cells[0].Value.ToString() + @"')";

                //string query = @"update chiTietPhieuNhap set idHangHoa = N'" + cboHangHoa.SelectedValue + @"', soLuongNhap = N'" + txtSoLuong.Text + @"', donGiaNhap = N'" + Convert.ToDecimal(txtDonGia.Text) + @"' where (idHangHoa = '" + cboHangHoa.SelectedValue + @"')";
                int result = DataProvider.Instance.executeNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loadLenLuoi();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (error() == false)
            {
                error();
            }
            else
            {
                if (isAddNew)
                {
                    luuThem();
                    isAddNew = false;
                }

                else
                {
                    if (isEdit)
                    {
                        luuSua();
                        isEdit = false;
                    }
                }
            }
            setState("Reset");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setState("Reset");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.SelectedRows.Count == -1)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu muốn Xóa !");
                    return;
                }
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)

                {
                    string query = "delete from chiTietPhieuNhap where idHangHoa = '" + cboHangHoa.SelectedValue + "'";
                    int kt = DataProvider.Instance.executeNonQuery(query);

                    if (kt > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        //  setState("Reset");
                        loadLenLuoi();
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
