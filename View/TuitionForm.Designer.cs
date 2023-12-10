namespace StudentInfoSys.View
{
    partial class TuitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuitionForm));
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtnCashCounter = new RadioButton();
            rbtnGCash = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPercent = new Label();
            lblDueDate = new Label();
            lblAmount = new Label();
            lblInstallment = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblPhone = new Label();
            lblAccountName = new Label();
            btnPay = new Button();
            groupBox2 = new GroupBox();
            btnTransactionView = new Button();
            txtbxAmountPay = new TextBox();
            label4 = new Label();
            label8 = new Label();
            lblremainingbal = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)paymenthistorydataview).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // paymenthistorydataview
            // 
            paymenthistorydataview.AllowUserToAddRows = false;
            paymenthistorydataview.AllowUserToDeleteRows = false;
            paymenthistorydataview.BackgroundColor = Color.SlateGray;
            paymenthistorydataview.ColumnHeadersHeight = 30;
            paymenthistorydataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            paymenthistorydataview.Columns.AddRange(new DataGridViewColumn[] { referencenumber, year, installmentperiod, paymentmethod, phonenumber, recievername, amountpaid, datesent, daterecieved, status });
            paymenthistorydataview.EditMode = DataGridViewEditMode.EditProgrammatically;
            paymenthistorydataview.Location = new Point(12, 389);
            paymenthistorydataview.MultiSelect = false;
            paymenthistorydataview.Name = "paymenthistorydataview";
            paymenthistorydataview.ReadOnly = true;
            paymenthistorydataview.RowHeadersVisible = false;
            paymenthistorydataview.RowHeadersWidth = 51;
            paymenthistorydataview.RowTemplate.Height = 25;
            paymenthistorydataview.Size = new Size(674, 97);
            paymenthistorydataview.TabIndex = 0;
            // 
            // referencenumber
            // 
            referencenumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            referencenumber.DataPropertyName = "referencenumber";
            referencenumber.HeaderText = "Reference #";
            referencenumber.MinimumWidth = 6;
            referencenumber.Name = "referencenumber";
            referencenumber.ReadOnly = true;
            referencenumber.Width = 160;
            // 
            // year
            // 
            year.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            year.DataPropertyName = "year";
            year.HeaderText = "Year Level";
            year.MinimumWidth = 6;
            year.Name = "year";
            year.ReadOnly = true;
            year.Width = 144;
            // 
            // installmentperiod
            // 
            installmentperiod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            installmentperiod.DataPropertyName = "installmentperiod";
            installmentperiod.HeaderText = "Installment";
            installmentperiod.MinimumWidth = 6;
            installmentperiod.Name = "installmentperiod";
            installmentperiod.ReadOnly = true;
            installmentperiod.Width = 146;
            // 
            // paymentmethod
            // 
            paymentmethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            paymentmethod.DataPropertyName = "paymentmethod";
            paymentmethod.HeaderText = "Payment Method";
            paymentmethod.MinimumWidth = 6;
            paymentmethod.Name = "paymentmethod";
            paymentmethod.ReadOnly = true;
            paymentmethod.Width = 209;
            // 
            // phonenumber
            // 
            phonenumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phonenumber.DataPropertyName = "phonenumber";
            phonenumber.HeaderText = "Phone No.";
            phonenumber.MinimumWidth = 6;
            phonenumber.Name = "phonenumber";
            phonenumber.ReadOnly = true;
            phonenumber.Width = 140;
            // 
            // recievername
            // 
            recievername.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            recievername.DataPropertyName = "recievername";
            recievername.HeaderText = "Reciever Name";
            recievername.MinimumWidth = 6;
            recievername.Name = "recievername";
            recievername.ReadOnly = true;
            recievername.Width = 192;
            // 
            // amountpaid
            // 
            amountpaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amountpaid.DataPropertyName = "amountpaid";
            amountpaid.HeaderText = "Amount Paid";
            amountpaid.MinimumWidth = 6;
            amountpaid.Name = "amountpaid";
            amountpaid.ReadOnly = true;
            amountpaid.Width = 166;
            // 
            // datesent
            // 
            datesent.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datesent.DataPropertyName = "datesent";
            datesent.HeaderText = "Date Sent";
            datesent.MinimumWidth = 6;
            datesent.Name = "datesent";
            datesent.ReadOnly = true;
            datesent.Width = 136;
            // 
            // daterecieved
            // 
            daterecieved.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            daterecieved.DataPropertyName = "daterecieved";
            daterecieved.HeaderText = "Date Received";
            daterecieved.MinimumWidth = 6;
            daterecieved.Name = "daterecieved";
            daterecieved.ReadOnly = true;
            daterecieved.Width = 188;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            status.DataPropertyName = "status";
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 365);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 1;
            label1.Text = "Recent Paid";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkRed;
            groupBox1.Controls.Add(rbtnCashCounter);
            groupBox1.Controls.Add(rbtnGCash);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(705, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Method";
            // 
            // rbtnCashCounter
            // 
            rbtnCashCounter.AutoSize = true;
            rbtnCashCounter.Location = new Point(18, 45);
            rbtnCashCounter.Name = "rbtnCashCounter";
            rbtnCashCounter.Size = new Size(200, 27);
            rbtnCashCounter.TabIndex = 0;
            rbtnCashCounter.TabStop = true;
            rbtnCashCounter.Text = "Cash On Counter";
            rbtnCashCounter.UseVisualStyleBackColor = true;
            rbtnCashCounter.CheckedChanged += rbtnCashCounter_CheckedChanged;
            // 
            // rbtnGCash
            // 
            rbtnGCash.AutoSize = true;
            rbtnGCash.Location = new Point(18, 76);
            rbtnGCash.Name = "rbtnGCash";
            rbtnGCash.Size = new Size(103, 27);
            rbtnGCash.TabIndex = 1;
            rbtnGCash.TabStop = true;
            rbtnGCash.Text = "GCASH";
            rbtnGCash.UseVisualStyleBackColor = true;
            rbtnGCash.CheckedChanged += rbtnGCash_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lblPercent, 1, 2);
            tableLayoutPanel1.Controls.Add(lblDueDate, 2, 1);
            tableLayoutPanel1.Controls.Add(lblAmount, 1, 1);
            tableLayoutPanel1.Controls.Add(lblInstallment, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Location = new Point(68, 72);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(525, 100);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Dock = DockStyle.Fill;
            lblPercent.ForeColor = Color.Red;
            lblPercent.Location = new Point(177, 66);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(169, 34);
            lblPercent.TabIndex = 7;
            lblPercent.Text = "+ 5%";
            lblPercent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Dock = DockStyle.Fill;
            lblDueDate.Location = new Point(352, 33);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(170, 33);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "12/30/2024";
            lblDueDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.Location = new Point(177, 33);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(169, 33);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "0.00";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstallment
            // 
            lblInstallment.AutoSize = true;
            lblInstallment.Dock = DockStyle.Fill;
            lblInstallment.Location = new Point(3, 33);
            lblInstallment.Name = "lblInstallment";
            lblInstallment.Size = new Size(168, 33);
            lblInstallment.TabIndex = 3;
            lblInstallment.Text = "1st Installment";
            lblInstallment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(352, 0);
            label7.Name = "label7";
            label7.Size = new Size(170, 33);
            label7.TabIndex = 2;
            label7.Text = "Due Date";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(177, 0);
            label6.Name = "label6";
            label6.Size = new Size(169, 33);
            label6.TabIndex = 1;
            label6.Text = "Amount";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 33);
            label5.TabIndex = 0;
            label5.Text = "Installment";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 288);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 4;
            label2.Text = "Account Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 311);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 5;
            label3.Text = "Phone Number:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(210, 311);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 23);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "[number]";
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.BackColor = Color.Transparent;
            lblAccountName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountName.ForeColor = Color.White;
            lblAccountName.Location = new Point(210, 290);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(167, 23);
            lblAccountName.TabIndex = 6;
            lblAccountName.Text = "[account name]";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Firebrick;
            btnPay.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(451, 287);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(142, 45);
            btnPay.TabIndex = 2;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkRed;
            groupBox2.Controls.Add(btnTransactionView);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(705, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transaction Log";
            // 
            // btnTransactionView
            // 
            btnTransactionView.ForeColor = Color.Firebrick;
            btnTransactionView.Location = new Point(18, 42);
            btnTransactionView.Name = "btnTransactionView";
            btnTransactionView.Size = new Size(193, 34);
            btnTransactionView.TabIndex = 0;
            btnTransactionView.Text = "VIEW\r\n\r\n\r\n";
            btnTransactionView.UseVisualStyleBackColor = true;
            btnTransactionView.Click += btnTransactionView_Click;
            // 
            // txtbxAmountPay
            // 
            txtbxAmountPay.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtbxAmountPay.Location = new Point(210, 205);
            txtbxAmountPay.Name = "txtbxAmountPay";
            txtbxAmountPay.Size = new Size(383, 44);
            txtbxAmountPay.TabIndex = 1;
            txtbxAmountPay.KeyPress += txtbxAmountPay_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(41, 220);
            label4.Name = "label4";
            label4.Size = new Size(162, 23);
            label4.TabIndex = 11;
            label4.Text = "Amount To Pay:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(608, 23);
            label8.Name = "label8";
            label8.Size = new Size(207, 23);
            label8.TabIndex = 12;
            label8.Text = "Remaining Balance:";
            // 
            // lblremainingbal
            // 
            lblremainingbal.AutoSize = true;
            lblremainingbal.BackColor = Color.Transparent;
            lblremainingbal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblremainingbal.ForeColor = Color.White;
            lblremainingbal.Location = new Point(812, 23);
            lblremainingbal.Name = "lblremainingbal";
            lblremainingbal.Size = new Size(49, 23);
            lblremainingbal.TabIndex = 13;
            lblremainingbal.Text = "0.00";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // TuitionForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_red_and_white_red_aesthetic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(948, 498);
            Controls.Add(lblremainingbal);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtbxAmountPay);
            Controls.Add(groupBox2);
            Controls.Add(btnPay);
            Controls.Add(lblPhone);
            Controls.Add(lblAccountName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(paymenthistorydataview);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TuitionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tuition";
            Load += Tuition_Load;
            ((System.ComponentModel.ISupportInitialize)paymenthistorydataview).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView paymenthistorydataview;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnCashCounter;
        private RadioButton rbtnGCash;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label lblPhone;
        private Label lblAccountName;
        private Button btnPay;
        private GroupBox groupBox2;
        private Button btnTransactionView;
        private TextBox txtbxAmountPay;
        private Label label4;
        private Label lblPercent;
        private Label lblDueDate;
        private Label lblAmount;
        private Label lblInstallment;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label lblremainingbal;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
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
    }
}