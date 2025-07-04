using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmManHinhChinh: Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }
        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDoUong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
