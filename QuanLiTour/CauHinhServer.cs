using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTour
{
    public partial class CauHinhServer : UserControl
    {
        NguoiDung CauHinh = new NguoiDung();
        public CauHinhServer()
        {
            InitializeComponent();
        }

        private void btn_DangNhapServer_Click(object sender, EventArgs e)
        {
            CauHinh.ChangeConnectionString(cbo_TenServer.Text, txt_TenDangNhap.Text, txt_Password.Text, cbo_TenData.Text);
            this.Hide();
        }
    }
}
