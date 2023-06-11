
namespace quanLyKho
{
    partial class frm_InChiTietPhieuNhap
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
            this.rpvChiTietPhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvChiTietPhieuNhap
            // 
            this.rpvChiTietPhieuNhap.Location = new System.Drawing.Point(11, 11);
            this.rpvChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.rpvChiTietPhieuNhap.Name = "rpvChiTietPhieuNhap";
            this.rpvChiTietPhieuNhap.ServerReport.BearerToken = null;
            this.rpvChiTietPhieuNhap.Size = new System.Drawing.Size(778, 428);
            this.rpvChiTietPhieuNhap.TabIndex = 1;
            // 
            // frm_InChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvChiTietPhieuNhap);
            this.Name = "frm_InChiTietPhieuNhap";
            this.Text = "frm_InChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.frm_InChiTietPhieuNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvChiTietPhieuNhap;
    }
}