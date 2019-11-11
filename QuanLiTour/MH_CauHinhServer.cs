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
    public partial class MH_CauHinhServer : Form
    {
        public MH_CauHinhServer()
        {
            InitializeComponent();
        }

        NguoiDung CauHinh = new NguoiDung();
        private void btn_DangNhapServer_Click(object sender, EventArgs e)
        {

        }

        private void cbo_TenServer_DropDown(object sender, EventArgs e)
        {
            cbo_TenServer.DataSource = CauHinh.GetServerName();
        }
    }
}
