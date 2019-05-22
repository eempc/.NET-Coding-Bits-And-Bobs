using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace SQL_LINQ {
    class Program {
        static void Main(string[] args) {
            string personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string databasePath = Path.Combine(personalFolder, "myTestDatabaseFileName.mdf");
            string logFilePath = Path.Combine(personalFolder, "myTestDatabaseLogFile.ldf");

            string createString = $"CREATE DATABASE MyTestDatabase " +
                $"(NAME = MyDatabase_Data, FILENAME = '{databasePath}', SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                $"LOG ON (NAME = MyTestDatabase_Log, FILENAME = '{logFilePath}', SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)" 
                ;
            Console.WriteLine(createString);
            Console.ReadKey();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\SQL-LINQ\SQL-LINQ\TestDatabase77777.mdf;Integrated Security=True";

            //SqlConnection connection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            //SqlCommand command = new SqlCommand(createString, connection);

            //try {
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    Console.WriteLine("Success");
            //} catch (System.Exception e) {
            //    Console.WriteLine(e.ToString());
            //} finally {
            //    if (connection.State == ConnectionState.Open) connection.Close();
            //}
            //Console.ReadKey();
        }
    }

    class DBContext {

    }
}
