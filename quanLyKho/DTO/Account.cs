using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyKho.DTO
{
    public class Account
    {
        private int id;
        private string tenDangNhap;
        private string tenNguoiDung;
        private string matKhau;

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public Account(int id, string tenDangNhap, string tenNguoiDung, string matKhau)
        {
            this.Id = id;
            this.TenDangNhap = tenDangNhap;
            this.TenNguoiDung = tenNguoiDung;
            this.MatKhau = matKhau;
        }

        public Account(DataRow row)
        {
            this.Id = (int)row["id"];
            var tenDangNhap = row["tenDangNhap"];
            this.TenDangNhap = (string)tenDangNhap;
            var tenNguoiDung = row["tenNguoiDung"];
            this.TenNguoiDung = (string)tenNguoiDung;
            var matKhau = row["matKhau"];
            this.MatKhau = (string)matKhau;
        }
    }
}
