
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCTK_HangHoa));
            this.lblThongKeHangHoa = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongKeHangHoa
            // 
            this.lblThongKeHangHoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThongKeHangHoa.Location = new System.Drawing.Point(12, 3);
            this.lblThongKeHangHoa.Name = "lblThongKeHangHoa";
            this.lblThongKeHangHoa.Size = new System.Drawing.Size(694, 42);
            this.lblThongKeHangHoa.TabIndex = 0;
            this.lblThongKeHangHoa.Text = "THỐNG KÊ HÀNG HÓA";
            this.lblThongKeHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(16, 48);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(95, 40);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 94);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(850, 281);
            this.dgvMain.TabIndex = 2;
            // 
            // frm_BCTK_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 387);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblThongKeHangHoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo - Thống kê hàng hóa";
            this.Load += new System.EventHandler(this.frm_BCTK_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThongKeHangHoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}