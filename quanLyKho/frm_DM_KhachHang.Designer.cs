
namespace quanLyKho
{
    partial class frm_DM_KhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DM_KhachHang));
            this.dgvDM_Main_KhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DM_HuyKhachHang = new System.Windows.Forms.Button();
            this.btn_DM_LuuKhachHang = new System.Windows.Forms.Button();
            this.btn_DM_XoaKhachHang = new System.Windows.Forms.Button();
            this.btn_DM_SuaKhachHang = new System.Windows.Forms.Button();
            this.btn_DM_ThemKhachHang = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_DM_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_DM_TheoTen = new System.Windows.Forms.RadioButton();
            this.rdo_DM_TheoMa = new System.Windows.Forms.RadioButton();
            this.txt_DM_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_DM_DIenThoai = new System.Windows.Forms.TextBox();
            this.txt_DM_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_DM_TenKhachHang = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grb_DM_Cap_Nhat_Khach_Hang = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDM_Main_KhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grb_DM_Cap_Nhat_Khach_Hang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDM_Main_KhachHang
            // 
            this.dgvDM_Main_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDM_Main_KhachHang.Location = new System.Drawing.Point(66, 387);
            this.dgvDM_Main_KhachHang.Name = "dgvDM_Main_KhachHang";
            this.dgvDM_Main_KhachHang.Size = new System.Drawing.Size(790, 179);
            this.dgvDM_Main_KhachHang.TabIndex = 66;
            this.dgvDM_Main_KhachHang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDM_Main_KhachHang_CellMouseClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DM_HuyKhachHang);
            this.groupBox1.Controls.Add(this.btn_DM_LuuKhachHang);
            this.groupBox1.Controls.Add(this.btn_DM_XoaKhachHang);
            this.groupBox1.Controls.Add(this.btn_DM_SuaKhachHang);
            this.groupBox1.Controls.Add(this.btn_DM_ThemKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(695, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 339);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_DM_HuyKhachHang
            // 
            this.btn_DM_HuyKhachHang.Enabled = false;
            this.btn_DM_HuyKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_HuyKhachHang.Image")));
            this.btn_DM_HuyKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DM_HuyKhachHang.Location = new System.Drawing.Point(30, 236);
            this.btn_DM_HuyKhachHang.Name = "btn_DM_HuyKhachHang";
            this.btn_DM_HuyKhachHang.Size = new System.Drawing.Size(124, 39);
            this.btn_DM_HuyKhachHang.TabIndex = 58;
            this.btn_DM_HuyKhachHang.Text = "Hủy";
            this.btn_DM_HuyKhachHang.UseVisualStyleBackColor = true;
            this.btn_DM_HuyKhachHang.Click += new System.EventHandler(this.btn_DM_HuyKhachHang_Click);
            // 
            // btn_DM_LuuKhachHang
            // 
            this.btn_DM_LuuKhachHang.Enabled = false;
            this.btn_DM_LuuKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_LuuKhachHang.Image")));
            this.btn_DM_LuuKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DM_LuuKhachHang.Location = new System.Drawing.Point(30, 188);
            this.btn_DM_LuuKhachHang.Name = "btn_DM_LuuKhachHang";
            this.btn_DM_LuuKhachHang.Size = new System.Drawing.Size(124, 39);
            this.btn_DM_LuuKhachHang.TabIndex = 57;
            this.btn_DM_LuuKhachHang.Text = "Lưu";
            this.btn_DM_LuuKhachHang.UseVisualStyleBackColor = true;
            this.btn_DM_LuuKhachHang.Click += new System.EventHandler(this.btn_DM_LuuKhachHang_Click);
            // 
            // btn_DM_XoaKhachHang
            // 
            this.btn_DM_XoaKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_XoaKhachHang.Image")));
            this.btn_DM_XoaKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DM_XoaKhachHang.Location = new System.Drawing.Point(30, 136);
            this.btn_DM_XoaKhachHang.Name = "btn_DM_XoaKhachHang";
            this.btn_DM_XoaKhachHang.Size = new System.Drawing.Size(124, 39);
            this.btn_DM_XoaKhachHang.TabIndex = 56;
            this.btn_DM_XoaKhachHang.Text = "Xóa";
            this.btn_DM_XoaKhachHang.UseVisualStyleBackColor = true;
            this.btn_DM_XoaKhachHang.Click += new System.EventHandler(this.btn_DM_XoaKhachHang_Click);
            // 
            // btn_DM_SuaKhachHang
            // 
            this.btn_DM_SuaKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_SuaKhachHang.Image")));
            this.btn_DM_SuaKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DM_SuaKhachHang.Location = new System.Drawing.Point(30, 82);
            this.btn_DM_SuaKhachHang.Name = "btn_DM_SuaKhachHang";
            this.btn_DM_SuaKhachHang.Size = new System.Drawing.Size(124, 39);
            this.btn_DM_SuaKhachHang.TabIndex = 55;
            this.btn_DM_SuaKhachHang.Text = "Sửa";
            this.btn_DM_SuaKhachHang.UseVisualStyleBackColor = true;
            this.btn_DM_SuaKhachHang.Click += new System.EventHandler(this.btn_DM_SuaKhachHang_Click);
            // 
            // btn_DM_ThemKhachHang
            // 
            this.btn_DM_ThemKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DM_ThemKhachHang.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_DM_ThemKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_ThemKhachHang.Image")));
            this.btn_DM_ThemKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DM_ThemKhachHang.Location = new System.Drawing.Point(30, 26);
            this.btn_DM_ThemKhachHang.Name = "btn_DM_ThemKhachHang";
            this.btn_DM_ThemKhachHang.Size = new System.Drawing.Size(124, 45);
            this.btn_DM_ThemKhachHang.TabIndex = 54;
            this.btn_DM_ThemKhachHang.Text = "Thêm";
            this.btn_DM_ThemKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DM_ThemKhachHang.UseVisualStyleBackColor = true;
            this.btn_DM_ThemKhachHang.Click += new System.EventHandler(this.btn_DM_ThemKhachHang_Click_1);
            // 
            // txt_DM_MaKhachHang
            // 
            this.txt_DM_MaKhachHang.Enabled = false;
            this.txt_DM_MaKhachHang.Location = new System.Drawing.Point(150, 33);
            this.txt_DM_MaKhachHang.Name = "txt_DM_MaKhachHang";
            this.txt_DM_MaKhachHang.Size = new System.Drawing.Size(369, 26);
            this.txt_DM_MaKhachHang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.rdo_DM_TheoTen);
            this.groupBox3.Controls.Add(this.rdo_DM_TheoMa);
            this.groupBox3.Controls.Add(this.txt_DM_TimKiem);
            this.groupBox3.Location = new System.Drawing.Point(23, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 76);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 70;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rdo_DM_TheoTen
            // 
            this.rdo_DM_TheoTen.AutoSize = true;
            this.rdo_DM_TheoTen.Location = new System.Drawing.Point(530, 25);
            this.rdo_DM_TheoTen.Name = "rdo_DM_TheoTen";
            this.rdo_DM_TheoTen.Size = new System.Drawing.Size(85, 23);
            this.rdo_DM_TheoTen.TabIndex = 66;
            this.rdo_DM_TheoTen.TabStop = true;
            this.rdo_DM_TheoTen.Text = "Theo Tên";
            this.rdo_DM_TheoTen.UseVisualStyleBackColor = true;
            // 
            // rdo_DM_TheoMa
            // 
            this.rdo_DM_TheoMa.AutoSize = true;
            this.rdo_DM_TheoMa.Location = new System.Drawing.Point(432, 25);
            this.rdo_DM_TheoMa.Name = "rdo_DM_TheoMa";
            this.rdo_DM_TheoMa.Size = new System.Drawing.Size(83, 23);
            this.rdo_DM_TheoMa.TabIndex = 68;
            this.rdo_DM_TheoMa.TabStop = true;
            this.rdo_DM_TheoMa.Text = "Theo Mã";
            this.rdo_DM_TheoMa.UseVisualStyleBackColor = true;
            // 
            // txt_DM_TimKiem
            // 
            this.txt_DM_TimKiem.Location = new System.Drawing.Point(150, 22);
            this.txt_DM_TimKiem.Name = "txt_DM_TimKiem";
            this.txt_DM_TimKiem.Size = new System.Drawing.Size(259, 26);
            this.txt_DM_TimKiem.TabIndex = 67;
            this.txt_DM_TimKiem.TextChanged += new System.EventHandler(this.txt_DM_TimKiem_TextChanged_1);
            // 
            // txt_DM_DIenThoai
            // 
            this.txt_DM_DIenThoai.Enabled = false;
            this.txt_DM_DIenThoai.Location = new System.Drawing.Point(150, 129);
            this.txt_DM_DIenThoai.Name = "txt_DM_DIenThoai";
            this.txt_DM_DIenThoai.Size = new System.Drawing.Size(369, 26);
            this.txt_DM_DIenThoai.TabIndex = 9;
            // 
            // txt_DM_DiaChi
            // 
            this.txt_DM_DiaChi.Enabled = false;
            this.txt_DM_DiaChi.Location = new System.Drawing.Point(150, 95);
            this.txt_DM_DiaChi.Name = "txt_DM_DiaChi";
            this.txt_DM_DiaChi.Size = new System.Drawing.Size(369, 26);
            this.txt_DM_DiaChi.TabIndex = 8;
            // 
            // txt_DM_TenKhachHang
            // 
            this.txt_DM_TenKhachHang.Enabled = false;
            this.txt_DM_TenKhachHang.Location = new System.Drawing.Point(150, 64);
            this.txt_DM_TenKhachHang.Name = "txt_DM_TenKhachHang";
            this.txt_DM_TenKhachHang.Size = new System.Drawing.Size(369, 26);
            this.txt_DM_TenKhachHang.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(344, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label7.Location = new System.Drawing.Point(486, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 14);
            this.label7.TabIndex = 65;
            // 
            // grb_DM_Cap_Nhat_Khach_Hang
            // 
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.txt_DM_DIenThoai);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.txt_DM_DiaChi);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.txt_DM_TenKhachHang);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.txt_DM_MaKhachHang);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label2);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label5);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label4);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label3);
            this.grb_DM_Cap_Nhat_Khach_Hang.Location = new System.Drawing.Point(23, 52);
            this.grb_DM_Cap_Nhat_Khach_Hang.Name = "grb_DM_Cap_Nhat_Khach_Hang";
            this.grb_DM_Cap_Nhat_Khach_Hang.Size = new System.Drawing.Size(616, 186);
            this.grb_DM_Cap_Nhat_Khach_Hang.TabIndex = 60;
            this.grb_DM_Cap_Nhat_Khach_Hang.TabStop = false;
            this.grb_DM_Cap_Nhat_Khach_Hang.Text = "Cập nhật Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.grb_DM_Cap_Nhat_Khach_Hang);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 369);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // frm_DM_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(925, 578);
            this.Controls.Add(this.dgvDM_Main_KhachHang);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DM_KhachHang";
            this.Text = "frm_DM_KhachHang";
            this.Load += new System.EventHandler(this.frm_DM_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDM_Main_KhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grb_DM_Cap_Nhat_Khach_Hang.ResumeLayout(false);
            this.grb_DM_Cap_Nhat_Khach_Hang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDM_Main_KhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DM_HuyKhachHang;
        private System.Windows.Forms.Button btn_DM_LuuKhachHang;
        private System.Windows.Forms.Button btn_DM_XoaKhachHang;
        private System.Windows.Forms.Button btn_DM_SuaKhachHang;
        private System.Windows.Forms.Button btn_DM_ThemKhachHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_DM_MaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdo_DM_TheoTen;
        private System.Windows.Forms.RadioButton rdo_DM_TheoMa;
        private System.Windows.Forms.TextBox txt_DM_TimKiem;
        private System.Windows.Forms.TextBox txt_DM_DIenThoai;
        private System.Windows.Forms.TextBox txt_DM_DiaChi;
        private System.Windows.Forms.TextBox txt_DM_TenKhachHang;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grb_DM_Cap_Nhat_Khach_Hang;
    }
}