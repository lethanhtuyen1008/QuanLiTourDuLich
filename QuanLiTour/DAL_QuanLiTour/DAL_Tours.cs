﻿using System;
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
            var a = db.TOURs.Select(t=>t);
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

    }
}
