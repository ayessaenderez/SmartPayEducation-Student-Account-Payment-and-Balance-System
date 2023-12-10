namespace StudentInfoSys.DataObject
{
    internal class EnrollmentData
    {
        public int enrollmentid { get; set; }
        public int studentid { get; set; }
        public int courseid { get; set; }
        public int year { get; set; }
        public int unit { get; set; }
        public string? status { get; set; }
        public bool completed { get; set; }
        public DateTime date_registered { get; set; }
        public DateTime date_enrolled { get; set; }

    }
}
