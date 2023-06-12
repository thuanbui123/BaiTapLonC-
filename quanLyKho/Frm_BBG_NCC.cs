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
    public partial class Frm_BBG_NCC : Form
    {
        public Frm_BBG_NCC()
        {
            InitializeComponent();
        }
        private void dinhDangLuoi()
        {
            dgv_BangThongTin.Columns[0].HeaderText = "Mã NCC ";
            dgv_BangThongTin.Columns[0].Width = 130;
            dgv_BangThongTin.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgv_BangThongTin.Columns[1].Width = 200;
            dgv_BangThongTin.Columns[2].HeaderText = "Mã hàng hóa";
            dgv_BangThongTin.Columns[2].Width = 130;
            dgv_BangThongTin.Columns[3].HeaderText = "Tên hàng hóa";
            dgv_BangThongTin.Columns[3].Width = 200;
            dgv_BangThongTin.Columns[4].HeaderText = "Đơn vị tính";
            dgv_BangThongTin.Columns[4].Width = 130;
            dgv_BangThongTin.Columns[5].HeaderText = "Đơn giá nhập";
            dgv_BangThongTin.Columns[5].Width = 200;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "Select ncc.id,ncc.tenNhaCungCap,hh.id,hh.tenHangHoa,hh.donViTinh,ctpn.donGiaNhap from phieuNhap as pn, chiTietPhieuNhap as ctpn, hangHoa as hh ,nhaCungCap as ncc where ncc.id=pn.idNhaCungCap and ctpn.idSoPhieuNhap = pn.soPhieuNhap and ctpn.idHangHoa = hh.id ";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgv_BangThongTin.DataSource = data;
            dinhDangLuoi();
        }



        private void load_cbo_HangHoa()
        {
            try
            {
                string query = "Select id, tenNhaCungCap from nhaCungCap";
                DataTable dt = DataProvider.Instance.executeQuery(query);
                DataTable data = DataProvider.Instance.executeQuery(query);
                DataRow row = data.NewRow();
                row["tenNhaCungCap"] = "Chọn loại hàng hóa";
                data.Rows.InsertAt(row, 0);
                cbo_NCC.DataSource = dt;
                cbo_NCC.DisplayMember = "tenNhaCungCap";
                cbo_NCC.ValueMember = "id";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboBCK_LoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            int viTri = cbo_NCC.SelectedIndex;
            string layGiaTri = cbo_NCC.Text;

            if (viTri != 0)
            {
                string query = "Select ncc.id,ncc.tenNhaCungCap,hh.id,hh.tenHangHoa,hh.donViTinh,ctpn.donGiaNhap from phieuNhap as pn, chiTietPhieuNhap as ctpn, hangHoa as hh ,nhaCungCap as ncc where ncc.id=pn.idNhaCungCap and ctpn.idSoPhieuNhap = pn.soPhieuNhap and ctpn.idHangHoa = hh.id and ncc.tenNhaCungCap = N'" + layGiaTri + "'";
                DataTable data = DataProvider.Instance.executeQuery(query);
                dgv_BangThongTin.DataSource = data;
                dinhDangLuoi();
            }
        }

       

      
        private void Frm_BBG_NCC_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            rdo_loaihang.Checked = true;
            load_cbo_HangHoa();
        }

        private void cbo_NCC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int viTri = cbo_NCC.SelectedIndex;
            string layGiaTri = cbo_NCC.Text;

            if (viTri != 0)
            {
                string query = "Select ncc.id,ncc.tenNhaCungCap,hh.id,hh.tenHangHoa,hh.donViTinh,ctpn.donGiaNhap from phieuNhap as pn, chiTietPhieuNhap as ctpn, hangHoa as hh ,nhaCungCap as ncc where ncc.id=pn.idNhaCungCap and ctpn.idSoPhieuNhap = pn.soPhieuNhap and ctpn.idHangHoa = hh.id and ncc.tenNhaCungCap = N'" + layGiaTri + "'";
                DataTable data = DataProvider.Instance.executeQuery(query);
                dgv_BangThongTin.DataSource = data;
                dinhDangLuoi();
            }
        }

      
    }

    }


