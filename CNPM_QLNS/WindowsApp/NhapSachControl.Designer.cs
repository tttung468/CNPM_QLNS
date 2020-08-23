namespace WindowsApp
{
    partial class NhapSachControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.buttonLapPhieuNhap = new System.Windows.Forms.Button();
            this.numericLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.btnXoaPhieuNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLuongNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(3, 84);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(397, 477);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcPhieuNhap_CellClick);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(406, 227);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.ReadOnly = true;
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(593, 334);
            this.dgvChiTietPhieuNhap.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericLuongNhap);
            this.panel1.Controls.Add(this.cbTenSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThemChiTiet);
            this.panel1.Location = new System.Drawing.Point(406, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 218);
            this.panel1.TabIndex = 2;
            // 
            // cbTenSach
            // 
            this.cbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(285, 29);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(158, 28);
            this.cbTenSach.TabIndex = 7;
            this.cbTenSach.SelectedIndexChanged += new System.EventHandler(this.cbTenSach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sách";
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(210, 140);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(180, 46);
            this.btnThemChiTiet.TabIndex = 2;
            this.btnThemChiTiet.Text = "Thêm chi tiết phiếu nhập";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // buttonLapPhieuNhap
            // 
            this.buttonLapPhieuNhap.Location = new System.Drawing.Point(19, 15);
            this.buttonLapPhieuNhap.Name = "buttonLapPhieuNhap";
            this.buttonLapPhieuNhap.Size = new System.Drawing.Size(156, 46);
            this.buttonLapPhieuNhap.TabIndex = 1;
            this.buttonLapPhieuNhap.Text = "Lập phiếu nhập sách";
            this.buttonLapPhieuNhap.UseVisualStyleBackColor = true;
            this.buttonLapPhieuNhap.Click += new System.EventHandler(this.buttonLapPhieuNhap_Click);
            // 
            // numericLuongNhap
            // 
            this.numericLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLuongNhap.Location = new System.Drawing.Point(285, 80);
            this.numericLuongNhap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericLuongNhap.Name = "numericLuongNhap";
            this.numericLuongNhap.Size = new System.Drawing.Size(158, 27);
            this.numericLuongNhap.TabIndex = 13;
            // 
            // btnXoaPhieuNhap
            // 
            this.btnXoaPhieuNhap.Location = new System.Drawing.Point(203, 15);
            this.btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            this.btnXoaPhieuNhap.Size = new System.Drawing.Size(156, 46);
            this.btnXoaPhieuNhap.TabIndex = 3;
            this.btnXoaPhieuNhap.Text = "Xóa phiếu nhập sách";
            this.btnXoaPhieuNhap.UseVisualStyleBackColor = true;
            this.btnXoaPhieuNhap.Click += new System.EventHandler(this.btnXoaPhieuNhap_Click);
            // 
            // NhapSachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoaPhieuNhap);
            this.Controls.Add(this.buttonLapPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Name = "NhapSachControl";
            this.Size = new System.Drawing.Size(1002, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLuongNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLapPhieuNhap;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.NumericUpDown numericLuongNhap;
        private System.Windows.Forms.Button btnXoaPhieuNhap;
    }
}
