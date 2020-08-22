namespace WindowsApp
{
    public partial class SachControl
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
            this.tableAdapterManager1 = new WindowsApp.QUAN_LY_NHA_SACHDataSetTableAdapters.TableAdapterManager();
            this.dgvSachSach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.numericDonGia = new System.Windows.Forms.NumericUpDown();
            this.numericLuongTon = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiSach = new System.Windows.Forms.ComboBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLuongTon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.SachTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsApp.QUAN_LY_NHA_SACHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvSachSach
            // 
            this.dgvSachSach.AllowUserToAddRows = false;
            this.dgvSachSach.AllowUserToDeleteRows = false;
            this.dgvSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachSach.Location = new System.Drawing.Point(3, 3);
            this.dgvSachSach.Name = "dgvSachSach";
            this.dgvSachSach.ReadOnly = true;
            this.dgvSachSach.RowHeadersWidth = 51;
            this.dgvSachSach.RowTemplate.Height = 24;
            this.dgvSachSach.Size = new System.Drawing.Size(996, 377);
            this.dgvSachSach.TabIndex = 0;
            this.dgvSachSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachSach_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.numericDonGia);
            this.panel1.Controls.Add(this.numericLuongTon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbLoaiSach);
            this.panel1.Controls.Add(this.txtTacGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Location = new System.Drawing.Point(3, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 164);
            this.panel1.TabIndex = 1;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(854, 107);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(122, 46);
            this.button_Xoa.TabIndex = 14;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // numericDonGia
            // 
            this.numericDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDonGia.Location = new System.Drawing.Point(830, 20);
            this.numericDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericDonGia.Name = "numericDonGia";
            this.numericDonGia.Size = new System.Drawing.Size(146, 27);
            this.numericDonGia.TabIndex = 13;
            // 
            // numericLuongTon
            // 
            this.numericLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLuongTon.Location = new System.Drawing.Point(830, 74);
            this.numericLuongTon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericLuongTon.Name = "numericLuongTon";
            this.numericLuongTon.Size = new System.Drawing.Size(146, 27);
            this.numericLuongTon.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lượng tồn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tác giả";
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Location = new System.Drawing.Point(454, 71);
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(158, 28);
            this.cbLoaiSach.TabIndex = 6;
            this.cbLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSach_SelectedIndexChanged);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(454, 22);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(158, 27);
            this.txtTacGia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(153, 46);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(160, 27);
            this.txtTenSach.TabIndex = 2;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(726, 107);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(122, 46);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(598, 107);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(122, 46);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // SachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSachSach);
            this.Name = "SachControl";
            this.Size = new System.Drawing.Size(1002, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLuongTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QUAN_LY_NHA_SACHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgvSachSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDonGia;
        private System.Windows.Forms.NumericUpDown numericLuongTon;
        private System.Windows.Forms.Button button_Xoa;
    }
}
