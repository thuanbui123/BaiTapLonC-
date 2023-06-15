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
    public partial class frm_DM_NCC : Form
    {
        public frm_DM_NCC()
        {
            InitializeComponent();
        }

        bool isAdd = false;
        bool isEdit = false;

        private void dinhDangLuoi()
        {
            dgv_DM_NCC.Columns[0].HeaderText = "Mã Nhà cung cấp";
            dgv_DM_NCC.Columns[0].Width = 150;
            dgv_DM_NCC.Columns[1].HeaderText = "Tên Nhà cung cấp";
            dgv_DM_NCC.Columns[1].Width = 170;
            dgv_DM_NCC.Columns[2].HeaderText = "Địa chỉ";
            dgv_DM_NCC.Columns[2].Width = 170;
            dgv_DM_NCC.Columns[3].HeaderText = "Số điện thoại";
            dgv_DM_NCC.Columns[3].Width = 150;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select ncc.id, ncc.tenNhaCungCap, ncc.diaChi, ncc.soDienThoai form nhaCungCap as ncc";
            DataTable data = DataProvider.Instance.executeQuery(query);
            if (data != null && data.Rows.Count > 0)
            {
                dgv_DM_NCC.DataSource = data;
            }
            else
            {
                dgv_DM_NCC.DataSource = null;
            }
            dinhDangLuoi();
        }

        private void setState(string state)
        {
            switch (state)
            {
                case "Reset":
                    btn_DM_NCC_Them.Enabled = true;
                    btn_DM_NCC_Sua.Enabled = true;
                    btn_DM_NCC_Xoa.Enabled = true;

                    btn_DM_NCC_Luu.Enabled = false;
                    btn_DM_NCC_Huy.Enabled = false;

                    txt_DM_MaNCC.Enabled = false;
                    txt_DM_NCC_DiaChi.Enabled = false;
                    txt_DM_TenNCC.Enabled = false;
                    txt_DM_NCC_DienThoai.Enabled = false;
                    break;
                case "Adding":
                    btn_DM_NCC_Them.Enabled = false;
                    btn_DM_NCC_Sua.Enabled = false;
                    btn_DM_NCC_Xoa.Enabled = false;

                    btn_DM_NCC_Luu.Enabled = true;
                    btn_DM_NCC_Huy.Enabled = true;

                    txt_DM_MaNCC.Enabled = true;
                    txt_DM_NCC_DiaChi.Enabled = true;
                    txt_DM_TenNCC.Enabled = true;
                    txt_DM_NCC_DienThoai.Enabled = true;

                    txt_DM_MaNCC.Text = "";
                    txt_DM_TenNCC.Text = "";
                    txt_DM_NCC_DiaChi.Text = "";
                    txt_DM_NCC_DienThoai.Text = "";

                    txt_DM_MaNCC.Focus();
                    break;
                case "Editing":
                    btn_DM_NCC_Them.Enabled = false;
                    btn_DM_NCC_Sua.Enabled = false;
                    btn_DM_NCC_Xoa.Enabled = false;

                    btn_DM_NCC_Luu.Enabled = true;
                    btn_DM_NCC_Huy.Enabled = true;

                    txt_DM_MaNCC.Enabled = true;
                    txt_DM_NCC_DiaChi.Enabled = true;
                    txt_DM_TenNCC.Enabled = true;
                    txt_DM_NCC_DienThoai.Enabled = true;

                    txt_DM_TenNCC.Focus();
                    break;
                default:
                    break;
            }
        }

        private void bindingData()
        {
            try
            {
                string query = "select ncc.id, ncc.tenNhaCungCap, ncc.diaChi, ncc.soDienThoai from nhaCungCap as ncc";

                DataTable data = DataProvider.Instance.executeQuery(query);

                dgv_DM_NCC.DataSource = data;

                txt_DM_MaNCC.Text = dgv_DM_NCC.Rows[0].Cells[0].Value.ToString();
                txt_DM_TenNCC.Text = dgv_DM_NCC.Rows[0].Cells[1].Value.ToString();
                txt_DM_NCC_DiaChi.Text = dgv_DM_NCC.Rows[0].Cells[2].Value.ToString();
                txt_DM_NCC_DienThoai.Text = dgv_DM_NCC.Rows[0].Cells[3].Value.ToString();

                dinhDangLuoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_DM_NCC_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }

        private void btn_DM_NCC_Them_Click(object sender, EventArgs e)
        {
            isAdd = true;
            setState("Adding");
        }

        private void frm_DM_NCC_Load_1(object sender, EventArgs e)
        {
            setState("Reset");
            bindingData();
        }

        private void btn_DM_NCC_Sua_Click(object sender, EventArgs e)
        {
            setState("Editing");
            isEdit = true;
        }

        private void btn_DM_NCC_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DM_NCC.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui long chon du lieu muon Xoa !");
                    return;
                }

                DialogResult kq = MessageBox.Show("Ban co thuc su muon Xoa khong?", "Hop Thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    string query = "delete from nhaCungCap where id = '" + txt_DM_MaNCC.Text.Trim() + "'";
                    int kt = DataProvider.Instance.executeNonQuery(query);

                    if (kt > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        setState("Reset");
                        bindingData();
                    }
                    else
                    {
                        MessageBox.Show("Xoa that bai");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isValidData()
        {
            bool stt = true;
            if (txt_DM_MaNCC.Text == "")
            {
                MessageBox.Show("Vui long nhap ma nha cung cap", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stt = false;
            }
            else if (txt_DM_TenNCC.Text == "")
            {
                MessageBox.Show("Vui long nhap ten nha cung cap", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stt = false;
            }
            else if (txt_DM_NCC_DiaChi.Text == "")
            {
                MessageBox.Show("Vui long nhap dia chi nha cung cap", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stt = false;
            }
            else if (txt_DM_NCC_DienThoai.Text == "")
            {
                MessageBox.Show("Vui long nhap dien thoai nha cung cap", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stt = false;
            }
            return stt;
        }

        private void btn_DM_NCC_Luu_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if (isAdd)
                {
                    try
                    {

                        string query = "insert into nhaCungCap values('" + txt_DM_MaNCC.Text.Trim() + "', N'" + txt_DM_TenNCC.Text.Trim() + "', N'" + txt_DM_NCC_DiaChi.Text.Trim() + "', '" + txt_DM_NCC_DienThoai.Text.Trim() + "')";

                        int kt = DataProvider.Instance.executeNonQuery(query);
                        if (kt > 0)
                        {
                            MessageBox.Show("Them thanh cong !");
                            setState("Reset");
                            bindingData();
                        }
                        else
                        {
                            MessageBox.Show("Them that bai !");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    isAdd = false;
                }
                if (isEdit)
                {
                    try
                    {

                        string query = "update nhaCungCap set tenNhaCungCap = N'" + txt_DM_TenNCC.Text.Trim() + "', diaChi = N'" + txt_DM_NCC_DiaChi.Text.Trim() + "', soDienThoai = '" + txt_DM_NCC_DienThoai.Text.Trim() + "' where id = '" + txt_DM_MaNCC.Text.Trim() + "'";

                        int kt = DataProvider.Instance.executeNonQuery(query);
                        if (kt > 0)
                        {
                            MessageBox.Show("Sua thanh cong !");
                            setState("Reset");
                            bindingData();
                        }
                        else
                        {
                            MessageBox.Show("Sua that bai !");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    isEdit = false;
                }
            }
        }

        private void btn_DM_NCC_Huy_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co thuc su muon Huy thao tac khong?", "Hop Thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                setState("Reset");
                bindingData();
            }
        }

        private void btn_DM_NCC_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdb_DM_NCC_TheoMa.Checked)
            {
                try
                {

                    string query = "select * from nhaCungCap where id like '%" + txt_DM_NCC_TimKiem.Text.Trim() + "%'";

                    DataTable data = DataProvider.Instance.executeQuery(query);

                    dgv_DM_NCC.DataSource = data;
                    txt_DM_MaNCC.Text = dgv_DM_NCC.Rows[0].Cells[0].Value.ToString();
                    txt_DM_TenNCC.Text = dgv_DM_NCC.Rows[0].Cells[1].Value.ToString();
                    txt_DM_NCC_DiaChi.Text = dgv_DM_NCC.Rows[0].Cells[2].Value.ToString();
                    txt_DM_NCC_DienThoai.Text = dgv_DM_NCC.Rows[0].Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (rdb_DM_NCC_TheoTen.Checked)
            {
                try
                {

                    string query = "select * from nhaCungCap where tenNhaCungCap like '%" + txt_DM_NCC_TimKiem.Text.Trim() + "%'";

                    DataTable data = DataProvider.Instance.executeQuery(query);

                    dgv_DM_NCC.DataSource = data;
                    txt_DM_MaNCC.Text = dgv_DM_NCC.Rows[0].Cells[0].Value.ToString();
                    txt_DM_TenNCC.Text = dgv_DM_NCC.Rows[0].Cells[1].Value.ToString();
                    txt_DM_NCC_DiaChi.Text = dgv_DM_NCC.Rows[0].Cells[2].Value.ToString();
                    txt_DM_NCC_DienThoai.Text = dgv_DM_NCC.Rows[0].Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_DM_NCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = dgv_DM_NCC.CurrentCell.RowIndex;
                if (i >= 0)
                {
                    txt_DM_MaNCC.Text = dgv_DM_NCC.Rows[i].Cells[0].Value.ToString();
                    txt_DM_TenNCC.Text = dgv_DM_NCC.Rows[i].Cells[1].Value.ToString();
                    txt_DM_NCC_DiaChi.Text = dgv_DM_NCC.Rows[i].Cells[2].Value.ToString();
                    txt_DM_NCC_DienThoai.Text = dgv_DM_NCC.Rows[i].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
