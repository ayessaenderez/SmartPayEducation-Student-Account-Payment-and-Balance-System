using StudentInfoSys.DataObject;
using StudentInfoSys.Model;

namespace StudentInfoSys.View
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            cbxCourseCode.ValueMember = "coursecode";
            cbxCourseCode.DataSource = CourseModel.GetALL();
            LoadStudentInfo();
            LoadAcademicInfo();
        }

        private void cbxCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxCourseName.Text = CourseModel.GetCourseName(cbxCourseCode.Text);
        }

        private void LoadStudentInfo()
        {
            Student? student = StudentModel.Get();

            txtbxStdID.Text = student?.studentid?.ToString();
            txtbxLastName.Text = student?.lastname?.ToString();
            txtbxFirstName.Text = student?.firstname?.ToString();
            cbxGender.Text = student?.gender?.ToString();
            txtbxAge.Text = student?.age?.ToString();
            txtbxAddress.Text = student?.address?.ToString();

        }
        private void LoadAcademicInfo()
        {
            EnrollmentData? enrollment = EnrollmentModel.Get();
            Course? course = CourseModel.Get();

            cbxYearLevel.Text = enrollment?.year.ToString();
            txtbxCourseName.Text = course?.coursename?.ToString();
            cbxCourseCode.Text = course?.coursecode?.ToString();
            txtbxUnit.Text = enrollment?.unit.ToString();
            txtbxStatus.Text = enrollment?.status?.ToString();
            txtbxDateEnrolled.Text = enrollment?.date_enrolled.ToShortDateString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            StudentModel.Update(new Student
            {
                lastname = txtbxLastName.Text,
                firstname = txtbxFirstName.Text,
                gender = cbxGender.Text,
                age = Convert.ToInt32(txtbxAge.Text),
                address = txtbxAddress.Text
            });
            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
