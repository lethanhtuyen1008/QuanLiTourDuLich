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
    public partial class DanhSachTourMo : Form
    {
        public DanhSachTourMo()
        {
            InitializeComponent();
        }

        private void qL_ManHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void MH_DanhSachTourMo_Load(object sender, EventArgs e)
        {

        }
    }
}
