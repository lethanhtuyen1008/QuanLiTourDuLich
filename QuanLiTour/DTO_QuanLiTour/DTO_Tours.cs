using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_Tours
    {
        private string _MaTour;
        private string _MaLoai;
        private string _TenTour;
        private int _SoNgay;
        private int _SoCho;
        private byte[] _Hinh;

        public string Matour
        {
            get { return _MaTour; }
            set { _MaTour = value; }
        }
        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }
        public string TenTour
        {
            get { return _TenTour; }
            set { _TenTour = value; }
        }
        public int SoNgay
        {
            get { return _SoNgay; }
            set { _SoNgay = value; }
        }
        public int SoCho
        {
            get { return _SoCho; }
            set { _SoCho = value; }
        }
        public byte[] Hinh
        {
            get { return _Hinh; }
            set { _Hinh = value; }
        }
        public DTO_Tours() { }
        public DTO_Tours(string matour, string maloai, string tentour, int songay, int socho, byte[] hinh)
        {
            this.Matour = matour;
            this.MaLoai = maloai;
            this.TenTour = tentour;
            this.SoNgay = songay;
            this.SoCho = socho;
            this.Hinh = hinh;
        }
    }
}
