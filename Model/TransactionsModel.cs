using MySql.Data.MySqlClient;
using StudentInfoSys.Core;
using StudentInfoSys.DataObject;
using System.ComponentModel;

namespace StudentInfoSys.Model
{
    internal class TransactionsModel : DBConnection
    {

        private const string _create_query = @"INSERT INTO `paymenthistory`(`referencenumber`, `studentid`, `coursecode`, `year`, `unit`, `installmentperiod`, `paymentmethod`, `phonenumber`, `recievername`, `amountpaid`, `remainingbalance`, `datesent`, `daterecieved`, `status`) VALUES ( @referencenumber , @studentid , @coursecode , @year , @unit , @installmentperiod , @paymentmethod , @phonenumber , @receivername , @amountpaid , @remainingbalance , NOW() , NOW() , @status)";
        private const string _get_refnumber = "SELECT `referencenumber` FROM `paymenthistory` WHERE `referencenumber` = @refnum";
        private const string _get_all = "SELECT * FROM `paymenthistory` WHERE `studentid` = @studentid";
    
        public static void CreateTransactions(Transactions transaction)
        {
            using(MySqlConnection conn = Connect())
            {
                 try
                 {
                        MySqlCommand cmd = new MySqlCommand(_create_query, conn);

                        cmd.Parameters.AddWithValue("@referencenumber", transaction.GetReferenceNumber());
                        cmd.Parameters.AddWithValue("@studentid", transaction.studentid);
                        cmd.Parameters.AddWithValue("@coursecode", transaction.coursecode);
                        cmd.Parameters.AddWithValue("@year", transaction.year);
                        cmd.Parameters.AddWithValue("@unit", transaction.unit);
                        cmd.Parameters.AddWithValue("@installmentperiod", transaction.installmentperiod);
                        cmd.Parameters.AddWithValue("@paymentmethod", transaction.paymentmethod);
                        cmd.Parameters.AddWithValue("@phonenumber", transaction.phonenumber);
                        cmd.Parameters.AddWithValue("@receivername", transaction.receivername);
                        cmd.Parameters.AddWithValue("@amountpaid", transaction.amountpaid);
                        cmd.Parameters.AddWithValue("@remainingbalance", transaction.remainingbalance);
                        cmd.Parameters.AddWithValue("@status", transaction.status);

                        cmd.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public static bool IsReferenceNumExist(string referencenum)
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(_get_refnumber, conn);

                    cmd.Parameters.AddWithValue("@refnum", referencenum);

                    var reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        return true;
                    }

                    return false;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public static BindingList<Transactions> Get()
        {
            using(MySqlConnection conn = Connect())
            {
                try
                {
                    BindingList<Transactions> transaction_lists = new BindingList<Transactions>();
                    MySqlCommand cmd = new MySqlCommand(_get_all, conn);

                    cmd.Parameters.AddWithValue("@studentid", MyAppData.StudentID);

                    var reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Transactions transactions = new Transactions
                        {
                            transactionid = Convert.ToInt32(reader["transactionid"]),
                            referencenumber = reader["referencenumber"].ToString(),
                            studentid = Convert.ToInt32(reader["studentid"]),
                            coursecode = reader["coursecode"].ToString(),
                            year = Convert.ToInt32(reader["year"]),
                            unit = Convert.ToInt32(reader["unit"]),
                            installmentperiod = Convert.ToInt32(reader["installmentperiod"]),
                            paymentmethod = reader["paymentmethod"].ToString(),
                            phonenumber = reader["phonenumber"].ToString(),
                            receivername = reader["recievername"].ToString(),
                            amountpaid = Convert.ToDouble(reader["amountpaid"]),
                            remainingbalance = Convert.ToDouble(reader["remainingbalance"]),
                            datesent = Convert.ToDateTime(reader["datesent"]),
                            daterecieved = Convert.ToDateTime(reader["daterecieved"]),
                            status = reader["status"].ToString()
                            
                        };
                        transaction_lists.Add(transactions);
                    }

                    return transaction_lists;

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