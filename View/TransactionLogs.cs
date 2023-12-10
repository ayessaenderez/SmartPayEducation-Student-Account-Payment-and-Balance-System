using DGVPrinterHelper;
using Google.Protobuf.WellKnownTypes;
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
    public partial class TransactionLogs : Form
    {
        public TransactionLogs()
        {
            InitializeComponent();
        }

        private void TransactionLogs_Load(object sender, EventArgs e)
        {
            paymenthistorydataview.AutoGenerateColumns = false;
            paymenthistorydataview.DataSource = TransactionsModel.Get();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Payment History";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.ToString("f"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintPreviewDataGridView(paymenthistorydataview);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var columnname = "";

            //Installment
            //Payment Method
            //Phone No.
            //Reciever Name
            //Amount Paid

            DataTable dt = null;
            dt = ToDataTable<Transactions>(TransactionsModel.Get());
            DataView dv = dt.DefaultView;
            if (cbxFilter.Text == "" && columnname == "") return;
            if (cbxFilter.SelectedIndex == 0) columnname = "referencenumber";
            if (cbxFilter.SelectedIndex == 1) columnname = "year";
            if (cbxFilter.SelectedIndex == 2) columnname = "installmentperiod";
            if (cbxFilter.SelectedIndex == 3) columnname = "paymentmethod";
            if (cbxFilter.SelectedIndex == 4) columnname = "phonenumber";
            if (cbxFilter.SelectedIndex == 5) columnname = "recievername";
            if (cbxFilter.SelectedIndex == 6) columnname = "amountpaid";
            dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", columnname, txtbxSearch.Text.Trim());


            paymenthistorydataview.AutoGenerateColumns = false;
            paymenthistorydataview.DataSource = dt;
        }

        private void txtbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSearch.Text == "")
            {
                paymenthistorydataview.AutoGenerateColumns = false;
                paymenthistorydataview.DataSource = TransactionsModel.Get();
            }
        }

        public static DataTable ToDataTable<T>(BindingList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
