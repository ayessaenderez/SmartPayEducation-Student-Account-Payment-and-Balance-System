using StudentInfoSys.Core;
using StudentInfoSys.DataObject;
using StudentInfoSys.Model;
using System.ComponentModel;

namespace StudentInfoSys.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Student? student = StudentModel.Get();
            EnrollmentData? enrollmentdata = EnrollmentModel.Get();
            lblName.Text = $@"Welcome | {student?.lastname?.ToUpper()}, {student?.firstname?.ToUpper()}";
            lblyrunit.Text = $@"YR: {enrollmentdata?.year.ToString()} | {enrollmentdata?.unit.ToString()} units";
            LoadInstallments();
            Notify();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("F");

            LoadInstallments();

        }

        private void Notify()
        {
            BindingList<Installment?> installments = InstallmentModel.Get();

            foreach (Installment? installment in installments)
            {
                if (installment?.installmentperiod == 1)
                {
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        MessageBox.Show("1st Installment is Past Due");
                    }
                }
                if (installment?.installmentperiod == 2)
                {
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        MessageBox.Show("2nd Installment is Past Due");
                    }
                }
                if (installment?.installmentperiod == 3)
                {
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        MessageBox.Show("3rd Installment is Past Due");
                    }
                }
                if (installment?.installmentperiod == 4)
                {
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        MessageBox.Show("4th Installment is Past Due");
                    }
                }
                if (installment?.installmentperiod == 5)
                {
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        MessageBox.Show("5th Installment is Past Due");
                    }
                }

            }
        }

        private void LoadInstallments()
        {
            BindingList<Installment?> installments = InstallmentModel.Get();

            double total = 0;
            double addfee = MyAppData.AdditionalPercent / 100;

            foreach (Installment? installment in installments)
            {
                if (installment?.installmentperiod == 1)
                {
                    lbl1stInstallment.Text = installment.remainingbalance.ToString();
                    lbl1stDate.Text = installment.duedate.ToShortDateString();
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        lbl1stInstallment.ForeColor = Color.Red;
                        lbl1stDue.Visible = true;
                        lbl2ndDue.Text = $@"over due + {installment?.additionalfeepercent.ToString()} %";

                        if (installment.originalamount == installment.totalamount)
                        {
                            double tax = installment.originalamount * addfee;
                            double totala = installment.originalamount + tax;
                            InstallmentModel.Update(new Installment
                            {
                                totalamount = totala,
                                remainingbalance = installment.remainingbalance + tax,
                                installmentid = installment.installmentid
                            });

                        }

                    }
                    else if (installment.remainingbalance == 0)
                    {
                        lbl1stInstallment.Visible = false;
                    }
                    else
                    {
                        lbl1stDue.Visible = false;
                        lbl1stInstallment.Visible = true;
                    }
                }
                if (installment?.installmentperiod == 2)
                {
                    lbl2ndInstallment.Text = installment.remainingbalance.ToString();
                    lbl2ndDate.Text = installment.duedate.ToShortDateString();
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        lbl2ndInstallment.ForeColor = Color.Red;
                        lbl2ndDue.Visible = true;
                        lbl2ndDue.Text = $@"over due + {installment?.additionalfeepercent.ToString()} %";
                        if (installment.originalamount == installment.totalamount)
                        {
                            double tax = installment.originalamount * addfee;
                            double totala = installment.originalamount + tax;
                            InstallmentModel.Update(new Installment
                            {
                                totalamount = totala,
                                remainingbalance = installment.remainingbalance + tax,
                                installmentid = installment.installmentid
                            });

                        }
                    }
                    else if (installment.remainingbalance == 0)
                    {
                        lbl2ndInstallment.Visible = false;
                    }
                    else
                    {
                        lbl2ndDue.Visible = false;
                        lbl2ndInstallment.Visible = true;
                    }
                }
                if (installment?.installmentperiod == 3)
                {
                    lbl3rdInstallment.Text = installment.remainingbalance.ToString();
                    lbl3rdDate.Text = installment.duedate.ToShortDateString();
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        lbl3rdInstallment.ForeColor = Color.Red;
                        lbl3rdDue.Visible = true;
                        lbl3rdDue.Text = $@"over due + {installment?.additionalfeepercent.ToString()} %";
                        if (installment.originalamount == installment.totalamount)
                        {
                            double tax = installment.originalamount * addfee;
                            double totala = installment.originalamount + tax;
                            InstallmentModel.Update(new Installment
                            {
                                totalamount = totala,
                                remainingbalance = installment.remainingbalance + tax,
                                installmentid = installment.installmentid
                            });

                        }
                    }
                    else if (installment.remainingbalance == 0)
                    {
                        lbl3rdInstallment.Visible = false;
                    }
                    else
                    {
                        lbl3rdDue.Visible = false;
                        lbl3rdInstallment.Visible = true;
                    }
                }
                if (installment?.installmentperiod == 4)
                {
                    lbl4thInstallment.Text = installment.remainingbalance.ToString();
                    lbl4thDate.Text = installment.duedate.ToShortDateString();
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        lbl4thInstallment.ForeColor = Color.Red;
                        lbl4thDue.Visible = true;
                        lbl4thDue.Text = $@"over due + {installment?.additionalfeepercent.ToString()} %";
                        if (installment.originalamount == installment.totalamount)
                        {
                            double tax = installment.originalamount * addfee;
                            double totala = installment.originalamount + tax;
                            InstallmentModel.Update(new Installment
                            {
                                totalamount = totala,
                                remainingbalance = installment.remainingbalance + tax,
                                installmentid = installment.installmentid
                            });

                        }
                    }
                    else if (installment.remainingbalance == 0)
                    {
                        lbl4thInstallment.Visible = false;
                    }
                    else
                    {
                        lbl4thDue.Visible = false;
                        lbl4thInstallment.Visible = true;
                    }
                }
                if (installment?.installmentperiod == 5)
                {
                    lbl5thInstallment.Text = installment.remainingbalance.ToString();
                    lbl5thDate.Text = installment.duedate.ToShortDateString();
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        lbl5thInstallment.ForeColor = Color.Red;
                        lbl5thDue.Visible = true;
                        lbl5thDue.Text = $@"over due + {installment?.additionalfeepercent.ToString()} %";
                        if (installment.originalamount == installment.totalamount)
                        {
                            double tax = installment.originalamount * addfee;
                            double totala = installment.originalamount + tax;
                            InstallmentModel.Update(new Installment
                            {
                                totalamount = totala,
                                remainingbalance = installment.remainingbalance + tax,
                                installmentid = installment.installmentid
                            });

                        }
                    }
                    else if (installment.remainingbalance == 0)
                    {
                        lbl5thInstallment.Visible = false;
                    }
                    else
                    {
                        lbl5thDue.Visible = false;
                        lbl5thInstallment.Visible = true;
                    }
                }
                total += installment.remainingbalance;
            }

            lblTotal.Text = total.ToString();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new Profile().ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            new Account().ShowDialog();
        }

        private void btnTuition_Click(object sender, EventArgs e)
        {
            new TuitionForm().ShowDialog();
        }

        private void btnUnitCacl_Click(object sender, EventArgs e)
        {
            new UnitCalculator().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            LoginForm form = new LoginForm();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}