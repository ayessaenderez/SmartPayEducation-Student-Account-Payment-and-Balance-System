using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;
using System.ComponentModel;

namespace StudentInfoSys.Model
{
    internal class InstallmentModel : DBConnection
    {
        private const string _get_query = "SELECT * FROM `installment` WHERE `tuitionid` = @tuitionid";
        private const string _create_query = @"INSERT INTO `installment`(`tuitionid`, `installmentperiod`, `originalamount`, `duedate`, `additionalfeepercent`, `totalamount`, `remainingbalance`) VALUES ( @tuitionid , @installmentperiod , @originalamount , @duedate , @additionalfeepercent , @totalamount , @remainingbalance)";
        private const string _update_duedate_query = @"UPDATE `installment` SET `totalamount` = @totalamount,`remainingbalance` = @remainingbalance WHERE `installmentid` = @installmentid";
        private const string _update_remainbal_query = @"UPDATE `installment` SET `remainingbalance` = @remainingbalance WHERE `installmentid` = @installmentid";


        public static void Create(Installment installment)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                    cmd.Parameters.AddWithValue("@tuitionid", installment.tuitionid);
                    cmd.Parameters.AddWithValue("@installmentperiod", installment.installmentperiod);
                    cmd.Parameters.AddWithValue("@originalamount", installment.originalamount);
                    cmd.Parameters.AddWithValue("@duedate", installment.duedate);
                    cmd.Parameters.AddWithValue("@additionalfeepercent", installment.additionalfeepercent);
                    cmd.Parameters.AddWithValue("@totalamount", installment.totalamount);
                    cmd.Parameters.AddWithValue("@remainingbalance", installment.remainingbalance);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void Update(Installment installment)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_update_duedate_query, conn);

                    cmd.Parameters.AddWithValue("@totalamount", installment.totalamount);
                    cmd.Parameters.AddWithValue("@remainingbalance", installment.remainingbalance);
                    cmd.Parameters.AddWithValue("@installmentid", installment.installmentid);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void UpdateRemainingBal(Installment installment)
        {
            using (MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_update_remainbal_query, conn);

                    cmd.Parameters.AddWithValue("@remainingbalance", installment.remainingbalance);
                    cmd.Parameters.AddWithValue("@installmentid", installment.installmentid);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static BindingList<Installment?> Get()
        {
            using (MySqlConnection conn = Connect())
            {

                try
                {
                    BindingList<Installment?> installments = new BindingList<Installment?>();
                    MySqlCommand cmd = new MySqlCommand(_get_query, conn);

                    cmd.Parameters.AddWithValue("@tuitionid", MyAppData.TuitionID);

                    var reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        Installment installment = new Installment
                        {
                            installmentid = Convert.ToInt32(reader["installmentid"]),
                            installmentperiod = Convert.ToInt32(reader["installmentperiod"]),
                            originalamount = Convert.ToDouble(reader["originalamount"]),
                            duedate = Convert.ToDateTime(reader["duedate"]),
                            additionalfeepercent = Convert.ToInt32(reader["additionalfeepercent"]),
                            totalamount = Convert.ToDouble(reader["totalamount"]),
                            remainingbalance = Convert.ToDouble(reader["remainingbalance"])
                        };
                        installments.Add(installment);
                    }
                    return installments;

                }
                catch (Exception)
                {

                    throw;
                }
                //return null;
            }
        }
    }
}
