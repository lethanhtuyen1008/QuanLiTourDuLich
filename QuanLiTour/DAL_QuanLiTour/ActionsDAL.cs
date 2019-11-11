using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL_QuanLiTour
{
    public class ActionsDAL
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.TravelConnectionString);
        SqlCommand cmd;
        private void DongConnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void MoConnect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        //get data table
        public DataTable getDatatable(string sql)
        {
            DataTable a = new DataTable();
            MoConnect();
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DongConnect();
            da.Fill(a);
            return a;
        }
        public void RunCommand(string sql)
        {
            MoConnect();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            DongConnect();
        }
    }
}
