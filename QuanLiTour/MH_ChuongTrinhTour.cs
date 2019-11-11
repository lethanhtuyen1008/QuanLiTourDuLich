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
namespace QuanLiTour
{
    public partial class MH_ChuongTrinhTour : Form
    {
        BUS_ChuongTrinhTour busCTTour = new BUS_ChuongTrinhTour();
        XuLiData xuli = new XuLiData();
        private string matour;
        public MH_ChuongTrinhTour(string x)
        {
            InitializeComponent();
            this.matour = x;
        }
        public void LoadData()
        {
            xuli.LoadDataToGirdView(dataGridView_ChuongTrinhTour, busCTTour.getListChuongTrinhTour(this.matour));
        }
        private void MH_ChuongTrinhTour_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView_ChuongTrinhTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
