
namespace quanLyKho
{
    partial class frmThongTinTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTaiKhoan));
            this.lblThongTinTaiKhoan = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThongTinTaiKhoan
            // 
            this.lblThongTinTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThongTinTaiKhoan.Location = new System.Drawing.Point(12, 9);
            this.lblThongTinTaiKhoan.Name = "lblThongTinTaiKhoan";
            this.lblThongTinTaiKhoan.Size = new System.Drawing.Size(453, 29);
            this.lblThongTinTaiKhoan.TabIndex = 0;
            this.lblThongTinTaiKhoan.Text = "THÔNG TIN TÀI KHOẢN";
            this.lblThongTinTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(13, 61);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(98, 19);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(13, 118);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(103, 19);
            this.lblTenNguoiDung.TabIndex = 3;
            this.lblTenNguoiDung.Text = "Tên người dùng";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(13, 179);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(67, 19);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(176, 58);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(260, 26);
            this.txtTenDangNhap.TabIndex = 6;
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(176, 115);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.ReadOnly = true;
            this.txtTenNguoiDung.Size = new System.Drawing.Size(260, 26);
            this.txtTenNguoiDung.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(176, 176);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.Size = new System.Drawing.Size(260, 26);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnXem
            // 
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(442, 176);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(34, 27);
            this.btnXem.TabIndex = 11;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // frmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 233);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenNguoiDung);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblThongTinTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frmThongTinTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinTaiKhoan;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnXem;
    }
}