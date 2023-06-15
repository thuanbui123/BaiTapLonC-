
namespace quanLyKho
{
    partial class frm_TopMatHangBanChay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTheoNam = new System.Windows.Forms.RadioButton();
            this.rdoTheoQuy = new System.Windows.Forms.RadioButton();
            this.rdoTheoThang = new System.Windows.Forms.RadioButton();
            this.chartHangBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHangBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTheoNam);
            this.groupBox1.Controls.Add(this.rdoTheoQuy);
            this.groupBox1.Controls.Add(this.rdoTheoThang);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(690, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // rdoTheoNam
            // 
            this.rdoTheoNam.AutoSize = true;
            this.rdoTheoNam.Location = new System.Drawing.Point(12, 128);
            this.rdoTheoNam.Name = "rdoTheoNam";
            this.rdoTheoNam.Size = new System.Drawing.Size(99, 23);
            this.rdoTheoNam.TabIndex = 2;
            this.rdoTheoNam.Text = "Theo năm";
            this.rdoTheoNam.UseVisualStyleBackColor = true;
            this.rdoTheoNam.CheckedChanged += new System.EventHandler(this.rdoTheoNam_CheckedChanged);
            // 
            // rdoTheoQuy
            // 
            this.rdoTheoQuy.AutoSize = true;
            this.rdoTheoQuy.Location = new System.Drawing.Point(12, 87);
            this.rdoTheoQuy.Name = "rdoTheoQuy";
            this.rdoTheoQuy.Size = new System.Drawing.Size(94, 23);
            this.rdoTheoQuy.TabIndex = 1;
            this.rdoTheoQuy.Text = "Theo quý";
            this.rdoTheoQuy.UseVisualStyleBackColor = true;
            this.rdoTheoQuy.CheckedChanged += new System.EventHandler(this.rdoTheoQuy_CheckedChanged);
            // 
            // rdoTheoThang
            // 
            this.rdoTheoThang.AutoSize = true;
            this.rdoTheoThang.Checked = true;
            this.rdoTheoThang.Location = new System.Drawing.Point(12, 48);
            this.rdoTheoThang.Name = "rdoTheoThang";
            this.rdoTheoThang.Size = new System.Drawing.Size(108, 23);
            this.rdoTheoThang.TabIndex = 0;
            this.rdoTheoThang.TabStop = true;
            this.rdoTheoThang.Text = "Theo tháng";
            this.rdoTheoThang.UseVisualStyleBackColor = true;
            this.rdoTheoThang.CheckedChanged += new System.EventHandler(this.rdoTheoThang_CheckedChanged);
            // 
            // chartHangBanChay
            // 
            chartArea4.Name = "ChartArea1";
            this.chartHangBanChay.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartHangBanChay.Legends.Add(legend4);
            this.chartHangBanChay.Location = new System.Drawing.Point(26, 94);
            this.chartHangBanChay.Name = "chartHangBanChay";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartHangBanChay.Series.Add(series4);
            this.chartHangBanChay.Size = new System.Drawing.Size(630, 403);
            this.chartHangBanChay.TabIndex = 2;
            this.chartHangBanChay.Text = "chart1";
            // 
            // frm_TopMatHangBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 522);
            this.Controls.Add(this.chartHangBanChay);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TopMatHangBanChay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top mặt hàng bán chạy";
            this.Load += new System.EventHandler(this.frm_TopMatHangBanChay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHangBanChay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTheoNam;
        private System.Windows.Forms.RadioButton rdoTheoQuy;
        private System.Windows.Forms.RadioButton rdoTheoThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHangBanChay;
    }
}