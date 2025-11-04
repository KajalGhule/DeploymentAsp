using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;

namespace PayrollWebApp.DataBaseConnection
{
    public class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            //Console.WriteLine("DB Connection String: " + _connectionString);
            //Console.WriteLine("DB Connection String: " + _connectionString ?? "NULL!!!");
        }

        public async Task<SqlConnection> GetConnection()
        {
            var conn = new SqlConnection(_connectionString);
            await conn.OpenAsync();
            return conn;
        }
    }
}
