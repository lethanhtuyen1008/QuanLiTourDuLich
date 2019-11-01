using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLiTour;

namespace DAL_QuanLiTour
{
    public class DAL_QLNguoiDung
    {
        DataQLNguoiDungDataContext db = new DataQLNguoiDungDataContext();
        public DataTable getNguoiDung()
        {
            var a = db.QL_NguoiDungs.Select(t=>t);

            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in a)
            {
                if (firstPass)
                {
                    Array.ForEach(item.GetType().GetProperties(), p => resultTable.Columns.Add(new DataColumn(p.Name)));
                    firstPass = false;
                }
                var newRow = resultTable.NewRow();
                Array.ForEach(item.GetType().GetProperties(), p => newRow[p.Name] = p.GetValue(item, null));
                resultTable.Rows.Add(newRow);
            }
            return resultTable;
        }
        public bool UpdateNguoi1Dung(DTO_QLNguoiDung a)
        {
            try
            {
                QL_NguoiDung edit = db.QL_NguoiDungs.Where(p => p.TenDangNhap.Equals(a.TenDangNhap)).SingleOrDefault();
                edit.TinhTrang = a.TinhTrang;
                edit.GioiTinh = a.GioiTinh;
                edit.Ho = a.Ho;
                edit.Ten = a.Ten;
                edit.Luong = int.Parse(a.Luong);
                edit.NamSinh = a.NamSinh;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateNguoiDung(string []a)
        {
            try
            {
                QL_NguoiDung edit = db.QL_NguoiDungs.Where(p => p.TenDangNhap.Equals(a[0])).SingleOrDefault();
                edit.TinhTrang = int.Parse(a[2]);
                edit.Ho = a[3];
                edit.Ten = a[4];
                edit.NamSinh = int.Parse(a[5]);
                edit.GioiTinh = a[6];
                edit.Luong = int.Parse(a[7]);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteNguoiDung(string username)
        {
            try
            {
                QL_NguoiDung a = db.QL_NguoiDungs.Where(t => t.TenDangNhap.Equals(username)).SingleOrDefault();
                db.QL_NguoiDungs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
