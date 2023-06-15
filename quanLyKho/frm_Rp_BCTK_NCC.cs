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
    public partial class frm_Rp_BCTK_NCC : Form
    {
        public frm_Rp_BCTK_NCC()
        {
            InitializeComponent();
        }

        private void frm_Rp_BCTK_NCC_Load(object sender, EventArgs e)
        {
            string query = "select * from nhaCungCap";
            DataTable data = DataProvider.Instance.executeQuery(query);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportBCTK_NCC.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = data;

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
