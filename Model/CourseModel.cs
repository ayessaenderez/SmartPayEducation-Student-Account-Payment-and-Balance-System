using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;

namespace StudentInfoSys.Model
{
    internal class CourseModel : DBConnection
    {
        private const string _get_query = @"SELECT * FROM `courses` WHERE `courseid` = @courseid";
        private const string _get_all_query = @"SELECT * FROM `courses`";
        private const string _get_coursename = @"SELECT `coursename` FROM `courses` WHERE `coursecode` = @code";
        private const string _get_courseid = @"SELECT `courseid` FROM `courses` WHERE `coursecode` = @code";


        public static int GetCourseID(string code)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_courseid, conn);

                    cmd.Parameters.AddWithValue("@code", code);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static Course? Get()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_query, conn);

                    cmd.Parameters.AddWithValue("@courseid", MyAppData.CourseID);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Course
                        {
                            courseid = Convert.ToInt32(reader["courseid"]),
                            coursename = reader["coursename"].ToString(),
                            coursecode = reader["coursecode"].ToString()
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




        public static List<Course?> GetALL()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    List<Course?> courses = new List<Course?>();

                    MySqlCommand cmd = new MySqlCommand(_get_all_query, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Course course = new Course
                        {
                            courseid = Convert.ToInt32(reader["courseid"]),
                            coursename = reader["coursename"].ToString(),
                            coursecode = reader["coursecode"].ToString()
                        };

                        courses.Add(course);
                    }

                    return courses;

                }
                catch (Exception)
                {

                    throw;
                }



            }

        }

        public static string? GetCourseName(string coursecode)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_coursename, conn);

                    cmd.Parameters.AddWithValue("@code", coursecode);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader["coursename"].ToString();
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
