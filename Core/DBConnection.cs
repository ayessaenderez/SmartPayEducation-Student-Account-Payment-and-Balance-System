using MySql.Data.MySqlClient;

namespace StudentInfoSys.Core
{
    internal class DBConnection
    {
        private const string _Server = "localhost";
        private const string _UserID = "root";
        private const string _Password = "";
        private const string _Database = "studentinfosys";

        protected static MySqlConnection Connect()
        {
            MySqlConnection conn = new MySqlConnection(DataSource());

            try
            {
                conn.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return conn;
        }

        private static string DataSource()
        {
            MySqlConnectionStringBuilder connection_string = new MySqlConnectionStringBuilder();

            connection_string.Server = _Server;
            connection_string.UserID = _UserID;
            connection_string.Password = _Password;
            connection_string.Database = _Database;

            return connection_string.ToString();
        }
    }
}
