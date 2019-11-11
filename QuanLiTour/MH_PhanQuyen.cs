using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTour {
    public partial class MH_PhanQuyen : Form {
        XuLiData xuli = new XuLiData ();
        public MH_PhanQuyen () {
            InitializeComponent ();
        }

        private void cbo_NhomNguoiDung_DropDown (object sender, EventArgs e) {
            xuli.loadComboBox (cbo_NhomNguoiDung, "SELECT * FROM QL_NhomNguoiDung", "TenNhom", "MaNhom");
        }

        private void MH_NhomNguoiDung_Load (object sender, EventArgs e) {
            DataTable a = xuli.getDatatable ("SELECT * FROM QL_NguoiDung");
            xuli.LoadDataToGirdView (dataGridView_NguoiDung, a);
            DataTable b = xuli.getDatatable ("select QL_NguoiDung.TenDangNhap,QL_NguoiDung.MatKhau,QL_NguoiDung.TinhTrang from QL_NguoiDung,QL_NguoiDungNhomNguoiDung where QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap and QL_NguoiDungNhomNguoiDung.MaNhom = '" + "NH001" + "'");
            xuli.LoadDataToGirdView (dataGridView_NHomNguoiDung, b);
        }

        private void btn_ThemUser_Nhom_Click (object sender, EventArgs e) {
            int row = dataGridView_NguoiDung.CurrentRow.Index; //lấy ra chỉ số của row đang đc chọn
            string tendangnhap = dataGridView_NguoiDung.Rows[row].Cells[0].Value.ToString ().Trim ();
            string sqlInsert = "INSERT INTO QL_NguoiDungNhomNguoiDung(TenDangNhap,MaNhom, GhiChu) VALUES('" + tendangnhap + "', '" + cbo_NhomNguoiDung.SelectedValue.ToString ().Trim () + "','" + "Ghi chú" + "')";
            xuli.RunCommand (sqlInsert);
            MessageBox.Show ("thêm thành công");
            MH_NhomNguoiDung_Load (sender, e);
        }

        private void btn_XoaUser_Nhom_Click (object sender, EventArgs e) {
            int row = dataGridView_NHomNguoiDung.CurrentRow.Index;
            string tendangnhap = dataGridView_NHomNguoiDung.Rows[row].Cells[0].Value.ToString ().Trim ();
            string nhom = cbo_NhomNguoiDung.SelectedValue.ToString ().Trim ();
            MessageBox.Show (tendangnhap);
            string sqldelete = "delete QL_NguoiDungNhomNguoiDung where TenDangNhap='" + tendangnhap + "' and MaNhom='" + nhom + "'";
            MessageBox.Show (sqldelete);
            xuli.RunCommand (sqldelete);
            MH_NhomNguoiDung_Load (sender, e);
        }

        private void cbo_NhomNguoiDung_SelectedIndexChanged (object sender, EventArgs e) {
            DataTable a = xuli.getDatatable ("select * from QL_NguoiDung, QL_NguoiDungNhomNguoiDung where QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap and QL_NguoiDungNhomNguoiDung.MaNhom != '" + cbo_NhomNguoiDung.SelectedValue.ToString () + "'");
            xuli.LoadDataToGirdView (dataGridView_NguoiDung, a);
            DataTable b = xuli.getDatatable ("select QL_NguoiDung.TenDangNhap,QL_NguoiDung.MatKhau,QL_NguoiDung.TinhTrang from QL_NguoiDung,QL_NguoiDungNhomNguoiDung where QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap and QL_NguoiDungNhomNguoiDung.MaNhom = '" + cbo_NhomNguoiDung.SelectedValue.ToString () + "'");
            xuli.LoadDataToGirdView (dataGridView_NHomNguoiDung, b);
        }
    }
}