using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class ThayDoiQuyDinhControl : UserControl
    {
        public ThayDoiQuyDinhControl()
        {
            InitializeComponent();

            //load quy dinh
            LoadQuyDinh();
        }

        private void LoadQuyDinh()
        {
            QuyDinhBUS quyDinhBUS = new QuyDinhBUS();

            numericQD11.Text = quyDinhBUS.getByID(1).GiaTri.ToString();
            numericQD12.Text = quyDinhBUS.getByID(2).GiaTri.ToString();
            numericQD21.Text = quyDinhBUS.getByID(3).GiaTri.ToString();
            numericQD22.Text = quyDinhBUS.getByID(4).GiaTri.ToString();

            if(quyDinhBUS.getByID(5).GiaTri == 1)
            {
                checkBoxQD4.Checked = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (numericQD11.Text.Equals("") == true || numericQD12.Text.Equals("") == true
                || numericQD21.Text.Equals("") == true || numericQD22.Text.Equals("") == true)
            {
                MessageBox.Show("Quy định không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật các quy định",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                QuyDinhBUS quyDinhBUS = new QuyDinhBUS();
                QuyDinh qd11 = quyDinhBUS.getByID(1);
                QuyDinh qd12 = quyDinhBUS.getByID(2);
                QuyDinh qd21 = quyDinhBUS.getByID(3);
                QuyDinh qd22 = quyDinhBUS.getByID(4);
                QuyDinh qd4 = quyDinhBUS.getByID(5);

                qd11.GiaTri = Convert.ToInt32(numericQD11.Value);
                qd12.GiaTri = Convert.ToInt32(numericQD12.Value);
                qd21.GiaTri = Convert.ToInt32(numericQD21.Value);
                qd22.GiaTri = Convert.ToInt32(numericQD22.Value);
                if(checkBoxQD4.Checked == true)
                {
                    qd4.GiaTri = Convert.ToInt32(1);
                }
                else
                {
                    qd4.GiaTri = Convert.ToInt32(-1);
                }

                if (quyDinhBUS.update(qd11) == true && quyDinhBUS.update(qd12) == true && quyDinhBUS.update(qd21) == true
                    && quyDinhBUS.update(qd22) == true && quyDinhBUS.update(qd4) == true)
                {
                    MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
