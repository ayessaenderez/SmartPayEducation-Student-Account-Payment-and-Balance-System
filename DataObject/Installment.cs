namespace StudentInfoSys.DataObject
{
    internal class Installment
    {
        public int installmentid { get; set; }
        public int tuitionid { get; set; }
        public int installmentperiod { get; set; }
        public double originalamount { get; set; }
        public DateTime duedate { get; set; }
        public double additionalfeepercent { get; set; }
        public double totalamount { get; set; }
        public double remainingbalance { get; set; }

    }
}
