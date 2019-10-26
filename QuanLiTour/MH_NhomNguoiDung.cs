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
    public partial class MH_NhomNguoiDung : Form {
        XuLiData xuli = new XuLiData ();
        public MH_NhomNguoiDung () {
            InitializeComponent ();
        }

        private void LoadData () {
            DataTable x = xuli.getDatatable ("select * from QL_NhomNguoiDung"); //1 bang lay co so du lieu
            xuli.LoadDataToGirdView (dataGridView_NhomNguoiDung, x); //do data vao gridview
            loaddataToText ();
        }
        private void MH_NhomNguoiDung_Load (object sender, EventArgs e) {
            LoadData ();
        }
        private void loaddataToText () { //do data vao txt
            txt_MaNhom.DataBindings.Clear ();
            txt_MaNhom.DataBindings.Add ("Text", dataGridView_NhomNguoiDung.DataSource, "MaNhom");

            txt_TenNhom.DataBindings.Clear ();
            txt_TenNhom.DataBindings.Add ("Text", dataGridView_NhomNguoiDung.DataSource, "TenNhom");

            txt_GhiChu.DataBindings.Clear ();
            txt_GhiChu.DataBindings.Add ("Text", dataGridView_NhomNguoiDung.DataSource, "GhiChu");
        }

        private void btn_ThemNhomNguoiDung_Click (object sender, EventArgs e) {
            xuli.MoVaXoaTextBox (tableLayoutPanel_ThongTinNhom);
            dataGridView_NhomNguoiDung.Enabled = true;
            //giờ lấy số dòn của datagirdview trừ đi 1..
            int dongcuoicung = dataGridView_NhomNguoiDung.RowCount - 2;
            string manhomdongcuoi = dataGridView_NhomNguoiDung.Rows[dongcuoicung].Cells[0].Value.ToString().Trim(); //row là dong cell là cột
            //MessageBox.Show(manhomdongcuoi);
            String Str = dataGridView_NhomNguoiDung.Rows[dongcuoicung].Cells[0].Value.ToString().Trim(); //row là dong cell là cột;
            string Str3 = Str.Substring(Str.Length-1,1);//xuat ra so cuoi
            //MessageBox.Show(Str3);
            string a = xuli.GetCountRowData(dataGridView_NhomNguoiDung, 0);//sẽ là sô 6 vì co 1 dòng dư
            MessageBox.Show(a.ToString());
            String MaNh;
            if (Str3.Length < 10)
            {
                MaNh = "NH00" + Str3;
            }
            else//
            {
                MaNh = "NH0" + Str3;
            }
            txt_MaNhom.Text=MaNh;
        }

        private void btn_SuaNhomNguoiDung_Click (object sender, EventArgs e) {
            xuli.MoTextBox(tableLayoutPanel_ThongTinNhom);
            txt_MaNhom.Enabled = false;
        }

        private void btn_XoaNhomNguoiDung_Click (object sender, EventArgs e) {
            DialogResult dlr = MessageBox.Show ("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string sqldelete = "DELETE from QL_NhomNguoiDung where MaNhom='" + txt_MaNhom.Text.ToString() + "'";
                xuli.RunCommand(sqldelete);
                LoadData();
            }
        }

        private void btn_LuuNhomNguoiDung_Click (object sender, EventArgs e) {
            try {//them
                MessageBox.Show("them");
                string sqlinsert = "INSERT INTO QL_NhomNguoiDung(MaNhom, TenNhom, GhiChu) VALUES('" + txt_MaNhom.Text.ToString() + "', N'" + txt_TenNhom.Text.ToString() + "', N'" + txt_GhiChu.Text.ToString() + "')";
                xuli.RunCommand(sqlinsert);
            }
            catch { //sua
                MessageBox.Show("Sửa");
                string sqlupdate = "UPDATE QL_NhomNguoiDung SET MaNhom='" +txt_MaNhom.Text.ToString()+ "', TenNhom=N'" +txt_TenNhom.Text.ToString()+ "', GhiChu='" +txt_GhiChu.Text.ToString()+ "' WHERE MaNhom='" +txt_MaNhom.Text.ToString()+ "' ";
                xuli.RunCommand(sqlupdate);
            }
            xuli.DongTextBox(tableLayoutPanel_ThongTinNhom);
            LoadData();
        }

        private void btn_HuyTacVu_Click (object sender, EventArgs e) {
            LoadData ();
            dataGridView_NhomNguoiDung.Enabled = true  ;
        }
    }
}