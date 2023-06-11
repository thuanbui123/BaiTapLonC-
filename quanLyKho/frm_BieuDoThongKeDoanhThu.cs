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
using System.Windows.Forms.DataVisualization.Charting;

namespace quanLyKho
{
    public partial class frm_BieuDoThongKeDoanhThu : Form
    {
        public frm_BieuDoThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void theoTuan()
        {
            // Xóa các series cũ trong chart
            chart_BieuDoDoanhThu.Series.Clear();
            chart_BieuDoDoanhThu.Titles.Clear();

            // Đặt tên cho chart
            chart_BieuDoDoanhThu.Titles.Add("Doanh thu theo tuần");

            // Đặt tên cho trục x, y
            chart_BieuDoDoanhThu.ChartAreas[0].AxisX.Title = "Tuần";
            chart_BieuDoDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";

            // setup câu truy vấn để lấy dữ liệu
            string query = "SELECT DATEPART(WEEK, px.NgayLap_Xuat) AS Tuan, SUM(ctpx.soLuongXuat * ctpx.donGiaXuat) AS DoanhThu " +
               "FROM phieuXuat as px join chiTietPhieuXuat as ctpx on px.soPhieuXuat = ctpx.idPhieuXuat " +
               "GROUP BY DATEPART(WEEK, px.NgayLap_Xuat)";
            DataTable data = DataProvider.Instance.executeQuery(query);
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "Tuan";
            series.YValueMembers = "DoanhThu";
            series.IsValueShownAsLabel = true;
            chart_BieuDoDoanhThu.Series.Add(series);
            // vẽ biểu đồ
            chart_BieuDoDoanhThu.DataSource = data;
            chart_BieuDoDoanhThu.DataBind();
            // sắp xếp database theo từng tuần
            DataView dv = data.DefaultView;
            dv.Sort = "Tuan ASC";
            data = dv.ToTable();
            chart_BieuDoDoanhThu.DataBind();
        }
        private void theoThang()
        {
            chart_BieuDoDoanhThu.Series.Clear();
            chart_BieuDoDoanhThu.Titles.Clear();
            chart_BieuDoDoanhThu.Titles.Add("Doanh thu theo tháng");
            chart_BieuDoDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
            chart_BieuDoDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            string query = "select month(px.ngayLap_Xuat) as Thang, sum(ctpx.soLuongXuat * ctpx.donGiaXuat) as DoanhThu " +
                   "from phieuXuat as px join chiTietPhieuXuat as ctpx on px.soPhieuXuat = ctpx.idPhieuXuat " +
                   "group by month(px.ngayLap_Xuat)";
            DataTable data = DataProvider.Instance.executeQuery(query);
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "Thang";
            series.YValueMembers = "DoanhThu";
            series.IsValueShownAsLabel = true;
            chart_BieuDoDoanhThu.Series.Add(series);
            // vẽ biểu đồ
            chart_BieuDoDoanhThu.DataSource = data;
            chart_BieuDoDoanhThu.DataBind();
        }
        private void theoQuy()
        {
            // Xóa các series cũ trong chart
            chart_BieuDoDoanhThu.Series.Clear();
            chart_BieuDoDoanhThu.Titles.Clear();
            // Đặt tiêu đề cho biểu đồ
            chart_BieuDoDoanhThu.Titles.Add("Doanh thu theo quý");

            // Đặt tên cho trục x và trục y
            chart_BieuDoDoanhThu.ChartAreas[0].AxisX.Title = "Quý";
            chart_BieuDoDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";



            // Set up câu truy vấn SQL để lấy dữ liệu
            string query = "SELECT CONCAT(YEAR(px.ngayLap_Xuat), 'Q', (MONTH(px.ngayLap_Xuat) - 1) / 3 + 1) AS Quarter, SUM(ctpx.soLuongXuat * ctpx.donGiaXuat) AS DoanhThu " +
                           "FROM phieuXuat as px, chiTietPhieuXuat as ctpx " +
                           "WHERE px.ngayLap_Xuat BETWEEN DATEADD(MONTH, -9, GETDATE()) AND GETDATE() " +
                           "GROUP BY CONCAT(YEAR(px.ngayLap_Xuat), 'Q', (MONTH(px.ngayLap_Xuat) - 1) / 3 + 1)";

            DataTable data = DataProvider.Instance.executeQuery(query);

            // Thêm các quý còn thiếu vào DataTable với giá trị doanh thu bằng 0
            DateTime now = DateTime.Now;
            int currentQuarter = (now.Month - 1) / 3 + 1;
            int currentYear = now.Year;
            for (int i = currentQuarter + 1; i <= 4; i++)
            {
                DataRow newRow = data.NewRow();
                newRow["Quarter"] = string.Format("{0}Q{1}", currentYear, i);
                newRow["DoanhThu"] = 0;
                data.Rows.Add(newRow);
            }

            // Sắp xếp lại DataTable theo thứ tự quý
            DataView dv = data.DefaultView;
            dv.Sort = "Quarter ASC";
            data = dv.ToTable();

            // Tạo series mới cho biểu đồ
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "Quarter";
            series.YValueMembers = "DoanhThu";
            series.IsValueShownAsLabel = true;
            chart_BieuDoDoanhThu.Series.Add(series);
            // vẽ biểu đồ
            chart_BieuDoDoanhThu.DataSource = data;
            chart_BieuDoDoanhThu.DataBind();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoTheoTuan.Checked == true)
            {

                theoTuan();

            }
            else
               if (rdoTheoThang.Checked == true)
            {

                theoThang();
            }
            else
               if (rdoTheoQuy.Checked == true)
            {

                theoQuy();
            }
        }

        private void chart_BieuDoDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click_1(object sender, EventArgs e)
        {

            if (rdoTheoTuan.Checked == true)
            {

                theoTuan();

            }
            else
               if (rdoTheoThang.Checked == true)
            {

                theoThang();
            }
            else
               if (rdoTheoQuy.Checked == true)
            {

                theoQuy();
            }
        }

        private void rdoTheoTuan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
