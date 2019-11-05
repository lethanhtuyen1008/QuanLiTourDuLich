using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLiTour;
using DTO_QuanLiTour;
using DAL_QuanLiTour;

namespace QuanLiTour {
    public partial class MH_Admin : Form {
        XuLiData xuli = new XuLiData ();
        BUS_QLNguoiDung busNguoiDung = new BUS_QLNguoiDung();
        public MH_Admin () {
            InitializeComponent ();
        }
        public void LoadData () {
            xuli.LoadDataToGirdView(dataGridView_NguoiDung,busNguoiDung.getListNguoiDung());
            loaddataToText ();
        }
        private void Admin_Load (object sender, EventArgs e) {
            LoadData ();
        }
        private void loaddataToText () {
            txt_TenDangNhap.DataBindings.Clear ();
            txt_TenDangNhap.DataBindings.Add ("Text", dataGridView_NguoiDung.DataSource, "TenDangNhap");

            txt_MatKhau.DataBindings.Clear();
            txt_MatKhau.DataBindings.Add("Text", dataGridView_NguoiDung.DataSource, "MatKhau");

            txt_Ho.DataBindings.Clear ();
            txt_Ho.DataBindings.Add ("Text", dataGridView_NguoiDung.DataSource, "Ho");

            txt_Ten.DataBindings.Clear ();
            txt_Ten.DataBindings.Add ("Text", dataGridView_NguoiDung.DataSource, "Ten");

            txt_NamSinh.DataBindings.Clear ();
            txt_NamSinh.DataBindings.Add ("Text", dataGridView_NguoiDung.DataSource, "NamSinh");

            txt_Luong.DataBindings.Clear ();
            txt_Luong.DataBindings.Add ("Text", dataGridView_NguoiDung.DataSource, "Luong");

            cbo_GioiTinh.DataBindings.Clear ();
            cbo_GioiTinh.DataBindings.Add ("Text", dataGridView_NguoiDung.DataSource, "GioiTinh");
        }

        private void btn_Tim_Click (object sender, EventArgs e) {
            DataTable x = xuli.getDatatable ("SELECT * FROM QL_NguoiDung WHERE TenDangNhap like '%" + txt_Tim.Text.Trim () + "%'");
            xuli.LoadDataToGirdView (dataGridView_NguoiDung, x);
            loaddataToText ();
        }
        bool check = true;
        private void btn_ThemNguoiDung_Click (object sender, EventArgs e) {
            xuli.MoVaXoaTextBox (tableLayoutPanel_TTNguoiDung);
            dataGridView_NguoiDung.Enabled = false;
            check = true;
        }
        private void btn_Luu_Click (object sender, EventArgs e) {
            try {
                if (check)
                {
                    DTO_QLNguoiDung ndadd = new DTO_QLNguoiDung(txt_TenDangNhap.Text, 1, txt_Ho.Text, txt_Ten.Text, int.Parse(txt_NamSinh.Text), cbo_GioiTinh.Text, decimal.Parse(txt_Luong.Text));
                    if (busNguoiDung.AddNguoiDung(ndadd))
                    {
                        MessageBox.Show("Thêm người dùng thành công");
                    }
                    else
                        MessageBox.Show("Thêm người dùng không thành công");
                }
                else {
                    DTO_QLNguoiDung ndupdate = new DTO_QLNguoiDung(txt_TenDangNhap.Text, int.Parse(cbo_TinhTrang.Text), txt_Ho.Text, txt_Ten.Text, int.Parse(txt_NamSinh.Text), cbo_GioiTinh.Text, decimal.Parse(txt_Luong.Text));
                    if (busNguoiDung.UpdateNguoiDung(ndupdate))
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công");
                }
            } catch {
                    MessageBox.Show("Lưu thất bại");
            }
            dataGridView_NguoiDung.Enabled = true;
            xuli.DongTextBox (tableLayoutPanel_TTNguoiDung);
            LoadData ();
            check = true;
        }
        private void btn_XoaNguoiDung_Click (object sender, EventArgs e) {
            DialogResult dlr = MessageBox.Show ("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes) {
                bool check = busNguoiDung.deleteNguoiDung(txt_TenDangNhap.Text);
                if (check)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }
                else {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                LoadData ();
            }
        }

        private void btn_SuaNguoiDung_Click (object sender, EventArgs e) {
            xuli.MoTextBox (tableLayoutPanel_TTNguoiDung);
            txt_TenDangNhap.Enabled = false;
            check = false;
            dataGridView_NguoiDung.Enabled = false;
        }

        private void txt_Tim_KeyPress (object sender, KeyPressEventArgs e) {
            DataTable x = xuli.getDatatable ("SELECT * FROM QL_NguoiDung WHERE TenDangNhap like '%" + txt_Tim.Text.Trim () + "%'");
            xuli.LoadDataToGirdView (dataGridView_NguoiDung, x);
            loaddataToText ();
        }
    }
}