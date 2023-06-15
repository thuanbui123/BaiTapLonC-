using quanLyKho.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace quanLyKho
{
    public partial class frm_TopMatHangBanChay : Form
    {
        public frm_TopMatHangBanChay()
        {
            InitializeComponent();
        }

        private void theoThang()
        {
            chartHangBanChay.Series.Clear();
            chartHangBanChay.Titles.Clear();
            int month = DateTime.Now.Month;
            chartHangBanChay.Titles.Add("Top 3 mặt hàng bán chạy nhất tháng "+month+"");
            chartHangBanChay.ChartAreas[0].AxisX.Title = "Mặt hàng";
            chartHangBanChay.ChartAreas[0].AxisY.Title = "Tỷ lệ bán";
            DataTable data = new DataTable();

            string query = "select top(3) hh.tenhanghoa, CONVERT(float, sum(ctpx.soLuongXuat)) / CONVERT(float, sum (ctpn.soLuongNhap))*100 as tyLeXuat from hanghoa as hh, chitietphieuxuat as ctpx, chiTietPhieuNhap as ctpn, kho as k, phieuxuat as px, khachhang as kh  where hh.id = k.idhanghoa and k.id = ctpx.idkho and ctpn.idHangHoa = hh.id and ctpx.idphieuxuat = px.sophieuxuat and px.idkhachhang = kh.id and  (MONTH(px.ngayLap_Xuat) = '"+month+"'  )  group by ctpx.idKho, hh.tenHangHoa order by sum(ctpx.soluongxuat) desc";
            data = DataProvider.Instance.executeQuery(query);

            chartHangBanChay.DataSource = data;
            chartHangBanChay.Series.Add("Bán chạy");
            chartHangBanChay.Series["Bán chạy"].XValueMember = "tenHangHoa";
            chartHangBanChay.Series["Bán chạy"].YValueMembers = "tyLeXuat";
            chartHangBanChay.Series["Bán chạy"].ChartType = SeriesChartType.Column;
        }

        private void theoQuy ()
        {
            chartHangBanChay.Series.Clear();
            chartHangBanChay.Titles.Clear();
            int month = DateTime.Now.Month;
            int quy = 1;
            int thangBatDau = 1;
            int thangKetThuc = 3;
            if (month >= 1 && month <= 3)
            {
                quy = 1;
                thangBatDau = 1;
                thangKetThuc = 3;
            } else if (month >= 4 && month <= 6)
            {
                quy = 2;
                thangBatDau = 4;
                thangKetThuc = 6;
            }
            else if (month >= 7 && month <= 9)
            {
                quy = 3;
                thangBatDau = 7;
                thangKetThuc = 9;
            }
            else if (month >= 10 && month <= 12)
            {
                quy = 4;
                thangBatDau = 10;
                thangKetThuc = 12;
            }
            chartHangBanChay.Titles.Add("Top 3 mặt hàng bán chạy nhất quý " + quy + "");
            chartHangBanChay.ChartAreas[0].AxisX.Title = "Mặt hàng";
            chartHangBanChay.ChartAreas[0].AxisY.Title = "Tỷ lệ bán";
            DataTable data = new DataTable();

            string query = "select top(3) hh.tenhanghoa, CONVERT(float, sum(ctpx.soLuongXuat)) / CONVERT(float, sum (ctpn.soLuongNhap))*100 as tyLeXuat from hanghoa as hh, chitietphieuxuat as ctpx, chiTietPhieuNhap as ctpn, kho as k, phieuxuat as px, khachhang as kh  where hh.id = k.idhanghoa and k.id = ctpx.idkho and ctpn.idHangHoa = hh.id and ctpx.idphieuxuat = px.sophieuxuat and px.idkhachhang = kh.id and  (MONTH(px.ngayLap_Xuat) >= '" + thangBatDau + "' And MONTH(px.ngayLap_Xuat) <= '"+thangKetThuc+"')  group by ctpx.idKho, hh.tenHangHoa order by sum(ctpx.soluongxuat) desc";
            data = DataProvider.Instance.executeQuery(query);

            chartHangBanChay.DataSource = data;
            chartHangBanChay.Series.Add("Bán chạy");
            chartHangBanChay.Series["Bán chạy"].XValueMember = "tenHangHoa";
            chartHangBanChay.Series["Bán chạy"].YValueMembers = "tyLeXuat";
            chartHangBanChay.Series["Bán chạy"].ChartType = SeriesChartType.Column;
        }

        private void theoNam ()
        {
            chartHangBanChay.Series.Clear();
            chartHangBanChay.Titles.Clear();
            int year = DateTime.Now.Year;
            chartHangBanChay.Titles.Add("Top 3 mặt hàng bán chạy nhất năm " + year + "");
            chartHangBanChay.ChartAreas[0].AxisX.Title = "Mặt hàng";
            chartHangBanChay.ChartAreas[0].AxisY.Title = "Tỷ lệ bán";
            DataTable data = new DataTable();

            string query = "select top(3) hh.tenhanghoa, CONVERT(float, sum(ctpx.soLuongXuat)) / CONVERT(float, sum (ctpn.soLuongNhap))*100 as tyLeXuat from hanghoa as hh, chitietphieuxuat as ctpx, chiTietPhieuNhap as ctpn, kho as k, phieuxuat as px, khachhang as kh  where hh.id = k.idhanghoa and k.id = ctpx.idkho and ctpn.idHangHoa = hh.id and ctpx.idphieuxuat = px.sophieuxuat and px.idkhachhang = kh.id and  (Year(px.ngayLap_Xuat) = '" + year + "'  )  group by ctpx.idKho, hh.tenHangHoa order by sum(ctpx.soluongxuat) desc";
            data = DataProvider.Instance.executeQuery(query);

            chartHangBanChay.DataSource = data;
            chartHangBanChay.Series.Add("Bán chạy");
            chartHangBanChay.Series["Bán chạy"].XValueMember = "tenHangHoa";
            chartHangBanChay.Series["Bán chạy"].YValueMembers = "tyLeXuat";
            chartHangBanChay.Series["Bán chạy"].ChartType = SeriesChartType.Column;
        }

        private void frm_TopMatHangBanChay_Load(object sender, EventArgs e)
        {
            theoThang();
        }

        private void rdoTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            theoThang();
        }

        private void rdoTheoQuy_CheckedChanged(object sender, EventArgs e)
        {
            theoQuy();
        }

        private void rdoTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            theoNam();
        }
    }
}
