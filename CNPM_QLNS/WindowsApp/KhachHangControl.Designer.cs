namespace WindowsApp
{
    partial class KhachHangControl
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
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericTienNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new WindowsApp.QUAN_LY_NHA_SACHDataSetTableAdapters.TableAdapterManager();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTienNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(615, 50);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(122, 46);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(743, 50);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(122, 46);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(141, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(430, 22);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(158, 27);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(871, 50);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(122, 46);
            this.button_Xoa.TabIndex = 14;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericTienNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDienThoai);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Location = new System.Drawing.Point(3, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 118);
            this.panel1.TabIndex = 3;
            // 
            // numericTienNo
            // 
            this.numericTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTienNo.Location = new System.Drawing.Point(141, 69);
            this.numericTienNo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericTienNo.Name = "numericTienNo";
            this.numericTienNo.Size = new System.Drawing.Size(160, 27);
            this.numericTienNo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tiền nợ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(430, 69);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(158, 27);
            this.txtDienThoai.TabIndex = 15;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.SachTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsApp.QUAN_LY_NHA_SACHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 9);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(996, 413);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // KhachHangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHangControl";
            this.Size = new System.Drawing.Size(1002, 564);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTienNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private QUAN_LY_NHA_SACHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.NumericUpDown numericTienNo;
    }
}
