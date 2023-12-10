using StudentInfoSys.Model;

namespace StudentInfoSys.DataObject
{
    internal class Transactions
    {
        public int transactionid { get; set;}
        public string? referencenumber { get; set; }
        public int studentid { get; set;}
        public string? coursecode { get; set;}
        public int year { get; set;}
        public int unit { get; set;}
        public int installmentperiod { get; set;}
        public string? paymentmethod { get; set;}
        public string? phonenumber { get; set;}
        public string? receivername { get; set;}
        public double amountpaid { get; set;}
        public double remainingbalance { get; set;}
        public DateTime? datesent { get; set;}
        public DateTime? daterecieved { get; set;}
        public string? status { get; set;}


        public string GetReferenceNumber()
        {
            // check first if exist in database
            // else proceed to use this reference number

            //ST20231201245959

            bool refexist = true; // add some methods from transactions if exist

            string refnum = "";

            do
            {
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();

                string hour = DateTime.Now.Hour.ToString();
                string minute = DateTime.Now.Minute.ToString();
                string secs = DateTime.Now.Second.ToString();
                string millisec = DateTime.Now.Millisecond.ToString();

                refnum = "ST" + year + month + day + hour + minute + secs + millisec;

                refexist = TransactionsModel.IsReferenceNumExist(refnum);

            } while (refexist);


            return refnum;

        }
    }
}
