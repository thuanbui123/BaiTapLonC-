namespace quanLyKho
{
    partial class frm_BCK_BCGiaXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboBCK_LoaiHang = new System.Windows.Forms.ComboBox();
            this.rdbBCK_LamMoi = new System.Windows.Forms.RadioButton();
            this.rdbBCK_LoaiHang = new System.Windows.Forms.RadioButton();
            this.dgvBCK_BCGiaXuatKho = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCK_BCGiaXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(381, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG BÁO GIÁ XUẤT KHO ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboBCK_LoaiHang);
            this.panel1.Controls.Add(this.rdbBCK_LamMoi);
            this.panel1.Controls.Add(this.rdbBCK_LoaiHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 167);
            this.panel1.TabIndex = 1;
            // 
            // cboBCK_LoaiHang
            // 
            this.cboBCK_LoaiHang.FormattingEnabled = true;
            this.cboBCK_LoaiHang.Location = new System.Drawing.Point(268, 77);
            this.cboBCK_LoaiHang.Name = "cboBCK_LoaiHang";
            this.cboBCK_LoaiHang.Size = new System.Drawing.Size(201, 28);
            this.cboBCK_LoaiHang.TabIndex = 3;
            this.cboBCK_LoaiHang.SelectedValueChanged += new System.EventHandler(this.cboBCK_LoaiHang_SelectedValueChanged);
            // 
            // rdbBCK_LamMoi
            // 
            this.rdbBCK_LamMoi.AutoSize = true;
            this.rdbBCK_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBCK_LamMoi.Location = new System.Drawing.Point(142, 111);
            this.rdbBCK_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBCK_LamMoi.Name = "rdbBCK_LamMoi";
            this.rdbBCK_LamMoi.Size = new System.Drawing.Size(95, 24);
            this.rdbBCK_LamMoi.TabIndex = 2;
            this.rdbBCK_LamMoi.TabStop = true;
            this.rdbBCK_LamMoi.Text = "Làm mới";
            this.rdbBCK_LamMoi.UseVisualStyleBackColor = true;
            // 
            // rdbBCK_LoaiHang
            // 
            this.rdbBCK_LoaiHang.AutoSize = true;
            this.rdbBCK_LoaiHang.Location = new System.Drawing.Point(142, 77);
            this.rdbBCK_LoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBCK_LoaiHang.Name = "rdbBCK_LoaiHang";
            this.rdbBCK_LoaiHang.Size = new System.Drawing.Size(103, 24);
            this.rdbBCK_LoaiHang.TabIndex = 1;
            this.rdbBCK_LoaiHang.TabStop = true;
            this.rdbBCK_LoaiHang.Text = "Loại hàng";
            this.rdbBCK_LoaiHang.UseVisualStyleBackColor = true;
            // 
            // dgvBCK_BCGiaXuatKho
            // 
            this.dgvBCK_BCGiaXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCK_BCGiaXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBCK_BCGiaXuatKho.Location = new System.Drawing.Point(0, 167);
            this.dgvBCK_BCGiaXuatKho.Name = "dgvBCK_BCGiaXuatKho";
            this.dgvBCK_BCGiaXuatKho.RowHeadersWidth = 51;
            this.dgvBCK_BCGiaXuatKho.RowTemplate.Height = 24;
            this.dgvBCK_BCGiaXuatKho.Size = new System.Drawing.Size(1191, 509);
            this.dgvBCK_BCGiaXuatKho.TabIndex = 2;
            // 
            // frm_BCK_BCGiaXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 676);
            this.Controls.Add(this.dgvBCK_BCGiaXuatKho);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCK_BCGiaXuat";
            this.Text = "frm_BCK_BCGiaXuat";
            this.Load += new System.EventHandler(this.frm_BCK_BCGiaXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCK_BCGiaXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboBCK_LoaiHang;
        private System.Windows.Forms.RadioButton rdbBCK_LamMoi;
        private System.Windows.Forms.RadioButton rdbBCK_LoaiHang;
        private System.Windows.Forms.DataGridView dgvBCK_BCGiaXuatKho;
    }
}