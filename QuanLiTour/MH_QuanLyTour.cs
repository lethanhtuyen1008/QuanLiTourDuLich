﻿using System;
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

namespace QuanLiTour
{
    public partial class MH_QuanLyTour : Form
    {
        XuLiData xuli = new XuLiData();
        BUS_Tours busTours = new BUS_Tours();
        string imglocation = "";//string filename
        int set = 0;
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
            byte data = byte.Parse(dataGridView_QuanLyTour.Rows[0].Cells[6].Value.ToString());

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

        }
        private void MH_QuanLyTour_Load(object sender, EventArgs e)
        {

            LoadData();
            //loaddatatoText();
        }
        private void btn_ThemTour_Click(object sender, EventArgs e)
        {
            btn_ChonAnh.Visible = true;
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            btn_ChonAnh.Visible = true;
        }

        private void btn_XoaTour_Click(object sender, EventArgs e)
        {

        }

        private void btn_LuuTour_Click(object sender, EventArgs e)
        {
            if (imglocation == "" && set ==0)
            {
                string sqlstring = "UPDATE TOUR SET MALOAI=N'" + cbo_MaLoai.Text.Trim() + "', TENTOUR=N'" + txt_TenTour.Text.Trim() + "', SONGAY='" + txt_SoNgay.Text.Trim() + "', SOCHO='" + txt_SoCho.Text.Trim() + "' WHERE MATOUR='" + txt_MaTour.Text.Trim() + "' ";
                MessageBox.Show(sqlstring);
                xuli.RunCommand(sqlstring); 
            }
            else
                if (imglocation != "" && set == 1)
                {
                    byte[] images = null;
                    FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);
                    string sqlstring = "UPDATE TOUR SET MALOAI=N'" + cbo_MaLoai.Text.Trim() + "', TENTOUR=N'" + txt_TenTour.Text.Trim() + "', SONGAY='" + txt_SoNgay.Text.Trim() + "', SOCHO='" + txt_SoCho.Text.Trim() + "', HINH = '" + images.ToString() + "' WHERE MATOUR='" + txt_MaTour.Text.Trim() + "' ";
                    MessageBox.Show(sqlstring);
                    xuli.RunCommand(sqlstring);
                }
                else
                    {
                        byte[] images = null;
                        FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        images = brs.ReadBytes((int)Stream.Length);
                        string sqlstring = "INSERT INTO TOUR(MATOUR, MALOAI,TENTOUR, SONGAY, SOCHO, HINH) VALUES('" + txt_MaTour.Text.Trim() + "', '" + cbo_MaLoai.Text.Trim() + "', '" + txt_TenTour.Text.Trim() + "', '" + txt_SoNgay.Text.Trim() + "', '" + txt_SoCho.Text.Trim() + "', '" + images.ToString() + "')";
                        MessageBox.Show(sqlstring);
                        xuli.RunCommand(sqlstring);
                    }
            btn_ChonAnh.Visible = false;
            set = 0;
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
                set = 1;
            }
        }

        private void cbo_MaLoai_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaLoai,"SELECT * FROM LOAITOUR","TENLOAI","MALOAI");
        }

        private void cbo_MaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}