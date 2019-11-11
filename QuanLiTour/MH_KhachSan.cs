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

namespace QuanLiTour
{
    public partial class MH_KhachSan : Form
    {
        BUS_KhachSan busks = new BUS_KhachSan();
        public MH_KhachSan()
        {
            InitializeComponent();
        }

        private void MH_KhachSan_Load(object sender, EventArgs e)
        {
            dataGridView_KhachSan.DataSource = busks.getKhachSan();
        }  
    }
}
