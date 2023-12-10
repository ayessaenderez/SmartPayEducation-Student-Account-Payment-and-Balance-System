using StudentInfoSys.Core;
using StudentInfoSys.DataObject;
using StudentInfoSys.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSys.View
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (btnSaveAccnt.Enabled != true && btnSaveWallet.Enabled != true && btnSaveProfile.Enabled != true)
            {

                // sequence for inserting data
                // - AuthModel / UserAccount
                // - WalletModel / Wallet
                // - StudentModel / Student
                // - EnrollmentModel / EnrollmentData
                // - TuitionModel / Tuition
                // - InstallmentModel / Installment

                AuthModel.Create(new UserAccount
                {
                    username = txtbxUsername.Text,
                    password = txtbxPassword.Text,
                    email = txtbxEmail.Text
                });

                WalletModel.Create(new Student
                {
                    accountname = txtbxAccntName.Text,
                    phonenumber = txtbxPhoneNumber.Text
                });

                int uuserid = AuthModel.GetLastInsertedID();
                int wwalletid = WalletModel.GetLastInsertedID();

                StudentModel.Create(new Student
                {
                    userid = uuserid,
                    lastname = txtbxLastName.Text,
                    firstname = txtbxFirstName.Text,
                    gender = cbxGender.Text,
                    age = Convert.ToInt32(txtbxAge.Text),
                    address = txtbxAddress.Text,
                    walletid = wwalletid
                });

                int sstudentid = StudentModel.GetLastInsertedID();
                int ccourseid = CourseModel.GetCourseID(cbxCourseCode.Text);

                Random rnd = new Random();
                int rndunit = rnd.Next(20, 22);

                EnrollmentModel.Create(new EnrollmentData
                {
                    studentid = sstudentid,
                    courseid = ccourseid,
                    year = Convert.ToInt32(cbxYearLevel.Text),
                    unit = rndunit
                });


                int eenrollmentid = EnrollmentModel.GetLastInsertedID();
                double tuitionbalance = rndunit * MyAppData.AmountPerUnit;

                TuitionModel.Create(new Tuition
                {
                    enrollmentid = eenrollmentid,
                    balance = tuitionbalance
                });

                int ttuitionid = TuitionModel.GetLastInsertedID();
                double ooriginalamount = tuitionbalance / 5;
                DateTime currdate = DateTime.Now;
                DateTime idate = new DateTime();
                idate = currdate;
                int i;
                for (i = 1; i < 6; i++)
                {
                    idate = idate.AddDays(15);
                    InstallmentModel.Create(new Installment
                    {
                        tuitionid = ttuitionid,
                        installmentperiod = i,
                        originalamount = ooriginalamount,
                        duedate = idate,
                        additionalfeepercent = MyAppData.AdditionalPercent,
                        totalamount = ooriginalamount,
                        remainingbalance = ooriginalamount
                    });
                }

                MessageBox.Show("Student Added Successfully.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("All Must Save First.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAccnt_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txtbxUsername.Text == string.Empty)
            {
                message = "Username cannot be Empty";
                txtbxUsername.Focus();
            }
            else if (txtbxPassword.Text == string.Empty)
            {
                message = "Password cannot be Empty";
                txtbxPassword.Focus();
            }
            else if (txtbxCPassword.Text == string.Empty)
            {
                message = "Confirm Password First";
                txtbxCPassword.Focus();
            }
            else if (txtbxPassword.Text != txtbxCPassword.Text)
            {
                message = "Password does not match";
                txtbxCPassword.Focus();
            }
            if (message != "") MessageBox.Show(message, "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (message == "")
            {
                txtbxUsername.Enabled = false;
                txtbxPassword.Enabled = false;
                txtbxCPassword.Enabled = false;
                txtbxEmail.Enabled = false;
                btnSaveAccnt.Enabled = false;
                btnEditAccount.Enabled = true;
            }
        }

        private void btnSaveWallet_Click(object sender, EventArgs e)
        {
            string message = "";
            if (txtbxAccntName.Text == string.Empty)
            {
                message = "Account name cannot be empty";
            }
            else if (txtbxPhoneNumber.Text == string.Empty)
            {
                message = "Phone number is required";
            }
            if (message != "") MessageBox.Show(message, "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (message == "")
            {
                txtbxAccntName.Enabled = false;
                txtbxPhoneNumber.Enabled = false;

                btnSaveWallet.Enabled = false;
                btnEditWallet.Enabled = true;
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            txtbxUsername.Enabled = true;
            txtbxPassword.Enabled = true;
            txtbxCPassword.Enabled = true;
            txtbxEmail.Enabled = true;
            btnSaveAccnt.Enabled = true;
            btnEditAccount.Enabled = false;
        }

        private void btnEditWallet_Click(object sender, EventArgs e)
        {
            txtbxAccntName.Enabled = true;
            txtbxPhoneNumber.Enabled = true;

            btnSaveWallet.Enabled = true;
            btnEditWallet.Enabled = false;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string message = "";

            if (txtbxLastName.Text == string.Empty || txtbxFirstName.Text == string.Empty)
            {
                message = "Full name is required";
            }
            else if (cbxGender.Text == string.Empty)
            {
                message = "Gender is required";
            }
            else if (txtbxAge.Text == string.Empty || txtbxAddress.Text == string.Empty)
            {
                message = "All Fields are required";
            }
            else if (cbxYearLevel.Text == string.Empty || txtbxCourseName.Text == string.Empty || cbxCourseCode.Text == string.Empty)
            {
                message = "Academic Info cannot be empty";
            }

            if (message != "") MessageBox.Show(message, "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (message == "")
            {
                txtbxFirstName.Enabled = false;
                txtbxLastName.Enabled = false;
                cbxGender.Enabled = false;
                txtbxAge.Enabled = false;
                txtbxAddress.Enabled = false;
                cbxYearLevel.Enabled = false;
                txtbxCourseName.Enabled = false;
                cbxCourseCode.Enabled = false;

                btnSaveProfile.Enabled = false;
                btnEditProfile.Enabled = true;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            txtbxFirstName.Enabled = true;
            txtbxLastName.Enabled = true;
            cbxGender.Enabled = true;
            txtbxAge.Enabled = true;
            txtbxAddress.Enabled = true;
            cbxYearLevel.Enabled = true;
            txtbxCourseName.Enabled = true;
            cbxCourseCode.Enabled = true;

            btnSaveProfile.Enabled = true;
            btnEditProfile.Enabled = false;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            cbxCourseCode.DisplayMember = "coursecode";
            cbxCourseCode.DataSource = CourseModel.GetALL();
        }

        private void cbxCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxCourseName.Text = CourseModel.GetCourseName(cbxCourseCode.Text);

        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
