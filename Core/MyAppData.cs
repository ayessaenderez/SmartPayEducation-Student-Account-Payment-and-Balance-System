namespace StudentInfoSys.Core
{
    public static class MyAppData
    {
        // Global runtime
        // technically nakastore padin sa memory ung values para makuha natin paulit ulit habang nagrurun ung app
        //userid studentid   walletid enrollmentid    courseid tuitionid

        public static bool IsLogin { get; set; }

        public static int UserID { get; set; }
        public static int StudentID { get; set; }
        public static int WalletID { get; set; }
        public static int EnrollmentID { get; set; }
        public static int CourseID { get; set; }
        public static int TuitionID { get; set; }

        public static double AmountPerUnit = 1500;
        public static double AdditionalPercent = 5;


        public static void Flush()
        {
            IsLogin = false;
            UserID = 0;
            StudentID = 0;
            WalletID = 0;
            EnrollmentID = 0;
            CourseID = 0;
            TuitionID = 0;
        }
    }
}
