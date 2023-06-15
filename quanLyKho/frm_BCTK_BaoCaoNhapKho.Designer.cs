
namespace quanLyKho
{
    partial class frm_BCTK_BaoCaoNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCTK_BaoCaoNhapKho));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtTheoHoaDon = new System.Windows.Forms.TextBox();
            this.txtTheoNhaCungCap = new System.Windows.Forms.TextBox();
            this.chkTheoHoaDon = new System.Windows.Forms.CheckBox();
            this.chkTheoNhaCungCap = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblBaoCaoNhapKho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(230, 57);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 28;
            this.dgvMain.Size = new System.Drawing.Size(850, 439);
            this.dgvMain.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.txtTheoHoaDon);
            this.groupBox1.Controls.Add(this.txtTheoNhaCungCap);
            this.groupBox1.Controls.Add(this.chkTheoHoaDon);
            this.groupBox1.Controls.Add(this.chkTheoNhaCungCap);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.lblDenNgay);
            this.groupBox1.Controls.Add(this.lblTuNgay);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(206, 439);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(42, 312);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(127, 50);
            this.btnThucHien.TabIndex = 19;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click_1);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(42, 368);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(127, 50);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click_1);
            // 
            // txtTheoHoaDon
            // 
            this.txtTheoHoaDon.Location = new System.Drawing.Point(-3, 253);
            this.txtTheoHoaDon.Name = "txtTheoHoaDon";
            this.txtTheoHoaDon.Size = new System.Drawing.Size(209, 26);
            this.txtTheoHoaDon.TabIndex = 17;
            // 
            // txtTheoNhaCungCap
            // 
            this.txtTheoNhaCungCap.Location = new System.Drawing.Point(-3, 186);
            this.txtTheoNhaCungCap.Name = "txtTheoNhaCungCap";
            this.txtTheoNhaCungCap.Size = new System.Drawing.Size(209, 26);
            this.txtTheoNhaCungCap.TabIndex = 16;
            // 
            // chkTheoHoaDon
            // 
            this.chkTheoHoaDon.AutoSize = true;
            this.chkTheoHoaDon.Checked = true;
            this.chkTheoHoaDon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTheoHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTheoHoaDon.Location = new System.Drawing.Point(4, 221);
            this.chkTheoHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.chkTheoHoaDon.Name = "chkTheoHoaDon";
            this.chkTheoHoaDon.Size = new System.Drawing.Size(112, 23);
            this.chkTheoHoaDon.TabIndex = 2;
            this.chkTheoHoaDon.Text = "Theo hóa đơn";
            this.chkTheoHoaDon.UseVisualStyleBackColor = true;
            this.chkTheoHoaDon.CheckedChanged += new System.EventHandler(this.chkTheoHoaDon_CheckedChanged);
            // 
            // chkTheoNhaCungCap
            // 
            this.chkTheoNhaCungCap.AutoSize = true;
            this.chkTheoNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTheoNhaCungCap.Location = new System.Drawing.Point(4, 158);
            this.chkTheoNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.chkTheoNhaCungCap.Name = "chkTheoNhaCungCap";
            this.chkTheoNhaCungCap.Size = new System.Drawing.Size(142, 23);
            this.chkTheoNhaCungCap.TabIndex = 2;
            this.chkTheoNhaCungCap.Text = "Theo nhà cung cấp";
            this.chkTheoNhaCungCap.UseVisualStyleBackColor = true;
            this.chkTheoNhaCungCap.CheckedChanged += new System.EventHandler(this.chkTheoNhaCungCap_CheckedChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Location = new System.Drawing.Point(4, 124);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(198, 26);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Location = new System.Drawing.Point(4, 56);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(198, 26);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(4, 95);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(66, 19);
            this.lblDenNgay.TabIndex = 0;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(4, 25);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(77, 23);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // lblBaoCaoNhapKho
            // 
            this.lblBaoCaoNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaoCaoNhapKho.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoNhapKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBaoCaoNhapKho.Location = new System.Drawing.Point(0, 0);
            this.lblBaoCaoNhapKho.Name = "lblBaoCaoNhapKho";
            this.lblBaoCaoNhapKho.Size = new System.Drawing.Size(1091, 37);
            this.lblBaoCaoNhapKho.TabIndex = 16;
            this.lblBaoCaoNhapKho.Text = "BÁO CÁO NHẬP KHO";
            this.lblBaoCaoNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_BCTK_BaoCaoNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1091, 504);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBaoCaoNhapKho);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_BaoCaoNhapKho";
            this.Text = "frm_BCTK_BaoCaoNhapKho";
            this.Load += new System.EventHandler(this.frm_BCTK_BaoCaoNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTheoHoaDon;
        private System.Windows.Forms.CheckBox chkTheoNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblBaoCaoNhapKho;
        private System.Windows.Forms.TextBox txtTheoHoaDon;
        private System.Windows.Forms.TextBox txtTheoNhaCungCap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThucHien;
    }
}