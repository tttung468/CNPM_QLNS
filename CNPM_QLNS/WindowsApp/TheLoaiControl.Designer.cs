namespace WindowsApp
{
    partial class TheLoaiControl
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
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.AllowUserToDeleteRows = false;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Location = new System.Drawing.Point(3, 3);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersWidth = 51;
            this.dgvTheLoai.RowTemplate.Height = 24;
            this.dgvTheLoai.Size = new System.Drawing.Size(548, 410);
            this.dgvTheLoai.TabIndex = 1;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTheLoai);
            this.panel1.Location = new System.Drawing.Point(593, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 215);
            this.panel1.TabIndex = 2;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(277, 126);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(122, 46);
            this.button_Xoa.TabIndex = 16;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(149, 126);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(122, 46);
            this.buttonSua.TabIndex = 15;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(21, 126);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(122, 46);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thể loại";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(162, 52);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(160, 27);
            this.txtTheLoai.TabIndex = 4;
            // 
            // TheLoaiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTheLoai);
            this.Name = "TheLoaiControl";
            this.Size = new System.Drawing.Size(1002, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button buttonSua;
    }
}
