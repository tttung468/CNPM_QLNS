using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class HoaDonControl : UserControl
    {
        private int maHoaDon;
        private String sdtKhachHang;
        private int maSach;
        private int qd21;
        private int qd22;

        public HoaDonControl()
        {
            InitializeComponent();

            //Load quy dinh
            QuyDinhBUS quyDinhBUS = new QuyDinhBUS();
            this.qd21 = quyDinhBUS.getByID(3).GiaTri;
            this.qd22 = quyDinhBUS.getByID(4).GiaTri;

            //Load dgv phieu nhap
            LoadDgvHoaDon();

            //Load combobox Sach
            loadComboBoxTenSach();
        }

        private void LoadDgvHoaDon()
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            dgvHoaDon.DataSource = hoaDonBUS.getALlReturnDataTable();
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void loadComboBoxTenSach()
        {
            SachBUS sachBUS = new SachBUS();
            DataTable dt = sachBUS.getAllReturnDataTable();

            cbTenSach.DisplayMember = "Tên sách";
            cbTenSach.ValueMember = "Mã sách";
            cbTenSach.DataSource = dt;
        }

        private void cbTenSach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.maSach = (int)comboBox.SelectedValue;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0)
            {
                rowId = 0;
            }

            DataGridViewRow row = dgvHoaDon.Rows[rowId];
            this.maHoaDon = (int)row.Cells[0].Value;
            this.sdtKhachHang = row.Cells[3].Value.ToString();

            LoadDgvChiTietHoaDon();
        }

        private void LoadDgvChiTietHoaDon()
        {
            ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
            dgvChiTietHoaDon.DataSource = chiTietHoaDonBUS.getByMaHoaDonReturnDataTable(this.maHoaDon);
            dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void buttonLapHoaDon_Click(object sender, System.EventArgs e)
        {
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            KhachHang khachHang = khachHangBUS.getBySDT(txtDienThoai.Text);

            if(khachHang == null)
            {
                MessageBox.Show("Khách hàng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDonBUS hoaDonBUS = new HoaDonBUS();
                HoaDon hoaDon = new HoaDon();

                hoaDon.MaKhachHang = khachHang.MaKhachHang;
                hoaDon.NgayLapHD = DateTime.Now;

                if(hoaDonBUS.insert(hoaDon) == true)
                {
                    MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDgvHoaDon();
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaHoaDon_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ?",
               "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                HoaDonBUS hoaDonBUS = new HoaDonBUS();
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = this.maHoaDon;

                if (hoaDonBUS.delete(hoaDon) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvHoaDon();
            }
        }

        private void btnThemChiTiet_Click(object sender, System.EventArgs e)
        {
            SachBUS sachBUS = new SachBUS();
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            Sach sach = new Sach();

            KhachHang khachHang = khachHangBUS.getBySDT(this.sdtKhachHang);
            sach = sachBUS.getByID(this.maSach);
            int luongTonSauKhiBan = sach.SoLuongTonCuoi - Convert.ToInt32(numericLuongMua.Value);

            if (khachHang.SoTienNoCuoi > this.qd21)
            {
                MessageBox.Show("Khách hàng không được nợ quá " + this.qd21 + "",
                    "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(luongTonSauKhiBan < 20)
            {
                MessageBox.Show("Đầu sách sau khi bán có lượng tồn ít nhất " + this.qd21 + "",
                    "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();

                chiTietHoaDon.MaHoaDon = this.maHoaDon;
                chiTietHoaDon.MaSach = this.maSach;
                chiTietHoaDon.SoLuongMua = Convert.ToInt32(numericLuongMua.Value);
                sach.SoLuongTonCuoi = luongTonSauKhiBan;

                if(chiTietHoaDonBUS.insert(chiTietHoaDon) == true
                    && sachBUS.update(sach) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDgvChiTietHoaDon();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
