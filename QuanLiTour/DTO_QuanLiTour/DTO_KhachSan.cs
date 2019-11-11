using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_KhachSan
    {
        private string _MaKhachSan;
        private string _MaTinh;
        private string _TenKhachSan;
        public string MaKhachSan
        {
            get { return _MaKhachSan; }
            set { _MaKhachSan = value; }
        }
        public string MaTinh
        {
            get { return _MaTinh; }
            set { _MaTinh = value; }
        }
        public string TenKhachSan
        {
            get { return _TenKhachSan; }
            set { _TenKhachSan = value; }
        }
        public DTO_KhachSan() { }
        public DTO_KhachSan(string MaKhachSan, string MaTinh, string TenKhachSan) {
            this.MaKhachSan = MaKhachSan;
            this.MaTinh = MaTinh;
            this.TenKhachSan = TenKhachSan;
        }
        }
    }

