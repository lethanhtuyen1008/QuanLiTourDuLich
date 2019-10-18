using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiTour
{
    public class XuLiData
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
        public DataTable getDatatable(string sql){
            DataTable a = new DataTable();
            MoConnect();
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DongConnect();
            da.Fill(a);
            return a;
        }
        public void LoadDataToGirdView(DataGridView data, DataTable a)
        {
            data.DataSource = a;
        }
        // Load data vào combobox
        private void loadComboBox(ComboBox tencbo, string sql, string dislaymember, string valuemember)
        {
            MoConnect();
            tencbo.DataSource = getDatatable(sql);
            tencbo.DisplayMember = dislaymember;
            tencbo.ValueMember = valuemember;
            DongConnect();
        }
    }
}
