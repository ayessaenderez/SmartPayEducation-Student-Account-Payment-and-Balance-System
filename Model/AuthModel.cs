using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;

namespace StudentInfoSys.Model
{
    internal class AuthModel : DBConnection
    {

        private const string _get_query = @"SELECT * FROM `users` WHERE `userid` = @userid";
        private const string _login_query = @"SELECT `userid` FROM `users` WHERE `username` = @username AND `password` = @pwd";
        private const string _create_query = @"INSERT INTO `users`(`username`, `password`, `email`) VALUES ( @username , @password , @email )";
        private const string _update_query = @"UPDATE `users` SET `username` = @username,`password` = @password,`email` = @email WHERE `userid` = @userid";


        public static void Create(UserAccount account)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                    cmd.Parameters.AddWithValue("@username", account.username);
                    cmd.Parameters.AddWithValue("@password", account.password);
                    cmd.Parameters.AddWithValue("@email", account.email);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void Update(UserAccount account)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_update_query, conn);

                    cmd.Parameters.AddWithValue("@username", account.username);
                    cmd.Parameters.AddWithValue("@password", account.password);
                    cmd.Parameters.AddWithValue("@email", account.email);
                    cmd.Parameters.AddWithValue("@userid", account.userid);

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
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(`userid`) FROM `users`", conn);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public static void Login(string username, string password)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_login_query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pwd", password);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MyAppData.IsLogin = true;
                        MyAppData.UserID = Convert.ToInt32(reader["userid"]);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static UserAccount? Get()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_query, conn);

                    cmd.Parameters.AddWithValue("@userid", MyAppData.UserID);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new UserAccount
                        {
                            username = reader["username"].ToString(),
                            password = reader["password"].ToString(),
                            email = reader["email"].ToString()
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
    }
}
