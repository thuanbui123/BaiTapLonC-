
namespace quanLyKho
{
    partial class Frm_BBG_NCC
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
            this.components = new System.ComponentModel.Container();
            this.dgv_BangThongTin = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_NCC = new System.Windows.Forms.ComboBox();
            this.rdo_loaihang = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_Reset = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BangThongTin
            // 
            this.dgv_BangThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BangThongTin.Location = new System.Drawing.Point(12, 111);
            this.dgv_BangThongTin.Name = "dgv_BangThongTin";
            this.dgv_BangThongTin.Size = new System.Drawing.Size(748, 239);
            this.dgv_BangThongTin.TabIndex = 86;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(160, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "BẢNG BÁO GIÁ NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbo_NCC
            // 
            this.cbo_NCC.Enabled = false;
            this.cbo_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NCC.FormattingEnabled = true;
            this.cbo_NCC.Location = new System.Drawing.Point(178, 66);
            this.cbo_NCC.Name = "cbo_NCC";
            this.cbo_NCC.Size = new System.Drawing.Size(135, 28);
            this.cbo_NCC.TabIndex = 84;
            this.cbo_NCC.SelectedIndexChanged += new System.EventHandler(this.cbo_NCC_SelectedIndexChanged);
            // 
            // rdo_loaihang
            // 
            this.rdo_loaihang.AutoSize = true;
            this.rdo_loaihang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_loaihang.Location = new System.Drawing.Point(366, 69);
            this.rdo_loaihang.Name = "rdo_loaihang";
            this.rdo_loaihang.Size = new System.Drawing.Size(91, 24);
            this.rdo_loaihang.TabIndex = 85;
            this.rdo_loaihang.TabStop = true;
            this.rdo_loaihang.Text = "loại hàng";
            this.rdo_loaihang.UseVisualStyleBackColor = true;
            this.rdo_loaihang.CheckedChanged += new System.EventHandler(this.rdo_loaihang_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // rdo_Reset
            // 
            this.rdo_Reset.AutoSize = true;
            this.rdo_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Reset.Location = new System.Drawing.Point(486, 67);
            this.rdo_Reset.Name = "rdo_Reset";
            this.rdo_Reset.Size = new System.Drawing.Size(70, 24);
            this.rdo_Reset.TabIndex = 90;
            this.rdo_Reset.TabStop = true;
            this.rdo_Reset.Text = "Reset";
            this.rdo_Reset.UseVisualStyleBackColor = true;
            this.rdo_Reset.CheckedChanged += new System.EventHandler(this.rdo_Reset_CheckedChanged);
            // 
            // Frm_BBG_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 366);
            this.Controls.Add(this.rdo_Reset);
            this.Controls.Add(this.dgv_BangThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_NCC);
            this.Controls.Add(this.rdo_loaihang);
            this.Controls.Add(this.label3);
            this.Name = "Frm_BBG_NCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BBG_NCC";
            this.Load += new System.EventHandler(this.Frm_BBG_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BangThongTin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_NCC;
        private System.Windows.Forms.RadioButton rdo_loaihang;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdo_Reset;
    }
}