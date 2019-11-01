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
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-BGAMJEE;Initial Catalog=Travel;User ID=sa;Password=sa2012");
    }
}
