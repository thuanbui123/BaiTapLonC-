using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using quanLyKho.DAO;

namespace quanLyKho
{
    public partial class frm_InBCTK_NhapKho : Form
    {
        public frm_InBCTK_NhapKho()
        {
            InitializeComponent();
        }

        private void frm_InBCTK_NhapKho_Load(object sender, EventArgs e)
        {
            string query = "Select ncc.tenNhaCungCap, hh.tenHangHoa, hh.donViTinh, ctpn.soLuongNhap, ctpn.donGiaNhap, pn.ngayLap_Nhap, pn.soPhieuNhap" +
              " from hangHoa as hh, chiTietPhieuNhap as ctpn, phieuNhap as pn, nhaCungCap as ncc" +
              " Where ncc.id = pn.idNhaCungCap and pn.soPhieuNhap = ctpn.idSoPhieuNhap and ctpn.idHangHoa = hh.id";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportNhapKho.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetNhapKho";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
