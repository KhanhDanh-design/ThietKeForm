using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212390_DNTKhanh_WinForm_BT_ThietKeForm
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }


     

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            txtTong.Text= soTien.ToString();
        }

        private void rbTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void rbXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }
    }
}
