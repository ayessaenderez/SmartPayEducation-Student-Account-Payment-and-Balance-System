namespace StudentInfoSys.View
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            lblName = new Label();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnLogout = new Button();
            lbl1stInstallment = new Label();
            lbl2ndInstallment = new Label();
            lbl3rdInstallment = new Label();
            lbl4thInstallment = new Label();
            lbl5thInstallment = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            lblTotal = new Label();
            lbl1stDue = new Label();
            lbl2ndDue = new Label();
            lbl3rdDue = new Label();
            lbl4thDue = new Label();
            lbl5thDue = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label11 = new Label();
            lbl1stDate = new Label();
            lbl2ndDate = new Label();
            lbl3rdDate = new Label();
            lbl4thDate = new Label();
            lbl5thDate = new Label();
            label17 = new Label();
            label18 = new Label();
            btnProfile = new Button();
            btnAccount = new Button();
            btnTuition = new Button();
            btnUnitCacl = new Button();
            lblyrunit = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(25, 21);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(126, 23);
            lblName.TabIndex = 0;
            lblName.Text = "WELCOME |";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(25, 70);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(252, 23);
            lblTime.TabIndex = 1;
            lblTime.Text = "January 01, 2023 00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Firebrick;
            btnLogout.Location = new Point(596, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(147, 41);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbl1stInstallment
            // 
            lbl1stInstallment.AutoSize = true;
            lbl1stInstallment.Dock = DockStyle.Fill;
            lbl1stInstallment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1stInstallment.Location = new Point(157, 2);
            lbl1stInstallment.Name = "lbl1stInstallment";
            lbl1stInstallment.Size = new Size(167, 32);
            lbl1stInstallment.TabIndex = 3;
            lbl1stInstallment.Text = "0.00";
            lbl1stInstallment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2ndInstallment
            // 
            lbl2ndInstallment.AutoSize = true;
            lbl2ndInstallment.Dock = DockStyle.Fill;
            lbl2ndInstallment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2ndInstallment.Location = new Point(157, 70);
            lbl2ndInstallment.Name = "lbl2ndInstallment";
            lbl2ndInstallment.Size = new Size(167, 32);
            lbl2ndInstallment.TabIndex = 4;
            lbl2ndInstallment.Text = "0.00";
            lbl2ndInstallment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3rdInstallment
            // 
            lbl3rdInstallment.AutoSize = true;
            lbl3rdInstallment.Dock = DockStyle.Fill;
            lbl3rdInstallment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3rdInstallment.Location = new Point(157, 138);
            lbl3rdInstallment.Name = "lbl3rdInstallment";
            lbl3rdInstallment.Size = new Size(167, 32);
            lbl3rdInstallment.TabIndex = 5;
            lbl3rdInstallment.Text = "0.00";
            lbl3rdInstallment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4thInstallment
            // 
            lbl4thInstallment.AutoSize = true;
            lbl4thInstallment.Dock = DockStyle.Fill;
            lbl4thInstallment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4thInstallment.Location = new Point(157, 206);
            lbl4thInstallment.Name = "lbl4thInstallment";
            lbl4thInstallment.Size = new Size(167, 32);
            lbl4thInstallment.TabIndex = 6;
            lbl4thInstallment.Text = "0.00";
            lbl4thInstallment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl5thInstallment
            // 
            lbl5thInstallment.AutoSize = true;
            lbl5thInstallment.Dock = DockStyle.Fill;
            lbl5thInstallment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5thInstallment.Location = new Point(157, 274);
            lbl5thInstallment.Name = "lbl5thInstallment";
            lbl5thInstallment.Size = new Size(167, 32);
            lbl5thInstallment.TabIndex = 7;
            lbl5thInstallment.Text = "0.00";
            lbl5thInstallment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.44221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.39196F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTotal, 1, 10);
            tableLayoutPanel1.Controls.Add(lbl1stDue, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl2ndDue, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl3rdDue, 1, 5);
            tableLayoutPanel1.Controls.Add(lbl4thDue, 1, 7);
            tableLayoutPanel1.Controls.Add(lbl5thDue, 1, 9);
            tableLayoutPanel1.Controls.Add(lbl1stInstallment, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl2ndInstallment, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl3rdInstallment, 1, 4);
            tableLayoutPanel1.Controls.Add(lbl4thInstallment, 1, 6);
            tableLayoutPanel1.Controls.Add(lbl5thInstallment, 1, 8);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 8);
            tableLayoutPanel1.Controls.Add(label11, 0, 10);
            tableLayoutPanel1.Controls.Add(lbl1stDate, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl2ndDate, 2, 2);
            tableLayoutPanel1.Controls.Add(lbl3rdDate, 2, 4);
            tableLayoutPanel1.Controls.Add(lbl4thDate, 2, 6);
            tableLayoutPanel1.Controls.Add(lbl5thDate, 2, 8);
            tableLayoutPanel1.Location = new Point(34, 186);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.Size = new Size(459, 383);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 2);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 13;
            label2.Text = "1st Installment";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(157, 342);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(167, 39);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "5000.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1stDue
            // 
            lbl1stDue.AutoSize = true;
            lbl1stDue.Dock = DockStyle.Fill;
            lbl1stDue.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1stDue.ForeColor = Color.IndianRed;
            lbl1stDue.Location = new Point(157, 36);
            lbl1stDue.Name = "lbl1stDue";
            lbl1stDue.Size = new Size(167, 32);
            lbl1stDue.TabIndex = 8;
            lbl1stDue.Text = "5% due + 130";
            lbl1stDue.TextAlign = ContentAlignment.MiddleRight;
            lbl1stDue.Visible = false;
            // 
            // lbl2ndDue
            // 
            lbl2ndDue.AutoSize = true;
            lbl2ndDue.Dock = DockStyle.Fill;
            lbl2ndDue.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2ndDue.ForeColor = Color.IndianRed;
            lbl2ndDue.Location = new Point(157, 104);
            lbl2ndDue.Name = "lbl2ndDue";
            lbl2ndDue.Size = new Size(167, 32);
            lbl2ndDue.TabIndex = 9;
            lbl2ndDue.Text = "5% due + 130";
            lbl2ndDue.TextAlign = ContentAlignment.MiddleRight;
            lbl2ndDue.Visible = false;
            // 
            // lbl3rdDue
            // 
            lbl3rdDue.AutoSize = true;
            lbl3rdDue.Dock = DockStyle.Fill;
            lbl3rdDue.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3rdDue.ForeColor = Color.IndianRed;
            lbl3rdDue.Location = new Point(157, 172);
            lbl3rdDue.Name = "lbl3rdDue";
            lbl3rdDue.Size = new Size(167, 32);
            lbl3rdDue.TabIndex = 10;
            lbl3rdDue.Text = "5% due + 130";
            lbl3rdDue.TextAlign = ContentAlignment.MiddleRight;
            lbl3rdDue.Visible = false;
            // 
            // lbl4thDue
            // 
            lbl4thDue.AutoSize = true;
            lbl4thDue.Dock = DockStyle.Fill;
            lbl4thDue.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4thDue.ForeColor = Color.IndianRed;
            lbl4thDue.Location = new Point(157, 240);
            lbl4thDue.Name = "lbl4thDue";
            lbl4thDue.Size = new Size(167, 32);
            lbl4thDue.TabIndex = 11;
            lbl4thDue.Text = "5% due + 130";
            lbl4thDue.TextAlign = ContentAlignment.MiddleRight;
            lbl4thDue.Visible = false;
            // 
            // lbl5thDue
            // 
            lbl5thDue.AutoSize = true;
            lbl5thDue.Dock = DockStyle.Fill;
            lbl5thDue.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5thDue.ForeColor = Color.IndianRed;
            lbl5thDue.Location = new Point(157, 308);
            lbl5thDue.Name = "lbl5thDue";
            lbl5thDue.Size = new Size(167, 32);
            lbl5thDue.TabIndex = 12;
            lbl5thDue.Text = "5% due + 130";
            lbl5thDue.TextAlign = ContentAlignment.MiddleRight;
            lbl5thDue.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 70);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 14;
            label3.Text = "2nd Installment";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(5, 138);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 15;
            label4.Text = "3rd Installment";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 206);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 16;
            label5.Text = "4th Installment";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 274);
            label6.Name = "label6";
            label6.Size = new Size(144, 32);
            label6.TabIndex = 17;
            label6.Text = "5th Installment";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(5, 342);
            label11.Name = "label11";
            label11.Size = new Size(144, 39);
            label11.TabIndex = 18;
            label11.Text = "TOTAL";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1stDate
            // 
            lbl1stDate.AutoSize = true;
            lbl1stDate.Dock = DockStyle.Fill;
            lbl1stDate.Location = new Point(332, 2);
            lbl1stDate.Name = "lbl1stDate";
            lbl1stDate.Size = new Size(122, 32);
            lbl1stDate.TabIndex = 19;
            lbl1stDate.Text = "01-01-2023";
            lbl1stDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2ndDate
            // 
            lbl2ndDate.AutoSize = true;
            lbl2ndDate.Dock = DockStyle.Fill;
            lbl2ndDate.Location = new Point(332, 70);
            lbl2ndDate.Name = "lbl2ndDate";
            lbl2ndDate.Size = new Size(122, 32);
            lbl2ndDate.TabIndex = 20;
            lbl2ndDate.Text = "01-01-2023";
            lbl2ndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3rdDate
            // 
            lbl3rdDate.AutoSize = true;
            lbl3rdDate.Dock = DockStyle.Fill;
            lbl3rdDate.Location = new Point(332, 138);
            lbl3rdDate.Name = "lbl3rdDate";
            lbl3rdDate.Size = new Size(122, 32);
            lbl3rdDate.TabIndex = 21;
            lbl3rdDate.Text = "01-01-2023";
            lbl3rdDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4thDate
            // 
            lbl4thDate.AutoSize = true;
            lbl4thDate.Dock = DockStyle.Fill;
            lbl4thDate.Location = new Point(332, 206);
            lbl4thDate.Name = "lbl4thDate";
            lbl4thDate.Size = new Size(122, 32);
            lbl4thDate.TabIndex = 22;
            lbl4thDate.Text = "01-01-2023";
            lbl4thDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl5thDate
            // 
            lbl5thDate.AutoSize = true;
            lbl5thDate.Dock = DockStyle.Fill;
            lbl5thDate.Location = new Point(332, 274);
            lbl5thDate.Name = "lbl5thDate";
            lbl5thDate.Size = new Size(122, 32);
            lbl5thDate.TabIndex = 23;
            lbl5thDate.Text = "01-01-2023";
            lbl5thDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(365, 162);
            label17.Name = "label17";
            label17.Size = new Size(101, 23);
            label17.TabIndex = 9;
            label17.Text = "Due Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(241, 162);
            label18.Name = "label18";
            label18.Size = new Size(87, 23);
            label18.TabIndex = 10;
            label18.Text = "Amount";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Firebrick;
            btnProfile.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(596, 357);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(147, 41);
            btnProfile.TabIndex = 11;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Firebrick;
            btnAccount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(596, 415);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(147, 41);
            btnAccount.TabIndex = 12;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnTuition
            // 
            btnTuition.BackColor = Color.Firebrick;
            btnTuition.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTuition.ForeColor = Color.White;
            btnTuition.Location = new Point(596, 473);
            btnTuition.Name = "btnTuition";
            btnTuition.Size = new Size(147, 41);
            btnTuition.TabIndex = 13;
            btnTuition.Text = "Tuition";
            btnTuition.UseVisualStyleBackColor = false;
            btnTuition.Click += btnTuition_Click;
            // 
            // btnUnitCacl
            // 
            btnUnitCacl.BackColor = Color.Firebrick;
            btnUnitCacl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnitCacl.ForeColor = Color.White;
            btnUnitCacl.Location = new Point(596, 527);
            btnUnitCacl.Name = "btnUnitCacl";
            btnUnitCacl.Size = new Size(147, 41);
            btnUnitCacl.TabIndex = 14;
            btnUnitCacl.Text = "Unit Calculator";
            btnUnitCacl.UseVisualStyleBackColor = false;
            btnUnitCacl.Click += btnUnitCacl_Click;
            // 
            // lblyrunit
            // 
            lblyrunit.AutoSize = true;
            lblyrunit.BackColor = Color.Transparent;
            lblyrunit.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblyrunit.ForeColor = Color.White;
            lblyrunit.Location = new Point(25, 113);
            lblyrunit.Margin = new Padding(4, 0, 4, 0);
            lblyrunit.Name = "lblyrunit";
            lblyrunit.Size = new Size(153, 23);
            lblyrunit.TabIndex = 15;
            lblyrunit.Text = "YR: 1 | 20 units";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_red_and_white_red_aesthetic4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 623);
            ControlBox = false;
            Controls.Add(lblyrunit);
            Controls.Add(btnUnitCacl);
            Controls.Add(btnTuition);
            Controls.Add(btnAccount);
            Controls.Add(btnProfile);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnLogout);
            Controls.Add(lblTime);
            Controls.Add(lblName);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Button btnLogout;
        private Label lbl1stInstallment;
        private Label lbl2ndInstallment;
        private Label lbl3rdInstallment;
        private Label lbl4thInstallment;
        private Label lbl5thInstallment;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl5thDue;
        private Label lbl4thDue;
        private Label lbl3rdDue;
        private Label lbl2ndDue;
        private Label lbl1stDue;
        private Label lblTotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label11;
        private Label lbl1stDate;
        private Label lbl2ndDate;
        private Label lbl3rdDate;
        private Label lbl4thDate;
        private Label lbl5thDate;
        private Label label17;
        private Label label18;
        private Button btnProfile;
        private Button btnAccount;
        private Button btnTuition;
        private Button btnUnitCacl;
        private Label lblyrunit;
    }
}