using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace PhanQuyen
{
    public class XuLi
    {
        public List<string> mamh = new List<string>();
        public int Check_Config(){
            if (Properties.Settings.Default.TravelConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            try{
                SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.TravelConnectionString);
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch{
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }

        public int Check_User(string pUser, string pPass){
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'", Properties.Settings.Default.TravelConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;// User không tồn tại
            else
                if (dt.Rows[0][2] == null || int.Parse(dt.Rows[0][2].ToString()) == 2)
                {
                    return 2;// Không hoạt động
                }
            return 1;// Đăng nhập thành công
        }
        public DataTable GetServerName(){
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass){
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try{
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";UserID=" + pUser + ";pwd = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows){
                    foreach (System.Data.DataColumn col in dt.Columns){
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch{
                return null;
            }
            return _list;
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            Properties.Settings.Default["TravelConnectionString"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }
        public List<string> getDatatable(string username)
        {
            DataTable dt = new DataTable();
            List<string> _list = new List<string>();
            try{
                SqlDataAdapter da = new SqlDataAdapter("select MaManHinh from QL_PhanQuyen, QL_NhomNguoiDung where QL_PhanQuyen.MaNhomNguoiDung = (select MaNhomNguoiDung from QL_NguoiDung, QL_NguoiDungNhomNguoiDung where QL_NguoiDung.TenDangNhap = 'admin' and QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap) and QL_PhanQuyen.MaNhomNguoiDung = QL_NhomNguoiDung.MaNhom", Properties.Settings.Default.TravelConnectionString);
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows){
                    foreach (System.Data.DataColumn col in dt.Columns){
                        //MessageBox.Show(row[col].ToString());
                        _list.Add(row[col].ToString());
                    }
                }
                mamh = _list;
            }
            catch{
                return null;
            }
            return _list;
        }
        public List<string> getoutMaManHinh(){
            return mamh;
        }
    }
}
