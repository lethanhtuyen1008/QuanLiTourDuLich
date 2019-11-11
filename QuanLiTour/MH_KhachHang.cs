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
// lúc nào cũng using ba cái này.. ởo dđâu cũng vậy
namespace QuanLiTour
{
    public partial class MH_KhachHang : Form
    {
        XuLiData xuli = new XuLiData();
        BUS_KhachHang buskh = new BUS_KhachHang();

        public MH_KhachHang()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DataTable da = buskh.getKhachHang();
            xuli.LoadDataToGirdView(dataGridView_KhachHang, da);
            loadDataToText();
        }
        private void loadDataToText()
        {
            cbo_MaKhachHang.DataBindings.Clear();
            cbo_MaKhachHang.DataBindings.Add("text", dataGridView_KhachHang.DataSource, "MaKhachHang");

            txt_TenKhachHang.DataBindings.Clear();
            txt_TenKhachHang.DataBindings.Add("text", dataGridView_KhachHang.DataSource, "TenKhachHang");

            txt_Email.DataBindings.Clear();
            txt_Email.DataBindings.Add("text", dataGridView_KhachHang.DataSource, "Email");

            txt_DienThoai.DataBindings.Clear();
            txt_DienThoai.DataBindings.Add("text", dataGridView_KhachHang.DataSource, "DienThoai");

            txt_NgaySinh.DataBindings.Clear();
            txt_NgaySinh.DataBindings.Add("text", dataGridView_KhachHang.DataSource, "NgaySinh");

            txt_DiaChi.DataBindings.Clear();
            txt_DiaChi.DataBindings.Add("text", dataGridView_KhachHang.DataSource, "DiaChi");
        }
        private void MH_KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            xuli.MoTextBox(tableLayoutPanel_TTKhachHang);
            cbo_MaKhachHang.Enabled = false;
            txt_TenKhachHang.Enabled = true;
            txt_Email.Enabled = true;
            txt_DienThoai.Enabled = true;
            txt_NgaySinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            check = true;
            dataGridView_KhachHang.Enabled = false;
            int a = xuli.GetCountRowData(dataGridView_KhachHang, 0);
            string MaKH;
            if (a < 10)
            {
                MaKH = "KH00" + a;
            }
            else//
            {
                MaKH = "KH0" + a;
            }
            cbo_MaKhachHang.Text = MaKH;
        }

        private void btn_TimKhachHang_Click(object sender, EventArgs e)
        {
            DataTable x = xuli.getDatatable("SELECT * FROM KHACHHANG WHERE TENKHACHHANG like '%" + txt_TimKhachHang.Text.Trim() + "%'");
            xuli.LoadDataToGirdView(dataGridView_KhachHang, x);
            loadDataToText();
        }
        bool check = true;

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            buskh.deleteKhachHang(cbo_MaKhachHang.Text);
        }

        private void btn_SuaKhachHang_Click(object sender, EventArgs e)
        {
            xuli.MoTextBox(tableLayoutPanel_TTKhachHang);
            cbo_MaKhachHang.Enabled = false;
            txt_TenKhachHang.Enabled = true;
            txt_Email.Enabled = true;
            txt_DienThoai.Enabled = true;
            txt_NgaySinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            check = false;
            dataGridView_KhachHang.Enabled = false;
        }

        private void btn_LuuKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (check)
                {
                    DTO_KhachHang khadd = new DTO_KhachHang(cbo_MaKhachHang.Text, txt_TenKhachHang.Text, txt_Email.Text, int.Parse(txt_DienThoai.Text), DateTime.Parse(txt_NgaySinh.Text), txt_DiaChi.Text);
                    if (buskh.addKhachHang(khadd))
                    {
                        MessageBox.Show("Thêm người dùng thành công");
                    }
                    else
                        MessageBox.Show("Thêm người dùng không thành công");
                }
                else
                {
                    DTO_KhachHang khupdate = new DTO_KhachHang(cbo_MaKhachHang.Text, txt_TenKhachHang.Text, txt_Email.Text, int.Parse(txt_DienThoai.Text), DateTime.Parse(txt_NgaySinh.Text), txt_DiaChi.Text);
                    if (buskh.updateKhachHang(khupdate))
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }
            dataGridView_KhachHang.Enabled = true;
            xuli.DongTextBox(tableLayoutPanel_TTKhachHang);
            LoadData();
            check = true;
        }

    }
}
