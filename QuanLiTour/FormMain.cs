using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanQuyen;
using DevComponents;
using DevExpress.DXBinding;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;

namespace QuanLiTour
{

    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        List<string> b = new List<string>();
        NguoiDung CauHinh = new NguoiDung();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
        public void showForm(Form a){
            a.Dock = DockStyle.Fill;
            a.MdiParent = this;
            a.Show();
        }
        private void barButtonItem_DanhSachTourMo_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachTourMo a = new DanhSachTourMo();
            showForm(a);
        }
        private void btn_ThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTinTaiKhoan a = new ThongTinTaiKhoan();
            showForm(a);
        }

        private void btn_Admin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Admin frm = new Admin();
            frm.MdiParent = this;
            frm.Show();
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
                    List<string> a = CauHinh.getDatatable(txt_TenDangNhap.Text.Trim());
                    panel1.Hide();
                    CauHinh.PhanQuyen(ribbonControl_menu);
                }
                if (n == 2)
                    MessageBox.Show("Tài khoản không hoạt động !");
            }
            if (CauHinh.Check_Config() == 1)
            {
                CauHinhServer a = new CauHinhServer();
                a.Show();
            }
            if (CauHinh.Check_Config() == 2)
            {
                CauHinhServer a = new CauHinhServer();
                a.Show();
            }
        }


        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            CauHinh.DongPhanQuyen(ribbonControl_menu);
            b = null;
            panel1.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
