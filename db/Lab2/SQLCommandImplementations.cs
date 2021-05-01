using db.DbModel;
using db.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Context
{
    public class SQLCommandImplementations : ContextBase
    {
        public static List<Cashier> GetCashiers()
        {
            var result = new List<Cashier>();
            string sqlExpression = "SELECT id, firstName, surname, middleName FROM Cashier";
            using SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var cashier = new Cashier();

                    cashier.Id = int.Parse(reader.GetValue(0).ToString());
                    cashier.FirstName = reader.GetValue(1).ToString();
                    cashier.Surname = reader.GetValue(2).ToString();
                    cashier.MiddleName = reader.GetValue(3).ToString();
                    result.Add(cashier);
                }
            }
            reader.Close();
            return result; 
        }


        public static int GetRecordsCount()
        {
            using var con = new SqlConnection(ConnectionString);

            var command = new SqlCommand($"SELECT COUNT (*) FROM {Constants.Cashier}", con);
            int count = 0;
            con.Open();
            count = (int)command.ExecuteScalar();



            return count; 
        }



        public static int AddNewCashier(Cashier cashier)
        {

            using var con = new SqlConnection(ConnectionString);

            var cmd = new SqlCommand("AddNewCashier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar, 20));
            cmd.Parameters["@surname"].Value = cashier.Surname;     
            cmd.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar, 10));
            cmd.Parameters["@firstName"].Value = cashier.FirstName;
            cmd.Parameters.Add(new SqlParameter("@middleName", SqlDbType.NVarChar, 10));
            cmd.Parameters["@middleName"].Value = cashier.MiddleName;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4));
            cmd.Parameters["@Id"].Direction = ParameterDirection.Output;
            con.Open();
            int id = 0;
            try
            {
                int numAff = cmd.ExecuteNonQuery();
                // Получить вновь сгенерированный идентификатор
                id = int.Parse(cmd.Parameters["@id"].Value.ToString());
 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return id;
        }
    }
}
