using feedbackapi.BLL.Repository;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace feedbackapi.BLL.Service
{
    public class MySqlTransactionService : IMySqlTransactionRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public MySqlTransactionService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration["ConnectionStrings:DefaultConnection"];
        }

        public int ExecuteSqlQuery(string rawTSql)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            int result = 0;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(rawTSql, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = 0;
            }

            conn.Close();
            return result;
        }
    }
}
