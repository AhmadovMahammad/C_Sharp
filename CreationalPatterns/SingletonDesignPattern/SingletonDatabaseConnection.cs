using System.Data.SqlClient;

namespace SingletonDesignPattern
{
    public sealed class SingletonDatabaseConnection
    {
        private static SingletonDatabaseConnection? _instance;
        private static readonly object _lock = new();
        private readonly string _connectionString = string.Empty;
        private SingletonDatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        public static SingletonDatabaseConnection GetInstance(string connectionString)
        {
            //if you are creating an app with multithreading support, you should place a thread lock here
            lock (_lock)
            {
                _instance ??= new SingletonDatabaseConnection(connectionString);
            }
            return _instance;
        }
        public void RunQuery(string query)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                using var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("command has been executed successfully.");
            }
            catch (Exception)
            {
                Console.WriteLine("error occured;");
            }
        }
    }
}
