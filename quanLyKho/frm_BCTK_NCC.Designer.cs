
namespace quanLyKho
{
    partial class frm_BCTK_NCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCTK_NCC));
            this.dgv_BCTK_NCC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BCTK_NCC_In = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BCTK_NCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BCTK_NCC
            // 
            this.dgv_BCTK_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BCTK_NCC.Location = new System.Drawing.Point(6, 127);
            this.dgv_BCTK_NCC.Name = "dgv_BCTK_NCC";
            this.dgv_BCTK_NCC.RowHeadersWidth = 51;
            this.dgv_BCTK_NCC.RowTemplate.Height = 24;
            this.dgv_BCTK_NCC.Size = new System.Drawing.Size(1039, 407);
            this.dgv_BCTK_NCC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1039, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn_BCTK_NCC_In);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 115);
            this.panel1.TabIndex = 5;
            // 
            // btn_BCTK_NCC_In
            // 
            this.btn_BCTK_NCC_In.Image = ((System.Drawing.Image)(resources.GetObject("btn_BCTK_NCC_In.Image")));
            this.btn_BCTK_NCC_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BCTK_NCC_In.Location = new System.Drawing.Point(57, 40);
            this.btn_BCTK_NCC_In.Name = "btn_BCTK_NCC_In";
            this.btn_BCTK_NCC_In.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btn_BCTK_NCC_In.Size = new System.Drawing.Size(127, 64);
            this.btn_BCTK_NCC_In.TabIndex = 2;
            this.btn_BCTK_NCC_In.Text = "In";
            this.btn_BCTK_NCC_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BCTK_NCC_In.UseVisualStyleBackColor = false;
            this.btn_BCTK_NCC_In.Click += new System.EventHandler(this.btn_BCTK_NCC_In_Click);
            // 
            // frm_BCTK_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 540);
            this.Controls.Add(this.dgv_BCTK_NCC);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_NCC";
            this.Text = "frm_BCTK_NCC";
            this.Load += new System.EventHandler(this.frm_BCTK_NCC_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BCTK_NCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BCTK_NCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BCTK_NCC_In;
    }
}