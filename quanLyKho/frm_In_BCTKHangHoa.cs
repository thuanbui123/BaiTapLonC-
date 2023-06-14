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
    public partial class frm_In_BCTKHangHoa : Form
    {
        public frm_In_BCTKHangHoa()
        {
            InitializeComponent();
        }

        private void frm_In_BCTKHangHoa_Load(object sender, EventArgs e)
        {
            string query = "Select hh.id, hh.tenHangHoa, hh.donViTinh, lh.tenLoai, hh.xuatXu from hangHoa as hh, loaiHang as lh where hh.idLoaiHang = lh.id";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportHangHoa.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
