using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
using DAL_QuanLiTour;
using System.Data;
namespace BUS_QuanLiTour
{
    
    public class BUS_ChuongTrinhTour
    {
        DAL_ChuongTrinhTour dalCTTour = new DAL_ChuongTrinhTour();

        public DataTable getListChuongTrinhTour(string ma)
        {
            return dalCTTour.getListChuongTrinhTour(ma);
        }
        public bool addCTTour(DTO_ChuongTrinhTour a, string matour)
        {
            return dalCTTour.addCTTour(a, matour);
        }
    }
}
