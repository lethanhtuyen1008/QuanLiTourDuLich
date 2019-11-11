using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLiTour;

namespace DAL_QuanLiTour
{
    public class DAL_Tours
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public DataTable  getListTour()
        {
            var a = from u in db.TOURs select u;
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
        public Byte[] getImageTour(string matour)
        {
            TOUR a = db.TOURs.Where(t=>t.MATOUR.Equals(matour)).SingleOrDefault();
            if (a.HINH.ToArray().Length == 0)
            {
                return null;
            }
            else
            {
                byte[] x = a.HINH.ToArray();
                return x;
            }
        }
        public bool addTours( DTO_Tours a)
        {
            try
            {
                TOUR add = new TOUR();
                add.MATOUR = a.Matour;
                add.MALOAI = a.MaLoai;
                add.TENTOUR = a.TenTour;
                add.SONGAY = a.SoNgay;
                add.SOCHO = a.SoCho;
                add.HINH = a.Hinh;
                db.TOURs.InsertOnSubmit(add);
                db.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        public bool updateTours(DTO_Tours a)
        {
            try
            {
                TOUR add = db.TOURs.Where(t => t.MATOUR.Equals(a.Matour)).SingleOrDefault();
                add.MALOAI = a.MaLoai;
                add.TENTOUR = a.TenTour;
                add.SONGAY = a.SoNgay;
                add.SOCHO = a.SoCho;
                add.HINH = a.Hinh;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteTour(string matour)
        {
            try { 
                TOUR  a = db.TOURs.Where(t=>t.MATOUR.Equals(matour)).SingleOrDefault();
                db.TOURs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
