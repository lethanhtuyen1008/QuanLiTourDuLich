using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_KhachHang
    {
        private string _MaKhachHang;
        private string _TenKhachHang;
        private string _Email;
        private int _DienThoai;
        private DateTime _NgaySinh;
        private string _DiaChi;
        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }
        public string TenKhachHang
        {
            get { return _TenKhachHang; }
            set { _TenKhachHang = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public int DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public DTO_KhachHang() { }
        public DTO_KhachHang( string MaKhachHang, string TenKhachHang, string Email, int DienThoai, DateTime NgaySinh,  string DiaChi)
        {
            this.MaKhachHang = MaKhachHang;
            this.TenKhachHang = TenKhachHang;
            this.Email = Email;
            this.DienThoai = DienThoai;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
        }

        
    }
}
