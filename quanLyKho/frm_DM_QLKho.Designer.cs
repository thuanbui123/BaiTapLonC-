
namespace quanLyKho
{
    partial class frm_DM_QLKho
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
            this.dgv_DM_Kho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DM_Kho_LamMoi = new System.Windows.Forms.Button();
            this.cbo_DM_Kho_HangHoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DM_Kho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DM_Kho
            // 
            this.dgv_DM_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DM_Kho.Location = new System.Drawing.Point(5, 93);
            this.dgv_DM_Kho.Name = "dgv_DM_Kho";
            this.dgv_DM_Kho.RowHeadersWidth = 51;
            this.dgv_DM_Kho.RowTemplate.Height = 24;
            this.dgv_DM_Kho.Size = new System.Drawing.Size(811, 505);
            this.dgv_DM_Kho.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DM_Kho_LamMoi);
            this.panel1.Controls.Add(this.cbo_DM_Kho_HangHoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 86);
            this.panel1.TabIndex = 2;
            // 
            // btn_DM_Kho_LamMoi
            // 
            this.btn_DM_Kho_LamMoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_DM_Kho_LamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DM_Kho_LamMoi.Location = new System.Drawing.Point(533, 21);
            this.btn_DM_Kho_LamMoi.Name = "btn_DM_Kho_LamMoi";
            this.btn_DM_Kho_LamMoi.Size = new System.Drawing.Size(172, 54);
            this.btn_DM_Kho_LamMoi.TabIndex = 2;
            this.btn_DM_Kho_LamMoi.Text = "Làm mới";
            this.btn_DM_Kho_LamMoi.UseVisualStyleBackColor = false;
            this.btn_DM_Kho_LamMoi.Click += new System.EventHandler(this.btn_DM_Kho_LamMoi_Click_1);
            // 
            // cbo_DM_Kho_HangHoa
            // 
            this.cbo_DM_Kho_HangHoa.FormattingEnabled = true;
            this.cbo_DM_Kho_HangHoa.Location = new System.Drawing.Point(230, 33);
            this.cbo_DM_Kho_HangHoa.Name = "cbo_DM_Kho_HangHoa";
            this.cbo_DM_Kho_HangHoa.Size = new System.Drawing.Size(227, 27);
            this.cbo_DM_Kho_HangHoa.TabIndex = 1;
            this.cbo_DM_Kho_HangHoa.SelectedIndexChanged += new System.EventHandler(this.cbo_DM_Kho_HangHoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng hóa";
            // 
            // frm_DM_QLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 606);
            this.Controls.Add(this.dgv_DM_Kho);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DM_QLKho";
            this.Text = "frm_DM_QLKho";
            this.Load += new System.EventHandler(this.frm_DM_QLKho_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DM_Kho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DM_Kho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DM_Kho_LamMoi;
        private System.Windows.Forms.ComboBox cbo_DM_Kho_HangHoa;
        private System.Windows.Forms.Label label1;
    }
}