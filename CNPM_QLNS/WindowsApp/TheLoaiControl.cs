using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class TheLoaiControl : UserControl
    {
        private int maTheLoai;
        public TheLoaiControl()
        {
            InitializeComponent();

            //load table the loai
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LoadDgvTheLoai();
        }

        private void LoadDgvTheLoai()
        {
            TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
            dgvTheLoai.DataSource = theLoaiBUS.getAllReturnDataTable();
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0)
            {
                rowId = 0;
            }

            DataGridViewRow row = dgvTheLoai.Rows[rowId];
            txtTheLoai.Text = row.Cells[1].Value.ToString();
            this.maTheLoai = (int)row.Cells[0].Value;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if(txtTheLoai.Text.Equals("") == true)
            {
                MessageBox.Show("Nhập dữ liệu để thêm thể loại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TheLoai theLoai = new TheLoai(txtTheLoai.Text);
            TheLoaiBUS theLoaiBUS = new TheLoaiBUS();

            if(theLoaiBUS.getByTenTheLoai(theLoai.TenTheLoai) == null)
            {
                //chua ton tai the loai trong CSDL
                if(theLoaiBUS.insert(theLoai) == true)
                {
                    LoadDgvTheLoai();
                    MessageBox.Show("Thêm thể loại '" + theLoai.TenTheLoai + "' thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm thể loại '" + theLoai.TenTheLoai + "' thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //da ton tai trong CSDL
                MessageBox.Show("Thể loại '" + theLoai.TenTheLoai + "' đã tồn tại trong CSDL", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (txtTheLoai.Text.Equals("") == true)
            {
                MessageBox.Show("Chọn thể loại để cập nhật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TheLoai theLoai = new TheLoai(txtTheLoai.Text);
            theLoai.MaTheLoai = this.maTheLoai;
            TheLoaiBUS theLoaiBUS = new TheLoaiBUS();

            if(theLoaiBUS.update(theLoai) == true)
            {
                LoadDgvTheLoai();
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (txtTheLoai.Text.Equals("") == true)
            {
                MessageBox.Show("Chọn thể loại để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại '" + txtTheLoai.Text + "' hay không ?",
               "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                TheLoai theLoai = new TheLoai(txtTheLoai.Text);
                theLoai.MaTheLoai = this.maTheLoai;
                TheLoaiBUS theLoaiBUS = new TheLoaiBUS();

                if (theLoaiBUS.delete(theLoai) == true)
                {
                    MessageBox.Show("Thể loại '" + theLoai.TenTheLoai + "' đã được xóa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDgvTheLoai();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
