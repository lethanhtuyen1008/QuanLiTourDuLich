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
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
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
        public bool UpdateNguoiDung(DTO_QLNguoiDung a)
        {
            try
            {
                QL_NguoiDung edit = db.QL_NguoiDungs.Where(p => p.TenDangNhap.Equals(a.TenDangNhap)).SingleOrDefault();
                edit.TinhTrang = a.TinhTrang;
                edit.Ho = a.Ho;
                edit.Ten = a.Ten;
                edit.NamSinh = a.NamSinh;
                edit.GioiTinh = a.GioiTinh;
                edit.Luong = a.Luong;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddNguoiDung(DTO_QLNguoiDung a)
        {
            try
            {
                QL_NguoiDung insert = new QL_NguoiDung();

                insert.TenDangNhap = a.TenDangNhap;
                insert.MatKhau = "123";
                insert.TinhTrang = a.TinhTrang;
                insert.Ho = a.Ho;
                insert.Ten = a.Ten;
                insert.NamSinh = a.NamSinh;
                insert.GioiTinh = a.GioiTinh;
                insert.Luong = a.Luong;

                db.QL_NguoiDungs.InsertOnSubmit(insert);
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
