using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_QLNguoiDung
    {
        private string _TenDangNhap;
        private string _MatKhau;
        private int _TinhTrang;
        private string _Ho;
        private string _Ten;
        private int _NamSinh;
        private string _GioiTinh;
        private decimal _Luong;

        public string TenDangNhap {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        public int NamSinh
        {
            get { return _NamSinh; }
            set { _NamSinh = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public decimal Luong
        {
            get { return _Luong; }
            set { _Luong = value; }
        }
        public DTO_QLNguoiDung()
        {
        }
        public DTO_QLNguoiDung(string tendangnhap, string matkhau, int tinhtrang, string ho, string ten, int namsinh, string gioitinh, decimal luong)
        {
            this.TenDangNhap = tendangnhap;
            this.MatKhau = matkhau;
            this.TinhTrang = tinhtrang;
            this.Ho = ho;
            this.Ten = ten;
            this.NamSinh = namsinh;
            this.GioiTinh = gioitinh;
            this.Luong = luong;
        }
        public DTO_QLNguoiDung(string tendangnhap,int tinhtrang, string ho, string ten, int namsinh, string gioitinh, decimal luong)
        {
            this.TenDangNhap = tendangnhap;
            this.TinhTrang = tinhtrang;
            this.Ho = ho;
            this.Ten = ten;
            this.NamSinh = namsinh;
            this.GioiTinh = gioitinh;
            this.Luong = luong;
        }

    }
}
