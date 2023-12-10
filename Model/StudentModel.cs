using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;

namespace StudentInfoSys.Model
{
    internal class StudentModel : DBConnection
    {
        private const string _get_query = @"SELECT `personaldata`.* FROM `personaldata` WHERE `personaldata`.`userid` = @uid";
        private const string _create_query = @"INSERT INTO `personaldata`(`userid`, `lastname`, `firstname`, `gender`, `age`, `address`, `walletid`) VALUES ( @userid , @lastname , @firstname , @gender , @age , @address , @walletid )";
        private const string _update_query = @"UPDATE `personaldata` SET `lastname` = @lastname,`firstname` = @firstname,`gender` = @gender,`age` = @age,`address` = @address WHERE `studentid` = @studentid";

        public static void Update(Student student)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_update_query, conn);

                    cmd.Parameters.AddWithValue("@lastname", student.lastname);
                    cmd.Parameters.AddWithValue("@firstname", student.firstname);
                    cmd.Parameters.AddWithValue("@gender", student.gender);
                    cmd.Parameters.AddWithValue("@age", student.age);
                    cmd.Parameters.AddWithValue("@address", student.address);
                    cmd.Parameters.AddWithValue("@studentid", student.studentid);
                    

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static Student? Get()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_query, conn);

                    cmd.Parameters.AddWithValue("@uid", MyAppData.UserID);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Student
                        {
                            studentid = Convert.ToInt32(reader["studentid"]),
                            lastname = reader["lastname"].ToString(),
                            firstname = reader["firstname"].ToString(),
                            gender = reader["gender"].ToString(),
                            age = Convert.ToInt32(reader["age"]),
                            address = reader["address"].ToString(),
                            walletid = Convert.ToInt32(reader["walletid"])
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

        // CREATE STUDENT
        public static void Create(Student student)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                    cmd.Parameters.AddWithValue("@userid", student.userid);
                    cmd.Parameters.AddWithValue("@lastname", student.lastname);
                    cmd.Parameters.AddWithValue("@firstname", student.firstname);
                    cmd.Parameters.AddWithValue("@gender", student.gender);
                    cmd.Parameters.AddWithValue("@age", student.age);
                    cmd.Parameters.AddWithValue("@address", student.address);
                    cmd.Parameters.AddWithValue("@walletid", student.walletid);
                    //cmd.Parameters.AddWithValue("@phonenumber", student.phonenumber);
                    //cmd.Parameters.AddWithValue("@accountname", student.accountname);
                    //cmd.Parameters.AddWithValue("@date_created", student.data_created);

                    cmd.ExecuteNonQuery();
                    
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public static int GetLastInsertedID()
        {
            using(MySqlConnection conn = Connect())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(`studentid`) FROM `personaldata`", conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
