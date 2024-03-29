﻿using System;
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
            da.Fill(a);
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
                if (item.GetType() == typeof(TextBox))
                    item.Enabled = true;
        }
        public void MoVaXoaTextBox (Panel a) {
            foreach (Control item in a.Controls) { 
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
        public int GetCountRowData(DataGridView a, int cotlay){
            int count = 0;
            count = a.Rows.Count;//dem all cac dong datagrid roi dem gan cho count
            int dongcuoi = count - 2;
            string iddongcuoi = a.Rows[dongcuoi].Cells[cotlay].Value.ToString().Trim(); //row là dong cell là cột
            String Str = a.Rows[dongcuoi].Cells[0].Value.ToString().Trim(); //row là dong cell là cột;
            string Str3 = (int.Parse(Str.Substring(Str.Length - 1, 1)) + 1).ToString();
            return int.Parse(Str3);
        }
    }
}