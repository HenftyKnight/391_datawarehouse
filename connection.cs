using System.Data.SqlClient;


namespace dbConnection {
    public static class DatabaseConnection { 
        private static SqlConnection connection;
        private static string connectionString = "Server=ANDROMEDA;Database=DATAWAREHOUSE;Trusted_Connection = yes;";

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }
    }
}