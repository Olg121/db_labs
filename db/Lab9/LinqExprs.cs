using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using db.DbModel;
using System.Data.Linq.SqlClient;

namespace db.Lab9
{
    public class LinqExprs
    {
        private static string connectionString = @"Data Source=KOPUHTER\swpdm;Initial Catalog=InternetShop;Integrated Security=True";

        public static DataContext db = new DataContext(connectionString);
        public static List<Cashier> GetCashiers (string filter = null)
        {
            var q = db.GetTable<Cashier>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                filter = $"%{filter}%";
                q = q.Where(x => SqlMethods.Like( x.FirstName, filter)|| SqlMethods.Like(x.Surname, filter) || SqlMethods.Like(x.MiddleName, filter));

            }
            return q.ToList(); 
        }

        public static void UpdateCashier(Cashier cashier)
        {
            if (cashier is not null)
            {
                var dbCashier = db.GetTable<Cashier>().FirstOrDefault(x => x.Id == cashier.Id);
                dbCashier.FirstName = cashier.FirstName;
                dbCashier.Surname = cashier.Surname;
                dbCashier.MiddleName = cashier.MiddleName;
                db.SubmitChanges();
            }
        }

        public static void InsertCashier(Cashier cashier)
        {
            if (cashier is not null)
            {
                 db.GetTable<Cashier>().InsertOnSubmit(cashier);
                 db.SubmitChanges();
            }
               
        }

        public static void DeleteCashier(Cashier cashier)
        {
            if (cashier is not null)
            {
                db.GetTable<Cashier>().DeleteOnSubmit(cashier);
                db.SubmitChanges();
            }
        }


    }
}
