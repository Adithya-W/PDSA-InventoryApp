using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Connect
    {
        string connectionString = @"Data Source = ASUS\SQLEXPRESS; Initial Catalog = InventorySystem; Integrated Security = True; TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                throw new Exception("Error connecting to database: " + ex.Message);
            }
        }
    }
}
