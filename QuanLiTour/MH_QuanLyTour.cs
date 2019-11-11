using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using BUS_QuanLiTour;
using DTO_QuanLiTour;
using System.Drawing.Imaging;

namespace QuanLiTour
{
    public partial class MH_QuanLyTour : Form
    {
        XuLiData xuli = new XuLiData();
        BUS_Tours busTours = new BUS_Tours();
        BUS_ChuongTrinhTour busCTTour = new BUS_ChuongTrinhTour();
        string imglocation = "";//string filename
        public MH_QuanLyTour()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            xuli.LoadDataToGirdView(dataGridView_QuanLyTour, busTours.getListTour());

        }
        public void loaddatatoText()
        {
            int row = dataGridView_QuanLyTour.CurrentRow.Index; //lấy ra chỉ số của row đang đc chọn
            string data = dataGridView_QuanLyTour.Rows[row].Cells[0].Value.ToString();
            //MessageBox.Show(data);
            //MemoryStream memo = new MemoryStream(busTours.getImageTour(data));
            txt_MaTour.DataBindings.Clear();
            txt_MaTour.DataBindings.Add("Text", dataGridView_QuanLyTour.DataSource, "MATOUR");

            cbo_MaLoai.DataBindings.Clear();
            cbo_MaLoai.DataBindings.Add("Text", dataGridView_QuanLyTour.DataSource, "MALOAI");

            txt_TenTour.DataBindings.Clear();
            txt_TenTour.DataBindings.Add("Text", dataGridView_QuanLyTour.DataSource, "TENTOUR");

            txt_SoCho.DataBindings.Clear();
            txt_SoCho.DataBindings.Add("Text", dataGridView_QuanLyTour.DataSource, "SOCHO");

            txt_SoNgay.DataBindings.Clear();
            txt_SoNgay.DataBindings.Add("Text", dataGridView_QuanLyTour.DataSource, "SONGAY");
        }

        private void MH_QuanLyTour_Load(object sender, EventArgs e)
        {
            LoadData();
            loaddatatoText();
            xuli.loadComboBox(cbo_MaLoai, "SELECT * FROM LOAITOUR", "TENLOAI", "MALOAI");
        }
        bool check = true;
        private void btn_ThemTour_Click(object sender, EventArgs e)
        {
            xuli.MoVaXoaTextBox(tableLayoutPanel_TTTours);
            string matour = xuli.GetCountRowData(dataGridView_QuanLyTour, 0, "MT");
            btn_ChonAnh.Visible = true;
            check = true;
            txt_MaTour.Text = matour;
            txt_MaTour.Enabled = false;
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            btn_ChonAnh.Visible = true;
            check = false;
            txt_MaTour.Enabled = false;
        }

        private void btn_XoaTour_Click(object sender, EventArgs e)
        {
            int row = dataGridView_QuanLyTour.CurrentRow.Index; //lấy ra chỉ số của row đang đc chọn
            string data = dataGridView_QuanLyTour.Rows[row].Cells[0].Value.ToString();
            if (busTours.deleteTour(data)) MessageBox.Show("Xóa thành công tour: " + data);
            else MessageBox.Show("Xóa không thành công tour: " + data);
            LoadData();
        }

        private void btn_LuuTour_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                MemoryStream stream = new MemoryStream();
                pictureBox_Tour.Image.Save(stream, ImageFormat.Jpeg);
                DTO_Tours add = new DTO_Tours(txt_MaTour.Text.Trim(), cbo_MaLoai.SelectedValue.ToString(), txt_TenTour.Text, int.Parse(txt_SoNgay.Text), int.Parse(txt_SoCho.Text), stream.ToArray());
                if (busTours.addTours(add))
                    MessageBox.Show("Thêm tour thành công");
                else
                    MessageBox.Show("Thêm tour không thành công");
            }
            else
            {
                MemoryStream stream = new MemoryStream();
                pictureBox_Tour.Image.Save(stream, ImageFormat.Jpeg);
                DTO_Tours add = new DTO_Tours(txt_MaTour.Text.Trim(), cbo_MaLoai.SelectedValue.ToString(), txt_TenTour.Text, int.Parse(txt_SoNgay.Text), int.Parse(txt_SoCho.Text), stream.ToArray());
                if (busTours.updateTours(add))
                    MessageBox.Show("Cập nhật tour thành công");
                else
                    MessageBox.Show("Cập nhật tour không thành công");
            }
            btn_ChonAnh.Visible = false;
            LoadData();
        }

        private void btn_HuyTour_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imglocation = open.FileName.ToString();
                pictureBox_Tour.ImageLocation = imglocation;
            }
        }

        private void cbo_MaLoai_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaLoai,"SELECT * FROM LOAITOUR","TENLOAI","MALOAI");
        }

        private void cbo_MaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_QuanLyTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_QuanLyTour.CurrentRow.Index; //lấy ra chỉ số của row đang đc chọn
            string data = dataGridView_QuanLyTour.Rows[row].Cells[0].Value.ToString();
            //MessageBox.Show(data);
            MemoryStream memo = new MemoryStream(busTours.getImageTour(data));
            Image img = Image.FromStream(memo);
            if (img == null)
            {
                return;
            }
            pictureBox_Tour.Image = img;
        }

        private void btn_ChuongTrinhTour_Click(object sender, EventArgs e)
        {
            int row = dataGridView_QuanLyTour.CurrentRow.Index; //lấy ra chỉ số của row đang đc chọn
            string data = dataGridView_QuanLyTour.Rows[row].Cells[0].Value.ToString();
            MH_ChuongTrinhTour frm = new MH_ChuongTrinhTour(data);
            frm.Show();
        }
    }
}