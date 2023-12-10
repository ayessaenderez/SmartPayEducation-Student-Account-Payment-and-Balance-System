using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;

namespace StudentInfoSys.Model
{
    internal class EnrollmentModel : DBConnection
    {
        private const string _get_query = @"SELECT `enrollmentdata`.* FROM `enrollmentdata` WHERE `enrollmentdata`.`enrollmentid` = @enrollmentid AND `enrollmentdata`.`completed` = 0";
        private const string _create_query = @"INSERT INTO `enrollmentdata`(`studentid`, `courseid`, `year`, `unit`, `status`, `completed`, `date_registered`, `date_enrolled`) VALUES ( @studentid , @courseid , @year , @unit , 'Enrolled', 0 , NOW() , NOW() )";

        public static void Create(EnrollmentData enrollmentData)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                    cmd.Parameters.AddWithValue("@studentid", enrollmentData.studentid);
                    cmd.Parameters.AddWithValue("@courseid", enrollmentData.courseid);
                    cmd.Parameters.AddWithValue("@year", enrollmentData.year);
                    cmd.Parameters.AddWithValue("@unit", enrollmentData.unit);

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
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(`enrollmentid`) FROM `enrollmentdata`", conn);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static EnrollmentData? Get()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_query, conn);

                    cmd.Parameters.AddWithValue("@enrollmentid", MyAppData.EnrollmentID);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new EnrollmentData
                        {
                            enrollmentid = Convert.ToInt32(reader["enrollmentid"]),
                            courseid = Convert.ToInt32(reader["courseid"]),
                            year = Convert.ToInt32(reader["year"]),
                            unit = Convert.ToInt32(reader["unit"]),
                            status = reader["status"].ToString(),
                            completed = Convert.ToBoolean(reader["completed"]),
                            date_enrolled = Convert.ToDateTime(reader["date_enrolled"])
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
