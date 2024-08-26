using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212390_DNTKhanh_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            var tenNhap = txtTen.Text;
            MessageBox.Show($"Chào bạn {tenNhap}. Bạn đến chơi à. ", "Chào Mừng");
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
