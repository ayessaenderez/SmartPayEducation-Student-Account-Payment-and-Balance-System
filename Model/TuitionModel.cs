using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;

namespace StudentInfoSys.Model
{
    internal class TuitionModel : DBConnection
    {

        private const string _get_balance_query = @"SELECT `balance` FROM `tuitionfee` WHERE `tuitionid` = @tuitionid";
        private const string _create_query = @"INSERT INTO `tuitionfee`(`enrollmentid`, `balance`) VALUES ( @enrollmentid , @balance )";

        public static void Create(Tuition tuition)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                    cmd.Parameters.AddWithValue("@enrollmentid", tuition.enrollmentid);
                    cmd.Parameters.AddWithValue("@balance", tuition.balance);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
            }    
        }

        public static int GetLastInsertedID()
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(`tuitionid`) FROM `tuitionfee`", conn);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static int GetBalance()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_balance_query, conn);

                    cmd.Parameters.AddWithValue("@tuitionid", MyAppData.TuitionID);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["balance"]);
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                return -1;
            }
        }
    }
}
