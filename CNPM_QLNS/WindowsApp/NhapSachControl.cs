using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class NhapSachControl : UserControl
    {
        private int maPhieuNhap;
        private int maSach;
        private int qd11;
        private int qd12;
        public NhapSachControl()
        {
            InitializeComponent();

            //load quy dinh
            QuyDinhBUS quyDinhBUS = new QuyDinhBUS();
            this.qd11 = quyDinhBUS.getByID(1).GiaTri;
            this.qd12 = quyDinhBUS.getByID(2).GiaTri;

            //Load dgv phieu nhap
            LoadDgvPhieuNhap();

            //Load combobox Sach
            loadComboBoxTenSach();
        }

        private void LoadDgvPhieuNhap()
        {
            PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
            dgvPhieuNhap.DataSource = phieuNhapBUS.getAllReturnDataTable();
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void loadComboBoxTenSach()
        {
            SachBUS sachBUS = new SachBUS();
            DataTable dt = sachBUS.getAllReturnDataTable();

            cbTenSach.DisplayMember = "Tên sách";
            cbTenSach.ValueMember = "Mã sách";
            cbTenSach.DataSource = dt;
        }

        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.maSach = (int)comboBox.SelectedValue;
        }

        private void dgcPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0)
            {
                rowId = 0;
            }

            DataGridViewRow row = dgvPhieuNhap.Rows[rowId];
            this.maPhieuNhap = (int)row.Cells[0].Value;

            LoadDgvChiTietPhieuNhap();
        }

        private void LoadDgvChiTietPhieuNhap()
        {
            ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
            dgvChiTietPhieuNhap.DataSource = chiTietPhieuNhapBUS.getByMaPhieuNhapReturnDataTable(this.maPhieuNhap);
            dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void buttonLapPhieuNhap_Click(object sender, EventArgs e)
        {
            PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
            PhieuNhap phieuNhap = new PhieuNhap();

            phieuNhap.NgayNhap = DateTime.Now;
            phieuNhapBUS.insert(phieuNhap);
            LoadDgvPhieuNhap();
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
                PhieuNhap phieuNhap = new PhieuNhap();

                phieuNhap.MaPhieuNhap = this.maPhieuNhap;
                if(phieuNhapBUS.delete(phieuNhap) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvPhieuNhap();
            }

              
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            SachBUS sachBUS = new SachBUS();
            Sach sach = new Sach();
            sach = sachBUS.getByID(this.maSach);

            //kiem tra dieu kien
            if(numericLuongNhap.Value < this.qd11)
            {
                MessageBox.Show("Số lượng nhập phải ít nhất là " + this.qd11, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(sach.SoLuongTonCuoi > this.qd12)
            {
                MessageBox.Show("Số lượng tồn phải ít hơn " + this.qd12, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();

                chiTietPhieuNhap.MaPhieuNhap = this.maPhieuNhap;
                chiTietPhieuNhap.MaSach = this.maSach;
                chiTietPhieuNhap.SoLuongNhap = Convert.ToInt32(numericLuongNhap.Value);
                sach.SoLuongTonCuoi += Convert.ToInt32(numericLuongNhap.Value);

                if(chiTietPhieuNhapBUS.insert(chiTietPhieuNhap) == true
                    && sachBUS.update(sach) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDgvChiTietPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
                
            }                
        }

        
    }
}
