using DTO;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            SachControl sachControl = new SachControl();
            showControl(sachControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            TheLoaiControl theLoaiControl = new TheLoaiControl();
            showControl(theLoaiControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            KhachHangControl khachHangControl = new KhachHangControl();
            showControl(khachHangControl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            NhapSachControl nhapSachControl = new NhapSachControl();
            showControl(nhapSachControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;

            HoaDonControl hoaDonControl = new HoaDonControl();
            showControl(hoaDonControl);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;

            BaoCaoThangControl baoCaoThangControl = new BaoCaoThangControl();
            showControl(baoCaoThangControl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;

            ThayDoiQuyDinhControl thayDoiQuyDinh = new ThayDoiQuyDinhControl();
            showControl(thayDoiQuyDinh);
        }

        private void showControl(Control control)
        {
            panelContent.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelContent.Controls.Add(control);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
