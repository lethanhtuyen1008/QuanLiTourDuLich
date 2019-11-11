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
    public class BUS_KhachSan
    {
        DAL_KhachSan ks = new DAL_KhachSan();
        public DataTable getKhachSan()
        {
            return ks.getKhachSan();
        }
    }
}
