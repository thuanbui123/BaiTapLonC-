
namespace quanLyKho
{
    partial class frm_BC_ThongKeKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BC_ThongKeKhachHang));
            this.lblThongKeKhachHang = new System.Windows.Forms.Label();
            this.dgv_Main_ThongKeKhachHang = new System.Windows.Forms.DataGridView();
            this.btn_BC_In = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main_ThongKeKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongKeKhachHang
            // 
            this.lblThongKeKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongKeKhachHang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThongKeKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lblThongKeKhachHang.Name = "lblThongKeKhachHang";
            this.lblThongKeKhachHang.Size = new System.Drawing.Size(1001, 58);
            this.lblThongKeKhachHang.TabIndex = 9;
            this.lblThongKeKhachHang.Text = "THỐNG KÊ KHÁCH HÀNG";
            this.lblThongKeKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Main_ThongKeKhachHang
            // 
            this.dgv_Main_ThongKeKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main_ThongKeKhachHang.Location = new System.Drawing.Point(4, 116);
            this.dgv_Main_ThongKeKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Main_ThongKeKhachHang.Name = "dgv_Main_ThongKeKhachHang";
            this.dgv_Main_ThongKeKhachHang.Size = new System.Drawing.Size(988, 357);
            this.dgv_Main_ThongKeKhachHang.TabIndex = 8;
            // 
            // btn_BC_In
            // 
            this.btn_BC_In.Image = ((System.Drawing.Image)(resources.GetObject("btn_BC_In.Image")));
            this.btn_BC_In.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_BC_In.Location = new System.Drawing.Point(5, 62);
            this.btn_BC_In.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BC_In.Name = "btn_BC_In";
            this.btn_BC_In.Size = new System.Drawing.Size(108, 46);
            this.btn_BC_In.TabIndex = 7;
            this.btn_BC_In.Text = "In";
            this.btn_BC_In.UseVisualStyleBackColor = true;
            this.btn_BC_In.Click += new System.EventHandler(this.btn_BC_In_Click);
            // 
            // frm_BC_ThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1001, 597);
            this.Controls.Add(this.lblThongKeKhachHang);
            this.Controls.Add(this.dgv_Main_ThongKeKhachHang);
            this.Controls.Add(this.btn_BC_In);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BC_ThongKeKhachHang";
            this.Text = "frm_BC_ThongKeKhachHang";
            this.Load += new System.EventHandler(this.frm_BC_ThongKeKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main_ThongKeKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThongKeKhachHang;
        private System.Windows.Forms.DataGridView dgv_Main_ThongKeKhachHang;
        private System.Windows.Forms.Button btn_BC_In;
    }
}