using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
using DTO_QuanLiTour;
using System.Data;
namespace BUS_QuanLiTour
{
    public class BUS_KhachHang
    {
        DAL_KhachHang kh = new DAL_KhachHang();
        public DataTable getKhachHang() {
            return kh.getKhachHang();
        }
        public bool deleteKhachHang(string MaKhachHang)
        {
            return kh.DeleteKhachHang(MaKhachHang);
        }
        public bool updateKhachHang(DTO_KhachHang a) {
            return kh.UpdateKhachHang(a);
        }
        public bool addKhachHang(DTO_KhachHang a)
        {
            return kh.AddKhachHang(a);
        }
    }
}
