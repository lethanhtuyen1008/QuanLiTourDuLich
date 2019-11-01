using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLiTour
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(Properties.Settings.Default.TravelConnectionString);
    }
}
