using Microsoft.Reporting.WinForms;
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
    public partial class frm_InChiTietPhieuNhap : Form
    {
        public frm_InChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_InChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            string query = "select ctpn.idnhap, pn.sophieunhap, hh.tenhanghoa, ctpn.soluongnhap, ctpn.dongianhap, hh.donvitinh, ctpn.soluongNhap * ctpn.donGiaNhap as thanhTien" +
              " from chitietphieunhap as ctpn, nhacungcap as ncc, hanghoa as hh, phieunhap as pn" +
              " where ctpn.idSoPhieuNhap = pn.soPhieuNhap and pn.idNhaCungCap = ncc.id and ctpn.idHangHoa = hh.id and pn.soPhieuNhap = '" + class_ChiTietHoaDonNhap.SelectedIdSoPhieuNhap + "'";
            //string query = "select soLuongNhap * donGiaNhap as thanhTien from chiTietPhieuNhap";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            this.rpvChiTietPhieuNhap.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportChiTietPhieuNhap.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            //rds.Name = "DataSetThanhTienCTPN";
            rds.Value = dt;
            this.rpvChiTietPhieuNhap.LocalReport.DataSources.Add(rds);
            this.rpvChiTietPhieuNhap.RefreshReport();
        }
    }
}
