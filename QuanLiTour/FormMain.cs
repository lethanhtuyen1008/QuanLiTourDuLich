using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents;
using DevExpress.DXBinding;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;
using PhanQuyen;

namespace QuanLiTour {

    public partial class FormMain : DevExpress.XtraEditors.XtraForm {
        List<string> b = new List<string> ();
        NguoiDung CauHinh = new NguoiDung ();
        public FormMain () {
            InitializeComponent ();
        }
        private void FormMain_Load (object sender, EventArgs e) {

        }
        public void showForm (Form a) {
            a.Dock = DockStyle.Fill;
            a.MdiParent = this;
            a.Show ();
        }
        private void barButtonItem_DanhSachTourMo_ItemClick (object sender, ItemClickEventArgs e) {
            MH_QuanLyTour a = new MH_QuanLyTour ();
            showForm (a);
        }
        private void btn_ThongTin_ItemClick (object sender, ItemClickEventArgs e) {
            MH_ThongTinTaiKhoan a = new MH_ThongTinTaiKhoan ();
            showForm (a);
        }
        private void btn_Admin_ItemClick (object sender, ItemClickEventArgs e) {
            MH_Admin frm = new MH_Admin ();
            frm.MdiParent = this;
            frm.Show ();
        }
        private void btn_DangNhap_Click (object sender, EventArgs e) {
            if (string.IsNullOrEmpty (txt_TenDangNhap.Text.Trim ())) {
                MessageBox.Show ("Không được bỏ trống " + lbl_TenDangNhap.Text.ToLower ());
                this.txt_TenDangNhap.Focus ();
                return;
            }

            if (string.IsNullOrEmpty (this.txt_MatKhau.Text)) {
                MessageBox.Show ("Không được bỏ trống " + lbl_MatKhau.Text.ToLower ());
                this.txt_MatKhau.Focus ();
                return;
            }
            if (CauHinh.Check_Config () == 0) {
                int n = CauHinh.Check_User (txt_TenDangNhap.Text, txt_MatKhau.Text);
                if (n == 0)
                    MessageBox.Show ("Tên đăng nhập không tồn tại !");
                if (n == 1) {
                    MessageBox.Show ("Đăng nhâp thành công !");
                    List<string> a = CauHinh.getDatatable (txt_TenDangNhap.Text.Trim ());
                    panel1.Hide ();
                    CauHinh.PhanQuyen (ribbonControl_menu, a);
                }
                if (n == 2)
                    MessageBox.Show ("Tài khoản không hoạt động !");
            }
            if (CauHinh.Check_Config () == 1) {
                CauHinhServer a = new CauHinhServer ();
                a.Show ();
            }
            if (CauHinh.Check_Config () == 2) {
                CauHinhServer a = new CauHinhServer ();
                a.Show ();
            }
        }

        private void btn_DangXuat_ItemClick (object sender, ItemClickEventArgs e) {
            CauHinh.DongPhanQuyen (ribbonControl_menu);
            b = null;
            panel1.Show ();
        }
        private void btn_Thoat_Click (object sender, EventArgs e) {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_PhanQuyen_ItemClick (object sender, ItemClickEventArgs e) {
            MH_PhanQuyen frm = new MH_PhanQuyen ();
            frm.MdiParent = this;
            frm.Show ();
        }

        private void btn_NhomNguoiDung_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            MH_NhomNguoiDung frm = new MH_NhomNguoiDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_Thoat_Click(sender, e);
        }

        private void btn_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_TourDatGanDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            MH_DatTour a = new MH_DatTour();
            showForm(a);
        }

        private void btn_DanhSachTourDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btn_QLKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            MH_KhachHang a = new MH_KhachHang();
            showForm(a);
        }

        private void btn_KhachSan_ItemClick(object sender, ItemClickEventArgs e)
        {
            MH_KhachSan a = new MH_KhachSan();
            showForm(a);
        }

        private void btn_ChiTietTour_ItemClick(object sender, ItemClickEventArgs e)
        {
            MH_ChiTietTour a = new MH_ChiTietTour();
            showForm(a);
        }
    }
}