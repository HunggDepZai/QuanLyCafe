using coffee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmDangNhap: Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaDangNhap.Text))
            {
                MessageBox.Show("Chưa nhập thông tin mã đăng nhập");
                txtMaDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Chưa nhập thông tin mật khẩu");
                txtMaDangNhap.Focus();
                return;
            }

            //$@
            /*
            string strSQL = $"SELECT * FROM NhanVien WHERE MaNV = '{txtMaDangNhap.Text}' AND MatKhau = '{txtMatKhau.Text}'";
            bool check = ConnectSQL.ExecuteReader_bool(strSQL);
            */
            string query = "SELECT * FROM NhanVien WHERE TaiKhoan = @manv AND MatKhau = @matkhau";
            SqlParameter[] parameters = {
    new SqlParameter("@manv", txtMaDangNhap.Text),
    new SqlParameter("@matkhau", txtMatKhau.Text)
};
            bool check = ConnectSQL.ExecuteReader_bool(query, parameters);
            if (check)
            {
                frmManHinhChinh frm = new frmManHinhChinh();
                frm.ShowDialog();
            }    
            else
            {
                MessageBox.Show("Sai thông tin mã đăng nhập hoặc mật khẩu");
                txtMaDangNhap.Focus();
                return;
            }  
            
            
        }

        private void txtMaDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
