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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.rdoLoaiHang = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.lblSoNgayLuuKho = new System.Windows.Forms.Label();
            this.txtSoNgayLuuKho = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.lblChonTenLoaiHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 158);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(811, 365);
            this.dgvMain.TabIndex = 0;
            // 
            // rdoLoaiHang
            // 
            this.rdoLoaiHang.AutoSize = true;
            this.rdoLoaiHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoaiHang.Location = new System.Drawing.Point(25, 29);
            this.rdoLoaiHang.Name = "rdoLoaiHang";
            this.rdoLoaiHang.Size = new System.Drawing.Size(129, 23);
            this.rdoLoaiHang.TabIndex = 1;
            this.rdoLoaiHang.TabStop = true;
            this.rdoLoaiHang.Text = "Theo loại hàng";
            this.rdoLoaiHang.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.Location = new System.Drawing.Point(25, 76);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(135, 23);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Tất cả loại hàng";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(352, 27);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(233, 23);
            this.cboLoaiHang.TabIndex = 3;
            // 
            // lblSoNgayLuuKho
            // 
            this.lblSoNgayLuuKho.AutoSize = true;
            this.lblSoNgayLuuKho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayLuuKho.Location = new System.Drawing.Point(188, 78);
            this.lblSoNgayLuuKho.Name = "lblSoNgayLuuKho";
            this.lblSoNgayLuuKho.Size = new System.Drawing.Size(153, 19);
            this.lblSoNgayLuuKho.TabIndex = 4;
            this.lblSoNgayLuuKho.Text = "Số ngày lưu kho quá: ";
            // 
            // txtSoNgayLuuKho
            // 
            this.txtSoNgayLuuKho.Location = new System.Drawing.Point(352, 77);
            this.txtSoNgayLuuKho.Multiline = true;
            this.txtSoNgayLuuKho.Name = "txtSoNgayLuuKho";
            this.txtSoNgayLuuKho.Size = new System.Drawing.Size(233, 22);
            this.txtSoNgayLuuKho.TabIndex = 5;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(626, 27);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(129, 72);
            this.btnThucHien.TabIndex = 6;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // lblChonTenLoaiHang
            // 
            this.lblChonTenLoaiHang.AutoSize = true;
            this.lblChonTenLoaiHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTenLoaiHang.Location = new System.Drawing.Point(188, 27);
            this.lblChonTenLoaiHang.Name = "lblChonTenLoaiHang";
            this.lblChonTenLoaiHang.Size = new System.Drawing.Size(140, 19);
            this.lblChonTenLoaiHang.TabIndex = 7;
            this.lblChonTenLoaiHang.Text = "Chọn tên loại hàng:";
            // 
            // frm_BCK_HangTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 535);
            this.Controls.Add(this.lblChonTenLoaiHang);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtSoNgayLuuKho);
            this.Controls.Add(this.lblSoNgayLuuKho);
            this.Controls.Add(this.cboLoaiHang);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.rdoLoaiHang);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_BCK_HangTonKho";
            this.Text = "Hàng tồn kho";
            this.Load += new System.EventHandler(this.frm_BCK_HangTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}