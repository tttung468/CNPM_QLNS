using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class KhachHangControl : UserControl
    {
        private int maKhachHang;
        public KhachHangControl()
        {
            InitializeComponent();

            //load dgvKhachHang
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LoadDgvKhachHang();
        }

        private void LoadDgvKhachHang()
        {
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            dgvKhachHang.DataSource = khachHangBUS.getAllReturnDataTable();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0)
            {
                rowId = 0;
            }

            DataGridViewRow row = dgvKhachHang.Rows[rowId];
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
            numericTienNo.Value = Convert.ToDecimal(row.Cells[4].Value);

            this.maKhachHang = (int)row.Cells[0].Value;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Equals("") == true || txtDienThoai.Text.Equals("") == true || txtHoTen.Text.Equals("") == true)
            {
                MessageBox.Show("Nhập dữ liệu để thêm khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KhachHang khachHang = new KhachHang(txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text, 0, numericTienNo.Value);
            KhachHangBUS khachHangBUS = new KhachHangBUS();

            if (khachHangBUS.getBySDT(txtDienThoai.Text) == null)
            {
                //sdt chua dc su dung
                if (numericTienNo.Value != 0)
                {
                    MessageBox.Show("Tiền nợ ban đầu phải bằng 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txtDienThoai.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ, phải có 10 chữ số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (khachHangBUS.insert(khachHang) == true)
                    {
                        LoadDgvKhachHang();
                        MessageBox.Show("Khách hàng '" + khachHang.HoTen + "' đã được thêm", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //sdt da dc su dung
                MessageBox.Show("Số điện thoại '" + txtDienThoai.Text + "' đã được sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Equals("") == true || txtDienThoai.Text.Equals("") == true || txtHoTen.Text.Equals("") == true)
            {
                MessageBox.Show("Chọn khách hàng để cập nhật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KhachHangBUS khachHangBUS = new KhachHangBUS();
            KhachHang khachHang = khachHangBUS.getBySDT(txtDienThoai.Text);

            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.HoTen = txtHoTen.Text;
            khachHang.SoTienNoCuoi = numericTienNo.Value;

            if (khachHangBUS.update(khachHang) == true)
            {
                LoadDgvKhachHang();
                MessageBox.Show("Khách hàng '" + khachHang.HoTen + "' đã được cập nhật", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Equals("") == true || txtDienThoai.Text.Equals("") == true || txtHoTen.Text.Equals("") == true)
            {
                MessageBox.Show("Chọn khách hàng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng có SDT '" + txtDienThoai.Text + "' không ?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
