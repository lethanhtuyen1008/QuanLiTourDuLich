using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
using System.Data;

namespace DAL_QuanLiTour
{
    public class DAL_ChuongTrinhTour
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public DataTable getListChuongTrinhTour(string maTour)
        {
            var a = db.CHUONGTRINHTOURs.Where(t=>t.MATOUR == maTour);
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
        public bool addCTTour(DTO_ChuongTrinhTour a, string matour)
        {
            try
            {
                CHUONGTRINHTOUR add = new CHUONGTRINHTOUR();
                add.MACHUONGTRINH = a.MaChuongTrinh;
                add.MATOUR = a.MaTour;
                add.MAKHACHSAN = a.MaKhachSan;
                add.TENCHUONGTRINH = a.TenChuongTrinh;
                add.NGAY = a.Ngay;
                a.ChiTiet = a.ChiTiet;
                db.CHUONGTRINHTOURs.InsertOnSubmit(add);
                db.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
