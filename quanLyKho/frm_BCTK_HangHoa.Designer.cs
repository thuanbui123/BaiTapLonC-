
namespace quanLyKho
{
    partial class frm_BCTK_HangHoa
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
            this.lblThongKeHangHoa = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblThongKeHangHoa
            // 
            this.lblThongKeHangHoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThongKeHangHoa.Location = new System.Drawing.Point(4, 0);
            this.lblThongKeHangHoa.Name = "lblThongKeHangHoa";
            this.lblThongKeHangHoa.Size = new System.Drawing.Size(860, 42);
            this.lblThongKeHangHoa.TabIndex = 0;
            this.lblThongKeHangHoa.Text = "THỐNG KÊ HÀNG HÓA";
            this.lblThongKeHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(4, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(860, 484);
            this.reportViewer1.TabIndex = 1;
            // 
            // frm_BCTK_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblThongKeHangHoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo - Thống kê hàng hóa";
            this.Load += new System.EventHandler(this.frm_BCTK_HangHoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThongKeHangHoa;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}