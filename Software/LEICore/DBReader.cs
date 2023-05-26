using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore
{
    internal class DBReader
    {
        private static string _connectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=IPS23_jferko21; User=jferko21; Password=m3pS-ypa";
        private static SqlConnection _connection;
        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }
        public static void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close();
                }
        }
        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }
        public static int ExecuteCommand(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);

            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }
    }
}
