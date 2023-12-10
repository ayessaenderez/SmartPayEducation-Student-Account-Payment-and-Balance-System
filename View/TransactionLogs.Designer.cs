namespace StudentInfoSys.View
{
    partial class TransactionLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            paymenthistorydataview = new DataGridView();
            referencenumber = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            installmentperiod = new DataGridViewTextBoxColumn();
            paymentmethod = new DataGridViewTextBoxColumn();
            phonenumber = new DataGridViewTextBoxColumn();
            recievername = new DataGridViewTextBoxColumn();
            amountpaid = new DataGridViewTextBoxColumn();
            datesent = new DataGridViewTextBoxColumn();
            daterecieved = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            txtbxSearch = new TextBox();
            cbxFilter = new ComboBox();
            btnSearch = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)paymenthistorydataview).BeginInit();
            SuspendLayout();
            // 
            // paymenthistorydataview
            // 
            paymenthistorydataview.AllowUserToAddRows = false;
            paymenthistorydataview.AllowUserToDeleteRows = false;
            paymenthistorydataview.BackgroundColor = Color.SlateGray;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            paymenthistorydataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            paymenthistorydataview.ColumnHeadersHeight = 30;
            paymenthistorydataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            paymenthistorydataview.Columns.AddRange(new DataGridViewColumn[] { referencenumber, year, installmentperiod, paymentmethod, phonenumber, recievername, amountpaid, datesent, daterecieved, status });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            paymenthistorydataview.DefaultCellStyle = dataGridViewCellStyle5;
            paymenthistorydataview.EditMode = DataGridViewEditMode.EditProgrammatically;
            paymenthistorydataview.Location = new Point(12, 100);
            paymenthistorydataview.MultiSelect = false;
            paymenthistorydataview.Name = "paymenthistorydataview";
            paymenthistorydataview.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            paymenthistorydataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            paymenthistorydataview.RowHeadersVisible = false;
            paymenthistorydataview.RowHeadersWidth = 51;
            paymenthistorydataview.RowTemplate.Height = 25;
            paymenthistorydataview.Size = new Size(1083, 320);
            paymenthistorydataview.TabIndex = 2;
            // 
            // referencenumber
            // 
            referencenumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            referencenumber.DataPropertyName = "referencenumber";
            referencenumber.HeaderText = "Reference #";
            referencenumber.MinimumWidth = 6;
            referencenumber.Name = "referencenumber";
            referencenumber.ReadOnly = true;
            // 
            // year
            // 
            year.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            year.DataPropertyName = "year";
            year.HeaderText = "Year Level";
            year.MinimumWidth = 6;
            year.Name = "year";
            year.ReadOnly = true;
            year.Width = 114;
            // 
            // installmentperiod
            // 
            installmentperiod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            installmentperiod.DataPropertyName = "installmentperiod";
            installmentperiod.HeaderText = "Installment";
            installmentperiod.MinimumWidth = 6;
            installmentperiod.Name = "installmentperiod";
            installmentperiod.ReadOnly = true;
            installmentperiod.Width = 116;
            // 
            // paymentmethod
            // 
            paymentmethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            paymentmethod.DataPropertyName = "paymentmethod";
            paymentmethod.HeaderText = "Payment Method";
            paymentmethod.MinimumWidth = 6;
            paymentmethod.Name = "paymentmethod";
            paymentmethod.ReadOnly = true;
            paymentmethod.Width = 165;
            // 
            // phonenumber
            // 
            phonenumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phonenumber.DataPropertyName = "phonenumber";
            phonenumber.HeaderText = "Phone No.";
            phonenumber.MinimumWidth = 6;
            phonenumber.Name = "phonenumber";
            phonenumber.ReadOnly = true;
            phonenumber.Width = 114;
            // 
            // recievername
            // 
            recievername.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            recievername.DataPropertyName = "recievername";
            recievername.HeaderText = "Reciever Name";
            recievername.MinimumWidth = 6;
            recievername.Name = "recievername";
            recievername.ReadOnly = true;
            recievername.Width = 153;
            // 
            // amountpaid
            // 
            amountpaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amountpaid.DataPropertyName = "amountpaid";
            amountpaid.HeaderText = "Amount Paid";
            amountpaid.MinimumWidth = 6;
            amountpaid.Name = "amountpaid";
            amountpaid.ReadOnly = true;
            amountpaid.Width = 131;
            // 
            // datesent
            // 
            datesent.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datesent.DataPropertyName = "datesent";
            datesent.HeaderText = "Date Sent";
            datesent.MinimumWidth = 6;
            datesent.Name = "datesent";
            datesent.ReadOnly = true;
            datesent.Width = 109;
            // 
            // daterecieved
            // 
            daterecieved.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            daterecieved.DataPropertyName = "daterecieved";
            daterecieved.HeaderText = "Date Received";
            daterecieved.MinimumWidth = 6;
            daterecieved.Name = "daterecieved";
            daterecieved.ReadOnly = true;
            daterecieved.Width = 150;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            status.DataPropertyName = "status";
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 79;
            // 
            // txtbxSearch
            // 
            txtbxSearch.Location = new Point(178, 38);
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.Size = new Size(525, 32);
            txtbxSearch.TabIndex = 3;
            txtbxSearch.TextChanged += txtbxSearch_TextChanged;
            txtbxSearch.KeyPress += txtbxSearch_KeyPress;
            // 
            // cbxFilter
            // 
            cbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Items.AddRange(new object[] { "Reference Number", "Year Level", "Installment", "Payment Method", "Phone No.", "Reciever Name", "Amount Paid" });
            cbxFilter.Location = new Point(709, 36);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(178, 31);
            cbxFilter.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Firebrick;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(893, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Firebrick;
            btnPrint.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(943, 443);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(152, 35);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // TransactionLogs
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_red_and_white_red_aesthetic1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 494);
            Controls.Add(btnPrint);
            Controls.Add(btnSearch);
            Controls.Add(cbxFilter);
            Controls.Add(txtbxSearch);
            Controls.Add(paymenthistorydataview);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransactionLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionLogs";
            Load += TransactionLogs_Load;
            ((System.ComponentModel.ISupportInitialize)paymenthistorydataview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView paymenthistorydataview;
        private DataGridViewTextBoxColumn referencenumber;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn installmentperiod;
        private DataGridViewTextBoxColumn paymentmethod;
        private DataGridViewTextBoxColumn phonenumber;
        private DataGridViewTextBoxColumn recievername;
        private DataGridViewTextBoxColumn amountpaid;
        private DataGridViewTextBoxColumn datesent;
        private DataGridViewTextBoxColumn daterecieved;
        private DataGridViewTextBoxColumn status;
        private TextBox txtbxSearch;
        private ComboBox cbxFilter;
        private Button btnSearch;
        private Button btnPrint;
    }
}