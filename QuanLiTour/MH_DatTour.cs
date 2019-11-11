using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTour
{
    public partial class MH_DatTour : Form
    {
        XuLiData xuli = new XuLiData();
        public MH_DatTour()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DataTable x = xuli.getDatatable("SELECT * FROM TOURDAT");//SHOW BANG
            xuli.LoadDataToGirdView(dataGridView_TourDat, x);
            loaddataToText();
        }
        private void MH_DatTour_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void loaddataToText()
        {
            txt_DiemDon.DataBindings.Clear();
            txt_DiemDon.DataBindings.Add("text", dataGridView_TourDat.DataSource, "DIEMDON");

            txt_NgayDat.DataBindings.Clear();
            txt_NgayDat.DataBindings.Add("text",dataGridView_TourDat.DataSource,"NGAYDAT");

            txt_TrangThai.DataBindings.Clear();
            txt_TrangThai.DataBindings.Add("text", dataGridView_TourDat.DataSource, "TRANGTHAI");

            txt_TongTien.DataBindings.Clear();
            txt_TongTien.DataBindings.Add("text",dataGridView_TourDat.DataSource,"TONGTIEN");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_MaTourDat_DropDown(object sender, EventArgs e)
        {
            //xuli.loadComboBox(cbo_MaTourDat,"")
        }

        private void cbo_MaLich_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaLich, "SELECT LICHKHOIHANH.MALICH FROM TOURDAT,LICHKHOIHANH WHERE TOURDAT.MALICH= LICHKHOIHANH.MALICH", "TENLICH", "MALICH");
        }

        private void cbo_MaDanhSach_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaDanhSach, "SELECT DANHSACHNGUOIDIKEM.MADANHSACH FROM TOURDAT,DANHSACHNGUOIDIKEM WHERE TOURDAT.MADANHSACH=DANHSACHNGUOIDIKEM.MADANHSACH", "TEN", "MADANHSACH");
        }

        private void cbo_MaKhachHang_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaKhachHang, "SELECT DANHSACHNGUOIDIKEM.MADANHSACH FROM TOURDAT,DANHSACHNGUOIDIKEM WHERE TOURDAT.MADANHSACH=DANHSACHNGUOIDIKEM.MADANHSACH","TENKHACHHANG", "MAKHACHHANG");
        }

        private void cbo_MaLoaiTT_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaLoaiTT, "SELECT MALOAITT FROM LOAITHANHTOAN", "TENLOAITT", "MALOAITT");
        }

        private void btn_ThemTourDat_Click(object sender, EventArgs e)
        {
            xuli.MoVaXoaTextBox(tableLayoutPanel_TTTourDat);
            dataGridView_TourDat.Enabled = false;
        }

        private void btn_SuaTourDat_Click(object sender, EventArgs e)
        {
            //linq mvc
        }

        private void cbo_MaKhachHang_DropDown_1(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaKhachHang, "SELECT MAKHACHHANG FROM KHACHHANG", "TENKHACHHANG", "MAKHACHHANG");
        }

        private void cbo_MaDanhSach_DropDown_1(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaDanhSach, "SELECT MADANHSACH FROM DANHSACHNGUOIDIKEM", "TEN", "MADANHSACH");
        }

        private void cbo_MaLich_DropDown_1(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaLich, "SELECT MALICH FROM LICHKHOIHANH", "TENLICH", "MALICH");
        }

        private void cbo_MaTour_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaTour, "SELECT MATOUR FROM TOUR", "TEN", "MATOUR");
        }

    }
}
