using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLiTour;
namespace BUS_QuanLiTour
{
    public class BUS_Tours
    {
        DAL_Tours dalTour = new DAL_Tours();
        public DataTable getListTour()
        {
            return dalTour.getListTour();
        }
    }
}
