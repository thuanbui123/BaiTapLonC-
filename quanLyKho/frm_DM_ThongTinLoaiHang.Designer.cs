
namespace quanLyKho
{
    partial class frm_DM_ThongTinLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DM_ThongTinLoaiHang));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdoTimKiemTheoMa = new System.Windows.Forms.RadioButton();
            this.rdoTimKiemTheoTen = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grbTrangThai = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDienGiai = new System.Windows.Forms.Label();
            this.lblTenLoaiHang = new System.Windows.Forms.Label();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.lblThongTinLoaiHang = new System.Windows.Forms.Label();
            this.grbCapNhatLoaiHang = new System.Windows.Forms.GroupBox();
            this.lblMaloaiHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbTrangThai.SuspendLayout();
            this.grbCapNhatLoaiHang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rdoTimKiemTheoMa
            // 
            this.rdoTimKiemTheoMa.AutoSize = true;
            this.rdoTimKiemTheoMa.Location = new System.Drawing.Point(694, 29);
            this.rdoTimKiemTheoMa.Name = "rdoTimKiemTheoMa";
            this.rdoTimKiemTheoMa.Size = new System.Drawing.Size(80, 23);
            this.rdoTimKiemTheoMa.TabIndex = 8;
            this.rdoTimKiemTheoMa.TabStop = true;
            this.rdoTimKiemTheoMa.Text = "Theo mã";
            this.rdoTimKiemTheoMa.UseVisualStyleBackColor = true;
            // 
            // rdoTimKiemTheoTen
            // 
            this.rdoTimKiemTheoTen.AutoSize = true;
            this.rdoTimKiemTheoTen.Location = new System.Drawing.Point(547, 30);
            this.rdoTimKiemTheoTen.Name = "rdoTimKiemTheoTen";
            this.rdoTimKiemTheoTen.Size = new System.Drawing.Size(80, 23);
            this.rdoTimKiemTheoTen.TabIndex = 7;
            this.rdoTimKiemTheoTen.TabStop = true;
            this.rdoTimKiemTheoTen.Text = "Theo tên";
            this.rdoTimKiemTheoTen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(174, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(341, 26);
            this.txtTimKiem.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(7, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(146, 50);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(33, 431);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(877, 256);
            this.dgvMain.TabIndex = 7;
            this.dgvMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoTimKiemTheoMa);
            this.groupBox4.Controls.Add(this.rdoTimKiemTheoTen);
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Controls.Add(this.btnTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(33, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(877, 64);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // grbTrangThai
            // 
            this.grbTrangThai.Controls.Add(this.btnHuy);
            this.grbTrangThai.Controls.Add(this.btnLuu);
            this.grbTrangThai.Controls.Add(this.btnSua);
            this.grbTrangThai.Controls.Add(this.btnXoa);
            this.grbTrangThai.Controls.Add(this.btnThem);
            this.grbTrangThai.Location = new System.Drawing.Point(745, 12);
            this.grbTrangThai.Name = "grbTrangThai";
            this.grbTrangThai.Size = new System.Drawing.Size(165, 319);
            this.grbTrangThai.TabIndex = 5;
            this.grbTrangThai.TabStop = false;
            this.grbTrangThai.Text = "Trạng thái ";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(24, 253);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 50);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(24, 197);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 50);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(24, 85);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(24, 141);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(24, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.AutoSize = true;
            this.lblDienGiai.Location = new System.Drawing.Point(16, 167);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(61, 19);
            this.lblDienGiai.TabIndex = 2;
            this.lblDienGiai.Text = "Diễn giải";
            // 
            // lblTenLoaiHang
            // 
            this.lblTenLoaiHang.AutoSize = true;
            this.lblTenLoaiHang.Location = new System.Drawing.Point(16, 106);
            this.lblTenLoaiHang.Name = "lblTenLoaiHang";
            this.lblTenLoaiHang.Size = new System.Drawing.Size(93, 19);
            this.lblTenLoaiHang.TabIndex = 1;
            this.lblTenLoaiHang.Text = "Tên loại hàng ";
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(140, 159);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(368, 26);
            this.txtDienGiai.TabIndex = 5;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(140, 103);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(368, 26);
            this.txtTenLoaiHang.TabIndex = 4;
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(140, 46);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(368, 26);
            this.txtMaLoaiHang.TabIndex = 3;
            // 
            // lblThongTinLoaiHang
            // 
            this.lblThongTinLoaiHang.AutoSize = true;
            this.lblThongTinLoaiHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLoaiHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblThongTinLoaiHang.Location = new System.Drawing.Point(209, 27);
            this.lblThongTinLoaiHang.Name = "lblThongTinLoaiHang";
            this.lblThongTinLoaiHang.Size = new System.Drawing.Size(202, 25);
            this.lblThongTinLoaiHang.TabIndex = 1;
            this.lblThongTinLoaiHang.Text = "Thông tin loại hàng ";
            // 
            // grbCapNhatLoaiHang
            // 
            this.grbCapNhatLoaiHang.Controls.Add(this.txtDienGiai);
            this.grbCapNhatLoaiHang.Controls.Add(this.txtTenLoaiHang);
            this.grbCapNhatLoaiHang.Controls.Add(this.txtMaLoaiHang);
            this.grbCapNhatLoaiHang.Controls.Add(this.lblDienGiai);
            this.grbCapNhatLoaiHang.Controls.Add(this.lblTenLoaiHang);
            this.grbCapNhatLoaiHang.Controls.Add(this.lblMaloaiHang);
            this.grbCapNhatLoaiHang.Location = new System.Drawing.Point(7, 74);
            this.grbCapNhatLoaiHang.Name = "grbCapNhatLoaiHang";
            this.grbCapNhatLoaiHang.Size = new System.Drawing.Size(648, 223);
            this.grbCapNhatLoaiHang.TabIndex = 0;
            this.grbCapNhatLoaiHang.TabStop = false;
            this.grbCapNhatLoaiHang.Text = "Cập nhật loại hàng ";
            // 
            // lblMaloaiHang
            // 
            this.lblMaloaiHang.AutoSize = true;
            this.lblMaloaiHang.Location = new System.Drawing.Point(16, 46);
            this.lblMaloaiHang.Name = "lblMaloaiHang";
            this.lblMaloaiHang.Size = new System.Drawing.Size(87, 19);
            this.lblMaloaiHang.TabIndex = 0;
            this.lblMaloaiHang.Text = "Mã loại hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThongTinLoaiHang);
            this.groupBox1.Controls.Add(this.grbCapNhatLoaiHang);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(680, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // frm_DM_ThongTinLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(942, 699);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbTrangThai);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DM_ThongTinLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DM_ThongTinLoaiHang";
            this.Load += new System.EventHandler(this.frm_DM_ThongTinLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbTrangThai.ResumeLayout(false);
            this.grbCapNhatLoaiHang.ResumeLayout(false);
            this.grbCapNhatLoaiHang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoTimKiemTheoMa;
        private System.Windows.Forms.RadioButton rdoTimKiemTheoTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbTrangThai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThongTinLoaiHang;
        private System.Windows.Forms.GroupBox grbCapNhatLoaiHang;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Label lblDienGiai;
        private System.Windows.Forms.Label lblTenLoaiHang;
        private System.Windows.Forms.Label lblMaloaiHang;
    }
}