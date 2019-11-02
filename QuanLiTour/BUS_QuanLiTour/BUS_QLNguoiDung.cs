using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLiTour;
using DTO_QuanLiTour;


namespace BUS_QuanLiTour
{
    public class BUS_QLNguoiDung
    {
        DAL_QLNguoiDung dalNguoiDung = new DAL_QLNguoiDung();

        public DataTable getListNguoiDung()
        {
            return dalNguoiDung.getNguoiDung();
        }
        public bool deleteNguoiDung(string id)
        {
            return dalNguoiDung.DeleteNguoiDung(id);
        }
        public bool UpdateNguoiDung(DTO_QLNguoiDung a)
        {
            return dalNguoiDung.UpdateNguoiDung(a);
        }
        public bool AddNguoiDung(DTO_QLNguoiDung a)
        {
            return dalNguoiDung.AddNguoiDung(a);
        }
    }
}
