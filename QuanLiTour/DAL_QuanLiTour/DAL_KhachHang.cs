using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
using System.Data;

namespace DAL_QuanLiTour
{
    public class DAL_KhachHang
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public DataTable getKhachHang()
        {
            var a = db.KHACHHANGs.Select(t => t);
            //var a = db.QL_NguoiDungs.Select(t => t);
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
        public bool UpdateKhachHang(DTO_KhachHang a)
        {
            try
            {
                KHACHHANG edit = db.KHACHHANGs.Where(p => p.MAKHACHHANG.Equals(a.MaKhachHang)).SingleOrDefault();
                edit.TENKHACHHANG = a.TenKhachHang;
                edit.EMAIL = a.Email;
                edit.DIENTHOAI = a.DienThoai;
                edit.NGAYSINH = a.NgaySinh;
                edit.DIACHI = a.DiaChi;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddKhachHang(DTO_KhachHang a)
        {
            try
            {
                KHACHHANG insert = new KHACHHANG();
                insert.MAKHACHHANG = a.MaKhachHang;
                insert .TENKHACHHANG = a.TenKhachHang;
                insert.EMAIL = a.Email;
                insert.DIENTHOAI = a.DienThoai;
                insert.NGAYSINH = a.NgaySinh;
                insert.DIACHI = a.DiaChi;

                db.KHACHHANGs.InsertOnSubmit(insert);
                db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteKhachHang(string MaKhachHang)
        {
            try
            {
                // một khacha hàng KHACHHANG NHIỀU KHÁCH HÀNG KHACHHANGs
                KHACHHANG a = db.KHACHHANGs.Where(t => t.MAKHACHHANG.Equals(MaKhachHang)).SingleOrDefault();
                db.KHACHHANGs.DeleteOnSubmit(a);
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
