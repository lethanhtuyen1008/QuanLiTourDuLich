using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PhanQuyen;

namespace QuanLiTour
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        NguoiDung CauHinh = new NguoiDung();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lbl_TenDangNhap.Text.ToLower());
                this.txt_TenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txt_MatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lbl_MatKhau.Text.ToLower());
                this.txt_MatKhau.Focus();
                return;
            }
            if (CauHinh.Check_Config() == 0)
            {
                int n = CauHinh.Check_User(txt_TenDangNhap.Text, txt_MatKhau.Text);
                if (n == 0)
                    MessageBox.Show("Tên đăng nhập không tồn tại !");
                if (n == 1)
                {
                    MessageBox.Show("Đăng nhâp thành công !");
                    List<string> a = CauHinh.getDatatable(txt_TenDangNhap.Text);
                    this.Hide();
                    FormMain frm = new FormMain();
                    frm.Show();

                }
                if (n == 2)
                    MessageBox.Show("Tài khoản không hoạt động !");
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
    }
}