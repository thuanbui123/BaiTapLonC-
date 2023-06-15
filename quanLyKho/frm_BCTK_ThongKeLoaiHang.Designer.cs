
namespace quanLyKho
{
    partial class frm_BCTK_ThongKeLoaiHang
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblThongKeLoaiHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 152);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(734, 428);
            this.dgvMain.TabIndex = 8;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 63);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(147, 46);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblThongKeLoaiHang
            // 
            this.lblThongKeLoaiHang.AutoSize = true;
            this.lblThongKeLoaiHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeLoaiHang.Location = new System.Drawing.Point(182, 11);
            this.lblThongKeLoaiHang.Name = "lblThongKeLoaiHang";
            this.lblThongKeLoaiHang.Size = new System.Drawing.Size(193, 25);
            this.lblThongKeLoaiHang.TabIndex = 6;
            this.lblThongKeLoaiHang.Text = "Thống kê loại hàng";
            // 
            // frm_BCTK_ThongKeLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(758, 590);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblThongKeLoaiHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_ThongKeLoaiHang";
            this.Text = "frm_BCTK_ThongKeLoaiHang";
            this.Load += new System.EventHandler(this.frm_BCTK_ThongKeLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblThongKeLoaiHang;
    }
}