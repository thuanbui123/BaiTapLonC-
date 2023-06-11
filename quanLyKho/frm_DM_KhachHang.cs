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
    public partial class frm_DM_KhachHang : Form
    {
        public frm_DM_KhachHang()
        {
            InitializeComponent();
        }
        bool status, state;
        //bool kiemrtra = true;
        public void LoadData()
        {
            string query = "Select * from KhachHang";
            DataTable data = DataProvider.Instance.executeQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                dgvDM_Main_KhachHang.DataSource = data;
            }
            else
            {
                dgvDM_Main_KhachHang.DataSource = null;
            }

            dinhDangLuoi();
        }
        private bool error()
        {
            bool error = true;
            int sdt;

            if (txt_DM_MaKhachHang.Text == "")
            {
                errorProvider1.SetError(txt_DM_MaKhachHang, "Chưa điền mã khách hàng");
                //kiemrtra = false;
                error = false;

                txt_DM_MaKhachHang.Focus();
            }


            if (txt_DM_TenKhachHang.Text == "")
            {
                errorProvider1.SetError(txt_DM_TenKhachHang, "Tên khách hàng không được để trống");
                txt_DM_TenKhachHang.Focus();
                //kiemrtra = false;
                error = false;
            }


            if (txt_DM_DiaChi.Text == "")
            {
                errorProvider1.SetError(txt_DM_DiaChi, "Vui lòng nhập địa chỉ của bạn");
                txt_DM_DiaChi.Focus();
                //kiemrtra = false;
                error = false;
            }

            if (int.TryParse(txt_DM_DIenThoai.Text, out sdt) == false)
            {
                errorProvider1.SetError(txt_DM_DIenThoai, "Sai định dạng");
                txt_DM_DIenThoai.Focus();
                //kiemrtra = false;
                error = false;
            }
            return error;
        }
        private void addCustomer()
        {
            try
            {
                string query = "insert into KhachHang values ('" + txt_DM_MaKhachHang.Text.Trim() + "','" + txt_DM_TenKhachHang.Text.Trim() + "', N'" + txt_DM_DiaChi.Text.Trim() + "', N'" + txt_DM_DIenThoai.Text.Trim() + "')";
                var result = DataProvider.Instance.executeNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Insert success");
                    state = true;
                    LoadData();
                }
                else
                {
                    state = false;
                    MessageBox.Show("Insert error");
                }

                LoadData();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void editCustomer()
        {
            try
            {
                string query = "update KhachHang" + " set  tenkhachHang = N'" + txt_DM_TenKhachHang.Text.Trim() + "', diaChi = N'" + txt_DM_DiaChi.Text.Trim() + "', soDienThoai = " + txt_DM_DIenThoai.Text.Trim() + " where id = '" + txt_DM_MaKhachHang.Text.Trim() + "'";

                var result = DataProvider.Instance.executeNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Update success");
                    LoadData();
                    state = true;
                }
                else
                {
                    MessageBox.Show("Update error");
                    state = false;
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dinhDangLuoi()
        {
            dgvDM_Main_KhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvDM_Main_KhachHang.Columns[0].Width = 130;
            dgvDM_Main_KhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvDM_Main_KhachHang.Columns[1].Width = 200;
            dgvDM_Main_KhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvDM_Main_KhachHang.Columns[2].Width = 250;
            dgvDM_Main_KhachHang.Columns[3].HeaderText = "Điện Thoại";
            dgvDM_Main_KhachHang.Columns[3].Width = 150;
        }

        private void dgvDM_Main_KhachHang_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int sdt;
            int i = dgvDM_Main_KhachHang.CurrentCell.RowIndex;
            if (i >= 0)
            {
                txt_DM_MaKhachHang.Text = dgvDM_Main_KhachHang.Rows[i].Cells[0].Value.ToString();
                txt_DM_TenKhachHang.Text = dgvDM_Main_KhachHang.Rows[i].Cells[1].Value.ToString();
                txt_DM_DiaChi.Text = dgvDM_Main_KhachHang.Rows[i].Cells[2].Value.ToString();
                if (int.TryParse(dgvDM_Main_KhachHang.Rows[i].Cells[3].Value.ToString(), out sdt))
                {
                    txt_DM_DIenThoai.Text = sdt.ToString();

                }
            }
        }

        private void btn_DM_ThemKhachHang_Click_1(object sender, EventArgs e)
        {
            status = true;
            btn_DM_ThemKhachHang.Enabled = false;
            txt_DM_MaKhachHang.Focus();
            btn_DM_SuaKhachHang.Enabled = false;
            btn_DM_XoaKhachHang.Enabled = false;
            btn_DM_HuyKhachHang.Enabled = true;
            btn_DM_LuuKhachHang.Enabled = true;
            txt_DM_MaKhachHang.Enabled = true;
            txt_DM_TenKhachHang.Enabled = true;
            txt_DM_DiaChi.Enabled = true;
            txt_DM_DIenThoai.Enabled = true;
            txt_DM_MaKhachHang.Text = "";
            txt_DM_TenKhachHang.Text = "";
            txt_DM_DiaChi.Text = "";
            txt_DM_DIenThoai.Text = "";
        }

        private void btn_DM_SuaKhachHang_Click(object sender, EventArgs e)
        {
            status = false;
            btn_DM_ThemKhachHang.Enabled = false;
            btn_DM_SuaKhachHang.Enabled = false;
            btn_DM_XoaKhachHang.Enabled = false;
            txt_DM_MaKhachHang.Enabled = false;
            txt_DM_TenKhachHang.Focus();
            txt_DM_TenKhachHang.Enabled = true;
            txt_DM_DiaChi.Enabled = true;
            txt_DM_DIenThoai.Enabled = true;
            btn_DM_HuyKhachHang.Enabled = true;
            btn_DM_LuuKhachHang.Enabled = true;
        }

        private void btn_DM_XoaKhachHang_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete from KhachHang where id = '" + txt_DM_MaKhachHang.Text + "'";

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

        private void btn_DM_HuyKhachHang_Click(object sender, EventArgs e)
        {
            txt_DM_MaKhachHang.Text = "";
            txt_DM_TenKhachHang.Text = "";
            txt_DM_DiaChi.Text = "";
            txt_DM_DIenThoai.Text = "";
            btn_DM_ThemKhachHang.Enabled = true;
            status = true;
            btn_DM_SuaKhachHang.Enabled = true;
            btn_DM_XoaKhachHang.Enabled = true;
            btn_DM_HuyKhachHang.Enabled = false;
            btn_DM_LuuKhachHang.Enabled = false;
            txt_DM_TimKiem.Text = "";
            rdo_DM_TheoMa.Checked = false;
            rdo_DM_TheoTen.Checked = false;
        }

        private void btn_DM_LuuKhachHang_Click(object sender, EventArgs e)
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
                    btn_DM_LuuKhachHang.Enabled = false;
                    btn_DM_HuyKhachHang.Enabled = false;
                    if (state == false)
                    {
                        btn_DM_LuuKhachHang.Enabled = true;
                        btn_DM_HuyKhachHang.Enabled = true;
                        btn_DM_ThemKhachHang.Enabled = false;
                        btn_DM_SuaKhachHang.Enabled = false;
                        btn_DM_XoaKhachHang.Enabled = false;
                    }
                    else
                    {
                        btn_DM_LuuKhachHang.Enabled = false;
                        btn_DM_HuyKhachHang.Enabled = false;
                        btn_DM_ThemKhachHang.Enabled = true;
                        btn_DM_SuaKhachHang.Enabled = true;
                        btn_DM_XoaKhachHang.Enabled = true;
                    }
                }
                else
                {
                    editCustomer();


                    if (state == false)
                    {
                        btn_DM_LuuKhachHang.Enabled = true;
                        btn_DM_HuyKhachHang.Enabled = true;
                        btn_DM_ThemKhachHang.Enabled = false;
                        btn_DM_SuaKhachHang.Enabled = false;
                        btn_DM_XoaKhachHang.Enabled = false;
                    }
                    else
                    {
                        btn_DM_LuuKhachHang.Enabled = false;
                        btn_DM_HuyKhachHang.Enabled = false;
                        btn_DM_ThemKhachHang.Enabled = true;
                        btn_DM_SuaKhachHang.Enabled = true;
                        btn_DM_XoaKhachHang.Enabled = true;
                    }
                }


            }
        }

        private void frm_DM_KhachHang_Load(object sender, EventArgs e)
        {

            LoadData();
            int sdt;
            txt_DM_MaKhachHang.Text = dgvDM_Main_KhachHang.Rows[0].Cells[0].Value.ToString();
            txt_DM_TenKhachHang.Text = dgvDM_Main_KhachHang.Rows[0].Cells[1].Value.ToString();
            txt_DM_DiaChi.Text = dgvDM_Main_KhachHang.Rows[0].Cells[2].Value.ToString();
            if (int.TryParse(dgvDM_Main_KhachHang.Rows[0].Cells[3].Value.ToString(), out sdt))
            {
                txt_DM_DIenThoai.Text = sdt.ToString();

            }
        }

        private void txt_DM_TimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (rdo_DM_TheoMa.Checked == false && rdo_DM_TheoTen.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn tiêu chí tìm kiếm");
            }
            if (rdo_DM_TheoMa.Checked == true)
            {
                string rowFilter = string.Format("{0} like '{1}'", "id", "*" + txt_DM_TimKiem.Text + "*");
                (dgvDM_Main_KhachHang.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else if (rdo_DM_TheoTen.Checked == true)
            {
                string rowFilter = string.Format("{0} like '{1}'", "tenKhachHang", "*" + txt_DM_TimKiem.Text + "*");
                (dgvDM_Main_KhachHang.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }


    }
}
