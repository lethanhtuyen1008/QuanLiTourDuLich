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
    public class BUS_Tours
    {
        DAL_Tours dalTour = new DAL_Tours();
        public DataTable getListTour()
        {
            return dalTour.getListTour();
        }
        public bool addTours(DTO_Tours  a)
        {
            return dalTour.addTours(a);
        }
        public Byte[] getImageTour(string matour)
        {
            return dalTour.getImageTour(matour);
        }
        public bool updateTours(DTO_Tours a)
        {
            return dalTour.updateTours(a);
        }
        public bool deleteTour(string a)
        {
            return dalTour.deleteTour(a);
        }
    }
}
