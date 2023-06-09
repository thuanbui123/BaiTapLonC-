
namespace quanLyKho
{
    partial class frm_BCTK_BaoCaoKho
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblBaoCaoKho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(55, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(520, 514);
            this.reportViewer1.TabIndex = 11;
            // 
            // lblBaoCaoKho
            // 
            this.lblBaoCaoKho.AutoSize = true;
            this.lblBaoCaoKho.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoKho.Location = new System.Drawing.Point(217, 9);
            this.lblBaoCaoKho.Name = "lblBaoCaoKho";
            this.lblBaoCaoKho.Size = new System.Drawing.Size(161, 32);
            this.lblBaoCaoKho.TabIndex = 10;
            this.lblBaoCaoKho.Text = "Báo cáo kho";
            this.lblBaoCaoKho.Click += new System.EventHandler(this.lblBaoCaoKho_Click);
            // 
            // frm_BCTK_BaoCaoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(620, 616);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblBaoCaoKho);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_BaoCaoKho";
            this.Text = "frm_BCTK_BaoCaoKho";
            this.Load += new System.EventHandler(this.frm_BCTK_BaoCaoKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblBaoCaoKho;
    }
}