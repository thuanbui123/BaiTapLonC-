using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKho
{
    public class GlobalDataChiTietHoaDonXuat
    {
        public static string soHoaDon;
        public static string tenKhachHang;
        public static string diaChi;
        public static string soDienThoai;
        private static string ngayLapHD;

        public static string NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public string SoHoaDon { get => soHoaDon; set => soHoaDon = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

    }
}
