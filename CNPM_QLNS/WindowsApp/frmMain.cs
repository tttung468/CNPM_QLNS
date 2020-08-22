using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            sachControl1.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_NHA_SACHDataSet.Sach' table. You can move, or remove it, as needed.
            /*dgv_Sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Sach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LoadDanhSachSach();*/
        }

        /*private void LoadDanhSachSach()
        {
            SachDAO sachDAO = new SachDAO();
            dgv_Sach.DataSource = sachDAO.getAllForDgvSach();
        }*/


        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            sachControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            theLoaiControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            khachHangControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            nhapSachControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            hoaDonControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            baoCaoThangControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            thayDoiQuyDinhControl1.BringToFront();
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
    }
}
