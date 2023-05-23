using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKho
{
    public class anHienMatKhau
    {
        private static anHienMatKhau instance;
        private int count = 0;

        public static anHienMatKhau Instance
        {
            get { if (instance == null) instance = new anHienMatKhau(); return instance; }
            set => instance = value;
        }

        public anHienMatKhau() { }

        public void anHoacHienMatKhau(TextBox txt, Button btn)
        {
            count++;
            if (count % 2 != 0)
            {
                txt.UseSystemPasswordChar = false;
                Bitmap bm = new Bitmap("E:\\Quản lý kho\\không được xem.png");
                btn.Image = bm;
            }
            else
            {
                txt.UseSystemPasswordChar = true;
                Bitmap bm = new Bitmap("E:\\Quản lý kho\\được xem.png");
                btn.Image = bm;
            }
        }
    }
}
