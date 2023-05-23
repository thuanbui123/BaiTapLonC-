
namespace quanLyKho
{
    partial class frm_DM_TaoHoaDonXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DM_TaoHoaDonXuat));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDM_Main_DonXuat = new System.Windows.Forms.DataGridView();
            this.btn_DM_XuatHoaDon = new System.Windows.Forms.Button();
            this.btn_DM_HuyDonXuat = new System.Windows.Forms.Button();
            this.btn_DM_LuuDonXuat = new System.Windows.Forms.Button();
            this.btn_DM_XoaDonXuat = new System.Windows.Forms.Button();
            this.btn_DM_SuaDonXuat = new System.Windows.Forms.Button();
            this.txt_DM_SoHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DM_ThemDonXuat = new System.Windows.Forms.Button();
            this.dtp_DM_NgayTaoHD = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grb_DM_Cap_Nhat_Khach_Hang = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_DM_KhachHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDM_Main_DonXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_DM_Cap_Nhat_Khach_Hang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(346, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "TẠO HÓA ĐƠN XUẤT ";
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
            // dgvDM_Main_DonXuat
            // 
            this.dgvDM_Main_DonXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDM_Main_DonXuat.Location = new System.Drawing.Point(47, 330);
            this.dgvDM_Main_DonXuat.Name = "dgvDM_Main_DonXuat";
            this.dgvDM_Main_DonXuat.Size = new System.Drawing.Size(861, 168);
            this.dgvDM_Main_DonXuat.TabIndex = 66;
            this.dgvDM_Main_DonXuat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDM_Main_DonXuat_CellMouseClick);
            // 
            // btn_DM_XuatHoaDon
            // 
            this.btn_DM_XuatHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DM_XuatHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DM_XuatHoaDon.Location = new System.Drawing.Point(30, 253);
            this.btn_DM_XuatHoaDon.Name = "btn_DM_XuatHoaDon";
            this.btn_DM_XuatHoaDon.Size = new System.Drawing.Size(137, 39);
            this.btn_DM_XuatHoaDon.TabIndex = 59;
            this.btn_DM_XuatHoaDon.Text = "Xuất hóa đơn";
            this.btn_DM_XuatHoaDon.UseVisualStyleBackColor = true;
            this.btn_DM_XuatHoaDon.Click += new System.EventHandler(this.btn_DM_XuatHoaDon_Click);
            // 
            // btn_DM_HuyDonXuat
            // 
            this.btn_DM_HuyDonXuat.Enabled = false;
            this.btn_DM_HuyDonXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_HuyDonXuat.Image")));
            this.btn_DM_HuyDonXuat.Location = new System.Drawing.Point(30, 208);
            this.btn_DM_HuyDonXuat.Name = "btn_DM_HuyDonXuat";
            this.btn_DM_HuyDonXuat.Size = new System.Drawing.Size(137, 39);
            this.btn_DM_HuyDonXuat.TabIndex = 58;
            this.btn_DM_HuyDonXuat.Text = "Hủy";
            this.btn_DM_HuyDonXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DM_HuyDonXuat.UseVisualStyleBackColor = true;
            this.btn_DM_HuyDonXuat.Click += new System.EventHandler(this.btn_DM_HuyDonXuat_Click);
            // 
            // btn_DM_LuuDonXuat
            // 
            this.btn_DM_LuuDonXuat.Enabled = false;
            this.btn_DM_LuuDonXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_LuuDonXuat.Image")));
            this.btn_DM_LuuDonXuat.Location = new System.Drawing.Point(30, 160);
            this.btn_DM_LuuDonXuat.Name = "btn_DM_LuuDonXuat";
            this.btn_DM_LuuDonXuat.Size = new System.Drawing.Size(137, 45);
            this.btn_DM_LuuDonXuat.TabIndex = 57;
            this.btn_DM_LuuDonXuat.Text = "Lưu";
            this.btn_DM_LuuDonXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DM_LuuDonXuat.UseVisualStyleBackColor = true;
            this.btn_DM_LuuDonXuat.Click += new System.EventHandler(this.btn_DM_LuuDonXuat_Click);
            // 
            // btn_DM_XoaDonXuat
            // 
            this.btn_DM_XoaDonXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_XoaDonXuat.Image")));
            this.btn_DM_XoaDonXuat.Location = new System.Drawing.Point(30, 112);
            this.btn_DM_XoaDonXuat.Name = "btn_DM_XoaDonXuat";
            this.btn_DM_XoaDonXuat.Size = new System.Drawing.Size(137, 45);
            this.btn_DM_XoaDonXuat.TabIndex = 56;
            this.btn_DM_XoaDonXuat.Text = "Xóa";
            this.btn_DM_XoaDonXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DM_XoaDonXuat.UseVisualStyleBackColor = true;
            this.btn_DM_XoaDonXuat.Click += new System.EventHandler(this.btn_DM_XoaDonXuat_Click);
            // 
            // btn_DM_SuaDonXuat
            // 
            this.btn_DM_SuaDonXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_SuaDonXuat.Image")));
            this.btn_DM_SuaDonXuat.Location = new System.Drawing.Point(30, 70);
            this.btn_DM_SuaDonXuat.Name = "btn_DM_SuaDonXuat";
            this.btn_DM_SuaDonXuat.Size = new System.Drawing.Size(137, 42);
            this.btn_DM_SuaDonXuat.TabIndex = 55;
            this.btn_DM_SuaDonXuat.Text = "Sửa";
            this.btn_DM_SuaDonXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DM_SuaDonXuat.UseVisualStyleBackColor = true;
            this.btn_DM_SuaDonXuat.Click += new System.EventHandler(this.btn_DM_SuaDonXuat_Click);
            // 
            // txt_DM_SoHoaDon
            // 
            this.txt_DM_SoHoaDon.Enabled = false;
            this.txt_DM_SoHoaDon.Location = new System.Drawing.Point(150, 44);
            this.txt_DM_SoHoaDon.Name = "txt_DM_SoHoaDon";
            this.txt_DM_SoHoaDon.Size = new System.Drawing.Size(346, 26);
            this.txt_DM_SoHoaDon.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn ";
            // 
            // btn_DM_ThemDonXuat
            // 
            this.btn_DM_ThemDonXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DM_ThemDonXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DM_ThemDonXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_ThemDonXuat.Image")));
            this.btn_DM_ThemDonXuat.Location = new System.Drawing.Point(30, 23);
            this.btn_DM_ThemDonXuat.Name = "btn_DM_ThemDonXuat";
            this.btn_DM_ThemDonXuat.Size = new System.Drawing.Size(137, 44);
            this.btn_DM_ThemDonXuat.TabIndex = 54;
            this.btn_DM_ThemDonXuat.Text = "Thêm";
            this.btn_DM_ThemDonXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DM_ThemDonXuat.UseVisualStyleBackColor = true;
            this.btn_DM_ThemDonXuat.Click += new System.EventHandler(this.btn_DM_ThemDonXuat_Click);
            // 
            // dtp_DM_NgayTaoHD
            // 
            this.dtp_DM_NgayTaoHD.Enabled = false;
            this.dtp_DM_NgayTaoHD.Location = new System.Drawing.Point(150, 153);
            this.dtp_DM_NgayTaoHD.Name = "dtp_DM_NgayTaoHD";
            this.dtp_DM_NgayTaoHD.Size = new System.Drawing.Size(346, 26);
            this.dtp_DM_NgayTaoHD.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DM_XuatHoaDon);
            this.groupBox1.Controls.Add(this.btn_DM_HuyDonXuat);
            this.groupBox1.Controls.Add(this.btn_DM_LuuDonXuat);
            this.groupBox1.Controls.Add(this.btn_DM_XoaDonXuat);
            this.groupBox1.Controls.Add(this.btn_DM_SuaDonXuat);
            this.groupBox1.Controls.Add(this.btn_DM_ThemDonXuat);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(867, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 332);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // grb_DM_Cap_Nhat_Khach_Hang
            // 
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.cbo_DM_KhachHang);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.dtp_DM_NgayTaoHD);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label5);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.txt_DM_SoHoaDon);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label2);
            this.grb_DM_Cap_Nhat_Khach_Hang.Controls.Add(this.label4);
            this.grb_DM_Cap_Nhat_Khach_Hang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DM_Cap_Nhat_Khach_Hang.Location = new System.Drawing.Point(57, 78);
            this.grb_DM_Cap_Nhat_Khach_Hang.Name = "grb_DM_Cap_Nhat_Khach_Hang";
            this.grb_DM_Cap_Nhat_Khach_Hang.Size = new System.Drawing.Size(745, 199);
            this.grb_DM_Cap_Nhat_Khach_Hang.TabIndex = 60;
            this.grb_DM_Cap_Nhat_Khach_Hang.TabStop = false;
            this.grb_DM_Cap_Nhat_Khach_Hang.Text = "Cập nhật Hóa Đơn Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày lập HĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.grb_DM_Cap_Nhat_Khach_Hang);
            this.groupBox2.Location = new System.Drawing.Point(47, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1074, 329);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // cbo_DM_KhachHang
            // 
            this.cbo_DM_KhachHang.Enabled = false;
            this.cbo_DM_KhachHang.FormattingEnabled = true;
            this.cbo_DM_KhachHang.Location = new System.Drawing.Point(150, 99);
            this.cbo_DM_KhachHang.Name = "cbo_DM_KhachHang";
            this.cbo_DM_KhachHang.Size = new System.Drawing.Size(346, 27);
            this.cbo_DM_KhachHang.TabIndex = 11;
            // 
            // frm_DM_TaoHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1168, 505);
            this.Controls.Add(this.dgvDM_Main_DonXuat);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DM_TaoHoaDonXuat";
            this.Text = "frm_DM_TaoHoaDonXuat";
            this.Load += new System.EventHandler(this.frm_DM_TaoHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDM_Main_DonXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grb_DM_Cap_Nhat_Khach_Hang.ResumeLayout(false);
            this.grb_DM_Cap_Nhat_Khach_Hang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvDM_Main_DonXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DM_XuatHoaDon;
        private System.Windows.Forms.Button btn_DM_HuyDonXuat;
        private System.Windows.Forms.Button btn_DM_LuuDonXuat;
        private System.Windows.Forms.Button btn_DM_XoaDonXuat;
        private System.Windows.Forms.Button btn_DM_SuaDonXuat;
        private System.Windows.Forms.Button btn_DM_ThemDonXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grb_DM_Cap_Nhat_Khach_Hang;
        private System.Windows.Forms.DateTimePicker dtp_DM_NgayTaoHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DM_SoHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbo_DM_KhachHang;
    }
}