using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class SQL<T> where T: class
    {
        string connectionString =@"Data Source=MDDSK40034-2\PVV;Initial Catalog = mydb; User ID = sa; Password=5p93Yan2";
        public void Add(T entity)
        {
            string queryText = (" ");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    command.CommandText = queryText;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    Console.WriteLine("Record Is Writen");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    Console.ReadLine();
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
