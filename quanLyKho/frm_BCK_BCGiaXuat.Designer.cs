
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_LoaiHang = new System.Windows.Forms.RadioButton();
            this.rdbBCK_LamMoi = new System.Windows.Forms.RadioButton();
            this.cboBCK_LoaiHang = new System.Windows.Forms.ComboBox();
            this.dgvBCK_BCGiaXuatKho = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCK_BCGiaXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboBCK_LoaiHang);
            this.panel1.Controls.Add(this.rdbBCK_LamMoi);
            this.panel1.Controls.Add(this.rdo_LoaiHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 123);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG BÁO GIÁ XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdo_LoaiHang
            // 
            this.rdo_LoaiHang.AutoSize = true;
            this.rdo_LoaiHang.Location = new System.Drawing.Point(51, 41);
            this.rdo_LoaiHang.Name = "rdo_LoaiHang";
            this.rdo_LoaiHang.Size = new System.Drawing.Size(85, 20);
            this.rdo_LoaiHang.TabIndex = 1;
            this.rdo_LoaiHang.TabStop = true;
            this.rdo_LoaiHang.Text = "Loại hàng";
            this.rdo_LoaiHang.UseVisualStyleBackColor = true;
            this.rdo_LoaiHang.CheckedChanged += new System.EventHandler(this.rdo_LoaiHang_CheckedChanged);
            // 
            // rdbBCK_LamMoi
            // 
            this.rdbBCK_LamMoi.AutoSize = true;
            this.rdbBCK_LamMoi.Location = new System.Drawing.Point(51, 84);
            this.rdbBCK_LamMoi.Name = "rdbBCK_LamMoi";
            this.rdbBCK_LamMoi.Size = new System.Drawing.Size(77, 20);
            this.rdbBCK_LamMoi.TabIndex = 2;
            this.rdbBCK_LamMoi.TabStop = true;
            this.rdbBCK_LamMoi.Text = "Làm mới";
            this.rdbBCK_LamMoi.UseVisualStyleBackColor = true;
            this.rdbBCK_LamMoi.CheckedChanged += new System.EventHandler(this.rdbBCK_LamMoi_CheckedChanged);
            // 
            // cboBCK_LoaiHang
            // 
            this.cboBCK_LoaiHang.Enabled = false;
            this.cboBCK_LoaiHang.FormattingEnabled = true;
            this.cboBCK_LoaiHang.Location = new System.Drawing.Point(377, 41);
            this.cboBCK_LoaiHang.Name = "cboBCK_LoaiHang";
            this.cboBCK_LoaiHang.Size = new System.Drawing.Size(168, 24);
            this.cboBCK_LoaiHang.TabIndex = 3;
            this.cboBCK_LoaiHang.SelectedIndexChanged += new System.EventHandler(this.cboBCK_LoaiHang_SelectedIndexChanged);
            // 
            // dgvBCK_BCGiaXuatKho
            // 
            this.dgvBCK_BCGiaXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCK_BCGiaXuatKho.Location = new System.Drawing.Point(12, 130);
            this.dgvBCK_BCGiaXuatKho.Name = "dgvBCK_BCGiaXuatKho";
            this.dgvBCK_BCGiaXuatKho.Size = new System.Drawing.Size(844, 289);
            this.dgvBCK_BCGiaXuatKho.TabIndex = 1;
            // 
            // frm_BCK_BCGiaXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 431);
            this.Controls.Add(this.dgvBCK_BCGiaXuatKho);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_BCK_BCGiaXuat";
            this.Text = "frm_BCK_BCGiaXuat";
            this.Load += new System.EventHandler(this.frm_BCK_BCGiaXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCK_BCGiaXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboBCK_LoaiHang;
        private System.Windows.Forms.RadioButton rdbBCK_LamMoi;
        private System.Windows.Forms.RadioButton rdo_LoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBCK_BCGiaXuatKho;
    }
}