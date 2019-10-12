using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NguoiDung
{
    public partial class Login : UserControl
    {
        QLNguoiDung CauHinh = new QLNguoiDung();
        public Login()
        {
            InitializeComponent();
        }

        

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblTenDangNhap.Text.ToLower());
                this.txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblMatKhau.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            if (CauHinh.Check_Config() == 0)
            {
                int n = CauHinh.Check_User(txtTenDangNhap.Text, txtMatKhau.Text);
                if (n == 0)
                    MessageBox.Show("Tên đăng nhập không tồn tại");
                if (n == 1)
                    MessageBox.Show("Đăng nhâp thành công");
                if (n == 2)
                    MessageBox.Show("Tài khoản không hoạt động");
            }
            //if (CauHinh.Check_Config() == 1)
            //{
            //    MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
            //    XuLiCauHinh a = new XuLiCauHinh();
            //    a.Show();
            //}
            //if (CauHinh.Check_Config() == 2)
            //{
            //    MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
            //    XuLiCauHinh a = new XuLiCauHinh();
            //    a.Show();
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
