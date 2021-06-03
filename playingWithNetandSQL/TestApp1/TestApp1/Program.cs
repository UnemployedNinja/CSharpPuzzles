using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SqlConnection connection = new SqlConnection();                 // Connecting to SQL Server
            SqlCommand command = new SqlCommand();                          // Running a command against the SQL Server instance
            SqlDataReader dataReader = new SqlDataReader();                 // Retrieving your query's results

            string connString = @"Server=INSTANCE_NAME;Database=DATABASE_NAME;Trusted_Connection = True;";         // Trusted Connection
            //string connString = @"Server=INSTANCE_NAME;Database=DATABASE_NAME;User ID=USERNAME;Password=PASSWORD"; // SQL Authentication-based connection



        }
    }
}
