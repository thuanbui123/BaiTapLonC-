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
    public partial class Frm_IN_ThongKeKhachHang : Form
    {
        public Frm_IN_ThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void Frm_IN_ThongKeKhachHang_Load(object sender, EventArgs e)
        {

            string query = "Select * from khachHang ";


            DataTable dt = DataProvider.Instance.executeQuery(query);



            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.Report_IN_ThongKeKhachHang.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet_IN_ThongKeKhachHang";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
           
            this.reportViewer1.RefreshReport();
            
        }
    }
}
