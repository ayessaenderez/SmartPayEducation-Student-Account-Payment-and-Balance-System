namespace StudentInfoSys.DataObject
{
    internal class Student : UserAccount
    {
        public int? studentid { get; set; }
        //public int? userid { get; set; }
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? gender { get; set; }
        public int? age { get; set; }
        public string? address { get; set; }
        public int? walletid { get; set; }
        public string? phonenumber { get; set; }
        public string? accountname { get; set; }
        public DateTime? date_created { get; set; }
    }
}
