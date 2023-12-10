rusing MySql.Data.MySqlClient;
using StudentInfoSys.Core;

namespace StudentInfoSys.Model
{
    internal class ConfigModel : DBConnection
    {




        private const string _get_foreign_keys = @"SELECT `users`.`userid`, `personaldata`.`studentid`, `walletaccount`.`walletid`, `enrollmentdata`.`enrollmentid`, `courses`.`courseid`, `tuitionfee`.`tuitionid` FROM `users` LEFT JOIN `personaldata` ON `personaldata`.`userid` = `users`.`userid` LEFT JOIN `walletaccount` ON `personaldata`.`walletid` = `walletaccount`.`walletid` LEFT JOIN `enrollmentdata` ON `enrollmentdata`.`studentid` = `personaldata`.`studentid` LEFT JOIN `courses` ON `enrollmentdata`.`courseid` = `courses`.`courseid` LEFT JOIN `tuitionfee` ON `tuitionfee`.`enrollmentid` = `enrollmentdata`.`enrollmentid` WHERE `users`.`userid` = @userid AND `enrollmentdata`.`completed` = 0";

        public static void GetAllForeignID()
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_foreign_keys, conn);

                    cmd.Parameters.AddWithValue("@userid", MyAppData.UserID);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MyAppData.StudentID = Convert.ToInt32(reader["studentid"]);
                        MyAppData.WalletID = Convert.ToInt32(reader["walletid"]);
                        MyAppData.EnrollmentID = Convert.ToInt32(reader["enrollmentid"]);
                        MyAppData.CourseID = Convert.ToInt32(reader["courseid"]);
                        MyAppData.TuitionID = Convert.ToInt32(reader["tuitionid"]);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
