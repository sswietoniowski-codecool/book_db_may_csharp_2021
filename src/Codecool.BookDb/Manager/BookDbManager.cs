using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Codecool.BookDb.Manager
{
    public class BookDbManager
    {
        public string ConnectionString => ConfigurationManager.AppSettings["connectionString"];

        public string Connect()
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            Console.WriteLine("Connected...");
            return ConnectionString;
        }
    }
}
