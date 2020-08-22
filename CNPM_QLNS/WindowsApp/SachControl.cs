using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class SachControl : UserControl
    {
        private int maLoaiSach;
        private int maSach;

        public SachControl()
        {
            InitializeComponent();

            //set Border Style
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            //load sach
            dgvSachSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LoadDgvSach();

            //load txt_TenSach
            loadComboBoxLoaiSach();
        }

        private void loadComboBoxLoaiSach()
        {
            TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
            DataTable dt = theLoaiBUS.getAllReturnDataTable();

            cbLoaiSach.DisplayMember = "Tên thể loại";
            cbLoaiSach.ValueMember = "Mã thể loại";
            cbLoaiSach.DataSource = dt;
        }

        private void LoadDgvSach()
        {
            SachBUS sachBUS = new SachBUS();
            dgvSachSach.DataSource = sachBUS.getAllReturnDataTable();
        }

        private void dgvSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if(rowId < 0)
            {
                rowId = 0;
            }

            DataGridViewRow row = dgvSachSach.Rows[rowId];
            txtTenSach.Text = row.Cells[1].Value.ToString();
            cbLoaiSach.Text = row.Cells[2].Value.ToString();
            txtTacGia.Text = row.Cells[3].Value.ToString();
            numericLuongTon.Value = Convert.ToDecimal(row.Cells[4].Value);
            numericDonGia.Value = Convert.ToDecimal(row.Cells[5].Value);

            this.maSach = (int)row.Cells[0].Value;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Equals("") == true || txtTacGia.Text.Equals("") == true)
            {
                MessageBox.Show("Nhập dữ liệu để thêm thể loại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sach sach = new Sach(txtTenSach.Text, this.maLoaiSach, txtTacGia.Text, 0, 0, numericDonGia.Value);
            SachBUS sachBUS = new SachBUS();

            if(sachBUS.getByThuocTinh(sach.TenSach, sach.MaTheLoai, sach.TacGia) == null)
            {
                //Sach chua ton tai trong CSDL
                if(numericLuongTon.Value != 0)
                {
                    MessageBox.Show("Lượng tồn ban đầu phải bằng 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(sachBUS.insert(sach) == true)
                    {
                        LoadDgvSach();
                        MessageBox.Show("Sách '" + sach.TenSach + "' đã được thêm vào kho", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                //sach da ton tai
                MessageBox.Show("Sách '" + sach.TenSach +"' đã tồn tại trong kho", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Equals("") == true || txtTacGia.Text.Equals("") == true)
            {
                MessageBox.Show("Chọn sách cập nhật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sach sach = new Sach(txtTenSach.Text, this.maLoaiSach, txtTacGia.Text, 0, Convert.ToInt32(numericLuongTon.Value), numericDonGia.Value);
            sach.MaSach = this.maSach;
            SachBUS sachBUS = new SachBUS();

            if (sachBUS.update(sach) == true)
            {
                LoadDgvSach();
                MessageBox.Show("Sách '" + sach.TenSach + "' đã được cập nhật", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.maLoaiSach = (int) comboBox.SelectedValue;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Equals("") == true || txtTacGia.Text.Equals("") == true)
            {
                MessageBox.Show("Chọn sách để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách '" + txtTenSach.Text + "' hay không ?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dialogResult == DialogResult.Yes)
            {
                Sach sach = new Sach();
                sach.MaSach = this.maSach;
                SachBUS sachBUS = new SachBUS();

                if(sachBUS.delete(sach) == true)
                {
                    MessageBox.Show("Sách '" + sach.TenSach + "' đã được xóa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDgvSach();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
