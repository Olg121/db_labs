using db.Context;
using db.DbModel;
using db.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Lab3
{
    public class DataSetImplementations : ContextBase
    {
        private static SqlDataAdapter _adapter;
        static DataSetImplementations()
        {
            var con = new SqlConnection(ConnectionString);
            string command = "SELECT * FROM Cashier";
            _adapter = new SqlDataAdapter(command, con);
        }
        public static DataSet ReadCashiersFromDb()
        {
            var dataset = new DataSet();
            _adapter.Fill(dataset, Constants.Cashier);
            return dataset;
        }

        public static void AddCashierToDataSet(DataSet dataSet, Cashier cashier)
        {
            var builder = new SqlCommandBuilder(_adapter);
            var CashierTable = dataSet.Tables[Constants.Cashier];
            var row = CashierTable.NewRow();
            row["id"] = cashier.Id; ;
            row["Surname"] = cashier.FirstName;
            row["FirstName"] = cashier.Surname;
            row["MiddleName"] = cashier.MiddleName;
            CashierTable.Rows.Add(row);
            //  builder.GetInsertCommand();
            _adapter.Update(dataSet, Constants.Cashier);
        }

        public static IEnumerable<Cashier> GetCashiersFromDataSet(DataSet dataset)
        {
            var result = new List<Cashier>();

            // Вывод из DataSet строк таблицы Employees в элемент list1
            foreach (DataRow row in dataset.Tables[Constants.Cashier].Rows)
            {
                var cashier = new Cashier()
                {

                };
                cashier.Id = (int)row["id"];
                cashier.FirstName = row["Surname"].ToString();
                cashier.Surname = row["FirstName"].ToString();
                cashier.MiddleName = row["MiddleName"].ToString();
                result.Add(cashier);
            }

            return result;
        }

     


        public static List<dynamic> CreateTable()
        {
            using SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
     
            var bookStore = new DataSet();
            var booksTable = new DataTable("User");

            var columns = GetColumns();

            var result = new List<dynamic>(); 
            columns.ForEach(booksTable.Columns.Add);
            booksTable.PrimaryKey = new DataColumn[] { booksTable.Columns["Id"] };

            DataRow row = booksTable.NewRow();

            var rows = new List<string>() { "Id", "Name" , "Cash", "OwnDiscount"};
            booksTable.Rows.Add(new object[] { null, "Олег", 200, 0.04 }); // добавляем первую строку
            booksTable.Rows.Add(new object[] { null, "Рома", null, null }); // добавляем вторую строку


            Console.Write("\tИд \tНазвание \tЦена \tСкидка");
            Console.WriteLine();
            foreach (DataRow r in booksTable.Rows)
            {
                int i = 0; 
                var expando = new ExpandoObject(); 
                foreach (var cell in r.ItemArray)
                   (expando as IDictionary<string, object>)[rows[i++]] = cell;
                
                result.Add(expando);
            }

            return result;
        }

        private static List<DataColumn> GetColumns()
        {
           
            var idColumn = new DataColumn("Id", Type.GetType("System.Int32"))
            {
                Unique = true,
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            var nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            var cashColumn = new DataColumn("Cash", Type.GetType("System.Decimal"));
            var discountColumn = new DataColumn("OwnDiscount", Type.GetType("System.Decimal"));
            cashColumn.DefaultValue = 100; // значение по умолчанию
            discountColumn.DefaultValue = 0.03;
            var result = new List<DataColumn>()
            {
               idColumn,
               nameColumn,
               cashColumn,
               discountColumn,

            };
            return result; 
        }


    }
}
