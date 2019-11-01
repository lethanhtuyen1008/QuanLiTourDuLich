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

namespace QuanLiTour
{
    public partial class MH_QuanLyTour : Form
    {
        XuLiData xuli = new XuLiData();
        public MH_QuanLyTour()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
        }
        private void MH_QuanLyTour_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        private void btn_ThemTour_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaTour_Click(object sender, EventArgs e)
        {

        }

        private void btn_LuuTour_Click(object sender, EventArgs e)
        {

        }

        private void btn_HuyTour_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";

            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string imagelocation = open.FileName.ToString();
                image_tour.ImageLocation = imagelocation;
            }
        }
    }
}
