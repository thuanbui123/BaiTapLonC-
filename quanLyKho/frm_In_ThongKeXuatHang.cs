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
    public partial class frm_In_ThongKeXuatHang : Form
    {
        public frm_In_ThongKeXuatHang()
        {
            InitializeComponent();
        }

        private void frm_In_ThongKeXuatHang_Load(object sender, EventArgs e)
        {
            string query = "Select hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat" +
                " from hangHoa as hh, chiTietPhieuXuat as ctpx, kho as k, phieuXuat as px" +
                " Where (k.idHangHoa = hh.id and ctpx.idKho = k.id and px.soPhieuXuat = ctpx.idPhieuXuat)";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportHangDaBan.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
