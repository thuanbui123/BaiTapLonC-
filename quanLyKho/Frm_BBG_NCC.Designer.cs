﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BangThongTin
            // 
            this.dgv_BangThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BangThongTin.Location = new System.Drawing.Point(120, 266);
            this.dgv_BangThongTin.Name = "dgv_BangThongTin";
            this.dgv_BangThongTin.Size = new System.Drawing.Size(790, 239);
            this.dgv_BangThongTin.TabIndex = 81;
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
            this.label1.Location = new System.Drawing.Point(349, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "BẢNG BÁO GIÁ NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbo_NCC
            // 
            this.cbo_NCC.FormattingEnabled = true;
            this.cbo_NCC.Location = new System.Drawing.Point(284, 131);
            this.cbo_NCC.Name = "cbo_NCC";
            this.cbo_NCC.Size = new System.Drawing.Size(135, 21);
            this.cbo_NCC.TabIndex = 79;
            this.cbo_NCC.SelectedIndexChanged += new System.EventHandler(this.cbo_NCC_SelectedIndexChanged_1);
            // 
            // rdo_loaihang
            // 
            this.rdo_loaihang.AutoSize = true;
            this.rdo_loaihang.Location = new System.Drawing.Point(518, 135);
            this.rdo_loaihang.Name = "rdo_loaihang";
            this.rdo_loaihang.Size = new System.Drawing.Size(68, 17);
            this.rdo_loaihang.TabIndex = 80;
            this.rdo_loaihang.TabStop = true;
            this.rdo_loaihang.Text = "loại hàng";
            this.rdo_loaihang.UseVisualStyleBackColor = true;
  
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // Frm_BBG_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 578);
            this.Controls.Add(this.dgv_BangThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_NCC);
            this.Controls.Add(this.rdo_loaihang);
            this.Controls.Add(this.label3);
            this.Name = "Frm_BBG_NCC";
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
    }
}