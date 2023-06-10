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
    public partial class frm_rp_BCTK_NCC : Form
    {
        string strCon = @"Data Source=DESKTOP-5NOB1SS\SQLEXPRESS;Initial Catalog=quanLyKho;Integrated Security=True";
        SqlConnection sqlCon = null;
        public frm_rp_BCTK_NCC()
        {
            InitializeComponent();
        }

        private void rp_BCTK_NCC_Load(object sender, EventArgs e)
        {
            string query = "select * from nhaCungCap";
            DataTable data = DataProvider.Instance.executeQuery(query);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportBCTK_NCC.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsBCTK_NCC";
            rds.Value = data;

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
