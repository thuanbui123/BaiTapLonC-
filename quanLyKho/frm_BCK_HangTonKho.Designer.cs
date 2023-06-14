
namespace quanLyKho
{
    partial class frm_BCK_HangTonKho
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblChonTenLoaiHang = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.txtSoNgayLuuKho = new System.Windows.Forms.TextBox();
            this.lblSoNgayLuuKho = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoLoaiHang = new System.Windows.Forms.RadioButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblChonTenLoaiHang
            // 
            this.lblChonTenLoaiHang.AutoSize = true;
            this.lblChonTenLoaiHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTenLoaiHang.Location = new System.Drawing.Point(144, 16);
            this.lblChonTenLoaiHang.Name = "lblChonTenLoaiHang";
            this.lblChonTenLoaiHang.Size = new System.Drawing.Size(116, 16);
            this.lblChonTenLoaiHang.TabIndex = 15;
            this.lblChonTenLoaiHang.Text = "Chọn tên loại hàng:";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(502, 11);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(129, 72);
            this.btnThucHien.TabIndex = 14;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // txtSoNgayLuuKho
            // 
            this.txtSoNgayLuuKho.Location = new System.Drawing.Point(294, 61);
            this.txtSoNgayLuuKho.Multiline = true;
            this.txtSoNgayLuuKho.Name = "txtSoNgayLuuKho";
            this.txtSoNgayLuuKho.Size = new System.Drawing.Size(179, 22);
            this.txtSoNgayLuuKho.TabIndex = 13;
            // 
            // lblSoNgayLuuKho
            // 
            this.lblSoNgayLuuKho.AutoSize = true;
            this.lblSoNgayLuuKho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayLuuKho.Location = new System.Drawing.Point(144, 62);
            this.lblSoNgayLuuKho.Name = "lblSoNgayLuuKho";
            this.lblSoNgayLuuKho.Size = new System.Drawing.Size(132, 16);
            this.lblSoNgayLuuKho.TabIndex = 12;
            this.lblSoNgayLuuKho.Text = "Số ngày lưu kho quá: ";
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(294, 15);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(179, 21);
            this.cboLoaiHang.TabIndex = 11;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.Location = new System.Drawing.Point(14, 60);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(116, 20);
            this.rdoAll.TabIndex = 10;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Tất cả loại hàng";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoLoaiHang
            // 
            this.rdoLoaiHang.AutoSize = true;
            this.rdoLoaiHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoaiHang.Location = new System.Drawing.Point(14, 13);
            this.rdoLoaiHang.Name = "rdoLoaiHang";
            this.rdoLoaiHang.Size = new System.Drawing.Size(109, 20);
            this.rdoLoaiHang.TabIndex = 9;
            this.rdoLoaiHang.TabStop = true;
            this.rdoLoaiHang.Text = "Theo loại hàng";
            this.rdoLoaiHang.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 111);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(653, 365);
            this.dgvMain.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoLoaiHang);
            this.panel1.Controls.Add(this.lblChonTenLoaiHang);
            this.panel1.Controls.Add(this.rdoAll);
            this.panel1.Controls.Add(this.btnThucHien);
            this.panel1.Controls.Add(this.cboLoaiHang);
            this.panel1.Controls.Add(this.txtSoNgayLuuKho);
            this.panel1.Controls.Add(this.lblSoNgayLuuKho);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 93);
            this.panel1.TabIndex = 16;
            // 
            // frm_BCK_HangTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(686, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMain);
            this.Name = "frm_BCK_HangTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BCK_HangTonKho";
            this.Load += new System.EventHandler(this.frm_BCK_HangTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblChonTenLoaiHang;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.TextBox txtSoNgayLuuKho;
        private System.Windows.Forms.Label lblSoNgayLuuKho;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoLoaiHang;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel1;
    }
}