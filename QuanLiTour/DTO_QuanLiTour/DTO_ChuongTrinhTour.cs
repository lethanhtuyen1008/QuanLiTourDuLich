using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_ChuongTrinhTour
    {
        private string _MaChuongTrinh;
        private string _MaTour;
        private string _MaKhachSan;
        private string _TenChuongTrinh;
        private DateTime _Ngay;
        private string _ChiTiet;

        public string MaChuongTrinh
        {
            get { return _MaChuongTrinh; }
            set { _MaChuongTrinh = value; }
        }

        public string MaTour
        {
            get { return _MaTour; }
            set { _MaTour = value; }
        }
       

        public string MaKhachSan
        {
            get { return _MaKhachSan; }
            set { _MaKhachSan = value; }
        }
        

        public string TenChuongTrinh
        {
            get { return _TenChuongTrinh; }
            set { _TenChuongTrinh = value; }
        }

        public DateTime Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
        }
        public string ChiTiet
        {
            get { return _ChiTiet; }
            set { _ChiTiet = value; }
        }
        public DTO_ChuongTrinhTour(string machuongtrinh, string matour, string makhachsan, string tenchuongtrinh, DateTime ngay , string chitiet)
        {
            this.MaChuongTrinh = machuongtrinh;
            this.MaTour = matour;
            this.MaKhachSan = makhachsan;
            this.TenChuongTrinh  = tenchuongtrinh;
            this.Ngay = ngay;
            this.ChiTiet = chitiet;
        }
    }
}
