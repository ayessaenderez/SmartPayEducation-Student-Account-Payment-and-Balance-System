using DGVPrinterHelper;
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
    public partial class TuitionForm : Form
    {
        private static string _paymentmethod = "";
        private Bitmap? bitmap;
        public TuitionForm()
        {
            InitializeComponent();
        }



        private void Tuition_Load(object sender, EventArgs e)
        {
            LoadInstallment();
        }

        private void rbtnGCash_CheckedChanged(object sender, EventArgs e)
        {
            _paymentmethod = "GCASH";
        }

        private void rbtnCashCounter_CheckedChanged(object sender, EventArgs e)
        {
            _paymentmethod = "CASH ON COUNTER";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rbtnCashCounter.Checked == false && rbtnGCash.Checked == false)
            {
                MessageBox.Show("Select Payment Method First", "Tuition Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtbxAmountPay.Text == "")
            {
                MessageBox.Show("Input Value First", "Tuition Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double amountinput = Convert.ToDouble(txtbxAmountPay.Text);
            foreach (Installment? installment in InstallmentModel.Get())
            {
                if (amountinput <= 0) break;
                if (installment.remainingbalance > 0)
                {
                    double remainingbal = installment.remainingbalance;
                    double amountpaid = amountinput;

                    while (amountinput > 0 && remainingbal > 0)
                    {

                        double deduction = Math.Min(amountinput, remainingbal);
                        remainingbal -= deduction;
                        amountinput -= deduction;

                    }

                    double result = remainingbal;
                    string coursecode = CourseModel.Get().coursecode;
                    int year = EnrollmentModel.Get().year;
                    int unit = EnrollmentModel.Get().unit;


                    TransactionsModel.CreateTransactions(new Transactions
                    {
                        referencenumber = new Transactions().GetReferenceNumber(),
                        studentid = MyAppData.StudentID,
                        coursecode = CourseModel.Get().coursecode,
                        year = EnrollmentModel.Get().year,
                        unit = EnrollmentModel.Get().unit,
                        installmentperiod = installment.installmentperiod,
                        paymentmethod = _paymentmethod,
                        phonenumber = WalletModel.Get().phonenumber,
                        receivername = "College portal",
                        amountpaid = amountpaid,
                        remainingbalance = result,
                        status = "Paid"
                    });

                    InstallmentModel.UpdateRemainingBal(new Installment
                    {
                        remainingbalance = result,
                        installmentid = installment.installmentid
                    });
                }
            }
            txtbxAmountPay.Text = "";
            LoadInstallment();
        }

        private void btnTransactionView_Click(object sender, EventArgs e)
        {
            //if (paymenthistorydataview.Rows.Count <= 0)
            //{
            //    return;
            //}
            ////Resize DataGridView to full height.
            //int height = paymenthistorydataview.Height;
            //paymenthistorydataview.Height = paymenthistorydataview.RowCount * paymenthistorydataview.RowTemplate.Height * 2;

            ////Create a Bitmap and draw the DataGridView on it.
            //bitmap = new Bitmap(this.paymenthistorydataview.Width, this.paymenthistorydataview.Height);
            //paymenthistorydataview.DrawToBitmap(bitmap, new Rectangle(0, 0, this.paymenthistorydataview.Width, this.paymenthistorydataview.Height));

            ////Resize DataGridView back to original height.
            //paymenthistorydataview.Height = height;

            ////Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.Width = this.paymenthistorydataview.Width;
            //printPreviewDialog1.Height = 420;
            //printPreviewDialog1.ShowDialog();

            new TransactionLogs().ShowDialog();
        }

        private void LoadInstallment()
        {

            double total = 0.00;
            int i = 0;

            foreach (Installment? installment in InstallmentModel.Get())
            {
                i++;
                if (installment?.installmentperiod == i && installment.remainingbalance > 0)
                {
                    lblInstallment.Text = $@"{installment.installmentperiod} Installment";
                    lblAmount.Text = installment.remainingbalance.ToString();
                    lblDueDate.Text = installment.duedate.ToShortDateString();
                    if (installment.duedate < DateTime.Today && installment.remainingbalance > 0)
                    {
                        lblPercent.Visible = true;
                        lblPercent.Text = $@"over due + {installment?.additionalfeepercent.ToString()} %";
                    }
                    else
                    {
                        lblPercent.Visible = false;

                    }
                    break;
                }
            }

            foreach (Installment? installment in InstallmentModel.Get())
            {
                total += installment.remainingbalance;
            }




            lblremainingbal.Text = total.ToString();


            Student student = WalletModel.Get();

            lblAccountName.Text = student.accountname;
            lblPhone.Text = student.phonenumber;


            paymenthistorydataview.AutoGenerateColumns = false;
            paymenthistorydataview.DataSource = TransactionsModel.Get();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (paymenthistorydataview.Rows.Count <= 0)
            {
                return;
            }
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void txtbxAmountPay_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
