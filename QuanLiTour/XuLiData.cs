using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents;

namespace QuanLiTour {
    public class XuLiData {
        SqlConnection conn = new SqlConnection (Properties.Settings.Default.TravelConnectionString);
        SqlCommand cmd;
        private void DongConnect () {
            if (conn.State == ConnectionState.Open)
                conn.Close ();
        }
        private void MoConnect () {
            if (conn.State == ConnectionState.Closed)
                conn.Open ();
        }
        //get data table
        public DataTable getDatatable (string sql) {
            DataTable a = new DataTable ();
            MoConnect ();
            SqlCommand com = new SqlCommand (sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter (com);
            DongConnect ();
            da.Fill (a);
            return a;
        }
        public void LoadDataToGirdView (DataGridView data, DataTable a) {
            data.DataSource = a;
        }
        // Load data vào combobox
        public void loadComboBox (ComboBox tencbo, string sql, string dislaymember, string valuemember) {
            MoConnect ();
            tencbo.DataSource = getDatatable (sql);
            tencbo.DisplayMember = dislaymember;
            tencbo.ValueMember = valuemember;
            DongConnect ();
        }
        public void RunCommand (string sql) {
            MoConnect ();
            cmd = new SqlCommand (sql, conn);
            cmd.ExecuteNonQuery ();
            DongConnect ();
        }
        public void MoTextBox (Panel a) {
            foreach (Control item in a.Controls)
                if (item.Tag != null)
                    item.Enabled = true;
        }
        public void MoVaXoaTextBox (Panel a) { // đối tượng truyền vào ở đây là panel.. nên mình bỏ hết mấy cái txt vào 1 cái panel
            foreach (Control item in a.Controls) { // anh xet tag cái nào != null.. nghĩ là no là txt
                //MessageBox.Show(item.Name.ToString());
                if (item.Tag != null) {
                    item.Text = null;
                    item.Enabled = true;
                }
            }
        }
        public void DongTextBox (Panel a) {
            foreach (Control item in a.Controls)
                if (item.Tag != null)
                    item.Enabled = false;
        }
        public string GetCountRowData(DataGridView a, int cotlay)
        {
            int count = 0;
            //vd truyền vào cai dât này sẽ ra số 5....
            count = a.Rows.Count;//dem all cac dong datagrid roi dem gan cho count
            // dòng này trả ra số bn số 0 à
             // 6 - 2
            int dongcuoi = count - 2;
            string iddongcuoi = a.Rows[dongcuoi].Cells[cotlay].Value.ToString().Trim(); //row là dong cell là cột
            MessageBox.Show(iddongcuoi);
            String Str = a.Rows[dongcuoi].Cells[0].Value.ToString().Trim();
            string Str3 = Str.Substring(Str.Length - 1, 1);
            String id;
            if (Str3.Length < 10)
            {
                id = "NH00" + Str3;
            }
            else
            {
                id = "NH0" + Str3;
            }
            return id;
            
        }
    }
}