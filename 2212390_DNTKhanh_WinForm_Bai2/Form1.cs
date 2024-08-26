using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212390_DNTKhanh_WinForm_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNam.Checked)
            MessageBox.Show("Bạn là nam.", "Thông báo");
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNu.Checked)
                MessageBox.Show("Bạn là nữ.", "Thông báo");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(rbDo.Checked)
                txtToMau.BackColor =Color.Red;
            if (rbXanh.Checked)
                txtToMau.BackColor = Color.Blue;
        }
    }
}
