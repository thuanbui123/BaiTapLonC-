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
    public partial class frm_DM_IN : Form
    {
        public frm_DM_IN()
        {
            InitializeComponent();
        }

        private void frm_DM_IN_Load(object sender, EventArgs e)
        {

            string query = "Select * from chiTietPhieuXuat ";


            DataTable dt = DataProvider.Instance.executeQuery(query);



            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.Report_ctpx.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
          
        }
    }
}
