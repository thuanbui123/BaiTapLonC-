using quanLyKho.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKho
{
    public partial class frm_DM_TaoHoaDonXuat : Form
    {
        public frm_DM_TaoHoaDonXuat()
        {
            InitializeComponent();
        }
        bool status;
        bool state = true;
        bool state1 = false;

        public void LoadData()
        {
            string query = "Select phieuXuat.soPhieuXuat,khachHang.tenKhachHang,phieuXuat.ngayLap_Xuat from phieuXuat, khachHang where phieuXuat.idKhachHang=khachHang.id ";

            DataTable data = DataProvider.Instance.executeQuery(query);
            if (data != null && data.Rows.Count > 0)
            {
                dgvDM_Main_DonXuat.DataSource = data;
            }
            else
            {
                dgvDM_Main_DonXuat.DataSource = null;
            }

            dinhDangLuoi();
        }
        private void dinhDangLuoi()
        {
            dgvDM_Main_DonXuat.Columns[0].HeaderText = "Số chứng từ xuất ";
            dgvDM_Main_DonXuat.Columns[0].Width = 130;
            dgvDM_Main_DonXuat.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvDM_Main_DonXuat.Columns[1].Width = 200;
            dgvDM_Main_DonXuat.Columns[2].HeaderText = "Ngày xuất";
            dgvDM_Main_DonXuat.Columns[2].Width = 250;
        }
        private bool error()
        {
            bool error = true;
            int sdt;
            if (txt_DM_SoHoaDon.Text == "")
            {
                errorProvider1.SetError(txt_DM_SoHoaDon, "Chưa điền số hóa đơn");
                error = false;
                txt_DM_SoHoaDon.Focus();
            }
            return error;
        }

        private void addCustomer()
        {
            try
            {
                string query = "insert into phieuXuat " + " values ( '" + txt_DM_SoHoaDon.Text.Trim() + "', '" + cbo_DM_KhachHang.SelectedValue.ToString() + "', '" + dtp_DM_NgayTaoHD.Value.ToString("yyyy-MM-dd") + "')";

                var result = DataProvider.Instance.executeNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Insert success");
                    state1 = true;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Insert error");
                    state1 = false;
                }
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadCombobox ()
        {
            string query = "Select id, tenKhachHang from khachHang";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            cbo_DM_KhachHang.DataSource = dt;
            cbo_DM_KhachHang.DisplayMember = "tenKhachHang";
            cbo_DM_KhachHang.ValueMember = "id";
        }

        private void editStudent()
        {
            try
            {
                string query = "update phieuXuat set  idkhachHang = N'" + cbo_DM_KhachHang.SelectedValue.ToString() + "', ngayLap_Xuat = '" + dtp_DM_NgayTaoHD.Value.ToString("yyyy-MM-dd") + "' where soPhieuXuat = '" + txt_DM_SoHoaDon.Text.Trim() + "'";


                var result = DataProvider.Instance.executeNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Update success");
                    LoadData();
                    state1 = true;
                }
                else
                {
                    MessageBox.Show("Update error");
                    state1 = false;
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_DM_TaoHoaDonXuat_Load(object sender, EventArgs e)
        {
            LoadData();
            loadCombobox();
            object id = DataProvider.Instance.executeScalar("Select id from khachHang where tenKhachHang = N'" + dgvDM_Main_DonXuat.Rows[0].Cells[1].Value.ToString() + "'");
            txt_DM_SoHoaDon.Text = dgvDM_Main_DonXuat.Rows[0].Cells[0].Value.ToString();
            cbo_DM_KhachHang.SelectedValue = id.ToString();
            dtp_DM_NgayTaoHD.Value = Convert.ToDateTime(dgvDM_Main_DonXuat.Rows[0].Cells[2].Value.ToString());
        }

        private void btn_DM_HuyDonXuat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txt_DM_SoHoaDon.Text = "";
            txt_DM_SoHoaDon.Enabled = false;
            cbo_DM_KhachHang.Enabled = false;
            btn_DM_ThemDonXuat.Enabled = true;
            status = true;
            btn_DM_SuaDonXuat.Enabled = true;
            btn_DM_XoaDonXuat.Enabled = true;
            btn_DM_HuyDonXuat.Enabled = false;
            btn_DM_XuatHoaDon.Enabled = true;
            btn_DM_LuuDonXuat.Enabled = false;
        }

        private void btn_DM_SuaDonXuat_Click(object sender, EventArgs e)
        {
            status = false;
            btn_DM_ThemDonXuat.Enabled = false;
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            txt_DM_SoHoaDon.Enabled = false;
            dtp_DM_NgayTaoHD.Enabled = true;
            cbo_DM_KhachHang.Enabled = true;
            btn_DM_LuuDonXuat.Enabled = true;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_XuatHoaDon.Enabled = false;
        }

        private void dgvDM_Main_DonXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvDM_Main_DonXuat.CurrentCell.RowIndex;
            if (i >= 0)
            {
                txt_DM_SoHoaDon.Text = dgvDM_Main_DonXuat.Rows[i].Cells[0].Value.ToString();
                GlobalDataChiTietHoaDonXuat.soHoaDon = dgvDM_Main_DonXuat.Rows[i].Cells[0].Value.ToString();
                object id = DataProvider.Instance.executeScalar("Select id from khachHang where tenKhachHang = N'" + dgvDM_Main_DonXuat.Rows[i].Cells[1].Value.ToString() + "'");
                cbo_DM_KhachHang.SelectedValue = id.ToString();
                GlobalDataChiTietHoaDonXuat.tenKhachHang = dgvDM_Main_DonXuat.Rows[i].Cells[1].Value.ToString();
                dtp_DM_NgayTaoHD.Value = Convert.ToDateTime(dgvDM_Main_DonXuat.Rows[i].Cells[2].Value.ToString());
                GlobalDataChiTietHoaDonXuat.NgayLapHD = dgvDM_Main_DonXuat.Rows[i].Cells[2].Value.ToString();
                object sdt = DataProvider.Instance.executeScalar("Select soDienThoai from khachHang where tenKhachHang = N'" + dgvDM_Main_DonXuat.Rows[i].Cells[1].Value.ToString() + "'");
                GlobalDataChiTietHoaDonXuat.soDienThoai = sdt.ToString();
                object diaChi = DataProvider.Instance.executeScalar("Select DiaChi from khachHang where tenKhachHang = N'" + dgvDM_Main_DonXuat.Rows[0].Cells[1].Value.ToString() + "'");
                GlobalDataChiTietHoaDonXuat.diaChi = diaChi.ToString();
            }
        }

        private void btn_DM_LuuDonXuat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (error() == false)
            {
                error();
            }
            else
            {
                if (status == true)
                {
                    addCustomer();
                    if (state1)
                    {
                        btn_DM_LuuDonXuat.Enabled = false;
                        btn_DM_HuyDonXuat.Enabled = false;
                        btn_DM_XuatHoaDon.Enabled = true;
                        btn_DM_ThemDonXuat.Enabled = true;
                        btn_DM_SuaDonXuat.Enabled = true;
                        btn_DM_XoaDonXuat.Enabled = true;
                        txt_DM_SoHoaDon.Enabled = false;
                        cbo_DM_KhachHang.Enabled = false;
                    }
                    else
                    {
                        btn_DM_LuuDonXuat.Enabled = true;
                        btn_DM_HuyDonXuat.Enabled = true;
                        btn_DM_XuatHoaDon.Enabled = true;
                        btn_DM_ThemDonXuat.Enabled = false;
                        btn_DM_SuaDonXuat.Enabled = false;
                        btn_DM_XoaDonXuat.Enabled = false;
                        txt_DM_SoHoaDon.Enabled = true;
                        cbo_DM_KhachHang.Enabled = true;
                    }
                }
                else
                {
                    editStudent();
                    if (state1 == true)
                    {
                        btn_DM_LuuDonXuat.Enabled = false;
                        btn_DM_HuyDonXuat.Enabled = false;
                        btn_DM_XuatHoaDon.Enabled = false;
                        btn_DM_ThemDonXuat.Enabled = true;
                        btn_DM_SuaDonXuat.Enabled = true;
                        btn_DM_XoaDonXuat.Enabled = true;
                        txt_DM_SoHoaDon.Enabled = false;
                        cbo_DM_KhachHang.Enabled = false;
                    }
                    else
                    {
                        btn_DM_XuatHoaDon.Enabled = true;
                        btn_DM_LuuDonXuat.Enabled = true;
                        btn_DM_HuyDonXuat.Enabled = true;
                        btn_DM_ThemDonXuat.Enabled = false;
                        btn_DM_SuaDonXuat.Enabled = false;
                        btn_DM_XoaDonXuat.Enabled = false;
                        txt_DM_SoHoaDon.Enabled = false;
                        cbo_DM_KhachHang.Enabled = false;
                    }
                }
            }
        }

        private void btn_DM_ThemDonXuat_Click(object sender, EventArgs e)
        {
            status = true;
            btn_DM_ThemDonXuat.Enabled = false;
            txt_DM_SoHoaDon.Focus();
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_LuuDonXuat.Enabled = true;
            btn_DM_XuatHoaDon.Enabled = false;
            txt_DM_SoHoaDon.Enabled = true;
            cbo_DM_KhachHang.Enabled = true;
            dtp_DM_NgayTaoHD.Enabled = true;
            txt_DM_SoHoaDon.Text = "";
        }

        private void btn_DM_XoaDonXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete from phieuXuat where soPhieuXuat = '" + txt_DM_SoHoaDon.Text + "'";

                    var result = DataProvider.Instance.executeNonQuery(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Delete success");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_DM_XuatHoaDon_Click(object sender, EventArgs e)
        {
            frm_DM_ChiTietHoaDonXuat f = new frm_DM_ChiTietHoaDonXuat();
            
            f.ShowDialog();
          
        }
    }
}
