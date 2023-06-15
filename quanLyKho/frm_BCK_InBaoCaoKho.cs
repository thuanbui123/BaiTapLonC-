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
    public partial class frm_BCK_InBaoCaoKho : Form
    {
        public frm_BCK_InBaoCaoKho()
        {
            InitializeComponent();
        }

        private void frm_BCK_InBaoCaoKho_Load(object sender, EventArgs e)
        {
            string query = "SELECT hangHoa.id,hangHoa.tenHangHoa,hangHoa.donViTinh,kho.soLuong FROM hangHoa,kho WHERE hangHoa.id = kho.idHangHoa";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportKho.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);




            this.reportViewer1.RefreshReport();
        }
    }
}
