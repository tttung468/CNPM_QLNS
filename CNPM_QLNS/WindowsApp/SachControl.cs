using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;

namespace WindowsApp
{
    public partial class SachControl : UserControl
    {
        public SachControl()
        {
            InitializeComponent();

            //load sach
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LoadDgvSach();

            //set Border Style
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void LoadDgvSach()
        {
            dgvSach.DataSource = (new SachBUS()).getAllForDgvSach();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void SachControl_Load(object sender, EventArgs e)
        {

        }
    }
}
