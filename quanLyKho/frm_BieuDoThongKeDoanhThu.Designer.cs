
namespace quanLyKho
{
    partial class frm_BieuDoThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.rdoTheoQuy = new System.Windows.Forms.RadioButton();
            this.rdoTheoThang = new System.Windows.Forms.RadioButton();
            this.rdoTheoTuan = new System.Windows.Forms.RadioButton();
            this.chart_BieuDoDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BieuDoDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.rdoTheoQuy);
            this.groupBox1.Controls.Add(this.rdoTheoThang);
            this.groupBox1.Controls.Add(this.rdoTheoTuan);
            this.groupBox1.Location = new System.Drawing.Point(1008, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(15, 112);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(108, 46);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click_1);
            // 
            // rdoTheoQuy
            // 
            this.rdoTheoQuy.AutoSize = true;
            this.rdoTheoQuy.Location = new System.Drawing.Point(15, 83);
            this.rdoTheoQuy.Name = "rdoTheoQuy";
            this.rdoTheoQuy.Size = new System.Drawing.Size(99, 24);
            this.rdoTheoQuy.TabIndex = 8;
            this.rdoTheoQuy.TabStop = true;
            this.rdoTheoQuy.Text = "Theo quý";
            this.rdoTheoQuy.UseVisualStyleBackColor = true;
            // 
            // rdoTheoThang
            // 
            this.rdoTheoThang.AutoSize = true;
            this.rdoTheoThang.Location = new System.Drawing.Point(15, 52);
            this.rdoTheoThang.Name = "rdoTheoThang";
            this.rdoTheoThang.Size = new System.Drawing.Size(115, 24);
            this.rdoTheoThang.TabIndex = 7;
            this.rdoTheoThang.TabStop = true;
            this.rdoTheoThang.Text = "Theo tháng";
            this.rdoTheoThang.UseVisualStyleBackColor = true;
            // 
            // rdoTheoTuan
            // 
            this.rdoTheoTuan.AutoSize = true;
            this.rdoTheoTuan.Location = new System.Drawing.Point(15, 23);
            this.rdoTheoTuan.Name = "rdoTheoTuan";
            this.rdoTheoTuan.Size = new System.Drawing.Size(106, 24);
            this.rdoTheoTuan.TabIndex = 6;
            this.rdoTheoTuan.TabStop = true;
            this.rdoTheoTuan.Text = "Theo tuần";
            this.rdoTheoTuan.UseVisualStyleBackColor = true;
            this.rdoTheoTuan.CheckedChanged += new System.EventHandler(this.rdoTheoTuan_CheckedChanged);
            // 
            // chart_BieuDoDoanhThu
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_BieuDoDoanhThu.ChartAreas.Add(chartArea3);
            this.chart_BieuDoDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_BieuDoDoanhThu.Legends.Add(legend3);
            this.chart_BieuDoDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chart_BieuDoDoanhThu.Name = "chart_BieuDoDoanhThu";
            this.chart_BieuDoDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Doanh thu";
            this.chart_BieuDoDoanhThu.Series.Add(series3);
            this.chart_BieuDoDoanhThu.Size = new System.Drawing.Size(1200, 692);
            this.chart_BieuDoDoanhThu.TabIndex = 9;
            this.chart_BieuDoDoanhThu.Text = "Biểu đồ doanh thu";
            title3.Name = "Title1";
            title3.Text = "Biểu đồ thống kê doanh thu";
            this.chart_BieuDoDoanhThu.Titles.Add(title3);
            this.chart_BieuDoDoanhThu.Click += new System.EventHandler(this.chart_BieuDoDoanhThu_Click);
            // 
            // frm_BieuDoThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart_BieuDoDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_BieuDoThongKeDoanhThu";
            this.Text = "frm_BieuDoThongKeDoanhThu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BieuDoDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.RadioButton rdoTheoQuy;
        private System.Windows.Forms.RadioButton rdoTheoThang;
        private System.Windows.Forms.RadioButton rdoTheoTuan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BieuDoDoanhThu;
    }
}