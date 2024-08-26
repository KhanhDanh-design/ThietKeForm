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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new FormBai1();
            form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form = new FormBai2();
            form.ShowDialog();
        }
    }
}
