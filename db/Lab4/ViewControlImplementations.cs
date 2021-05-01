using db.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Lab4
{
    class ViewControlImplementations
    {
        public static void AddCalculatingColumnToDataSet(DataSet dataSet)
        {
            var column = new DataColumn("DisplayInfo", typeof(string), "FirstName + ' ' + Surname");
            dataSet.Tables[Constants.Cashier].Columns.Add(column);
        }
        public static DataView GetDataOrderedByFirstName(DataSet dataSet)
        {
            var dataView = new DataView(dataSet.Tables[Constants.Cashier]);
            dataView.Sort = "FirstName";
            return dataView; 
        }                
        public static DataView GetDataOrderedBySName(DataSet dataSet)
        {
            var dataView = new DataView(dataSet.Tables[Constants.Cashier]);
            dataView.Sort = "Surname";
            return dataView; 
        }

        public static void FilterRows(DataView dataView, string sName, string name)
        {
            var filter = string.Empty;
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(sName))
            {
                filter = $"FirstName like '%{name}%' and Surname like '%{sName}%'";
            }
            else
                filter = !String.IsNullOrWhiteSpace(name) ? $"FirstName like '%{name}%'"
                    : (!string.IsNullOrWhiteSpace(sName) ? $"Surname like '%{sName}%'" : string.Empty);

            dataView.RowFilter = filter; 
            
        }
    }
}
