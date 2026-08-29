using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace MagazaOtomasyonu.DataAccess
{
    internal class DatabaseConnection
    {
        public static string connectionString = @"Server=localhost;Database=MagazaOptimizasyonu;Trusted_Connection=True;TrustServerCertificate=True;";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
