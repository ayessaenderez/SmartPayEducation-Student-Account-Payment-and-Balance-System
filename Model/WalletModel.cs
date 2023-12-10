using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;

namespace StudentInfoSys.Model
{
    internal class WalletModel : DBConnection
    {

        private const string _get_query = @"SELECT * FROM `walletaccount` WHERE `walletid` = @walletid";
        private const string _create_query = @"INSERT INTO `walletaccount`(`accountname`, `phonenumber`) VALUES ( @accountname , @phonenumber )";
        private const string _update_query = @"UPDATE `walletaccount` SET `phonenumber` = @phonenumber,`accountname` = @accountname WHERE `walletid` = @walletid";

        public static Student? Get()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_query, conn);

                    cmd.Parameters.AddWithValue("@walletid", MyAppData.WalletID);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Student
                        {
                            accountname = reader["accountname"].ToString(),
                            phonenumber = reader["phonenumber"].ToString()
                        };
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                return null;
            }
        }

        public static void Create(Student student)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                    cmd.Parameters.AddWithValue("@accountname", student.accountname);
                    cmd.Parameters.AddWithValue("@phonenumber", student.phonenumber);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void Update(Student student)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_update_query, conn);

                    cmd.Parameters.AddWithValue("@phonenumber", student.phonenumber);
                    cmd.Parameters.AddWithValue("@accountname", student.accountname);
                    cmd.Parameters.AddWithValue("@walletid", student.walletid);

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
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(`walletid`) FROM `walletaccount`", conn);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
