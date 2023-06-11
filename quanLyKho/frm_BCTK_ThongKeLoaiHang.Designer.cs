
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
            this.lblThongKeLoaiHang = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblThongKeLoaiHang
            // 
            this.lblThongKeLoaiHang.AutoSize = true;
            this.lblThongKeLoaiHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeLoaiHang.Location = new System.Drawing.Point(182, 9);
            this.lblThongKeLoaiHang.Name = "lblThongKeLoaiHang";
            this.lblThongKeLoaiHang.Size = new System.Drawing.Size(193, 25);
            this.lblThongKeLoaiHang.TabIndex = 3;
            this.lblThongKeLoaiHang.Text = "Thống kê loại hàng";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(624, 385);
            this.reportViewer1.TabIndex = 9;
            // 
            // frm_BCTK_ThongKeLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(648, 445);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblThongKeLoaiHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_ThongKeLoaiHang";
            this.Text = "frm_BCTK_ThongKeLoaiHang";
            this.Load += new System.EventHandler(this.frm_BCTK_ThongKeLoaiHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThongKeLoaiHang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}