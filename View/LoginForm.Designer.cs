namespace StudentInfoSys.View
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLogin = new Button();
            txtbxUsername = new TextBox();
            txtbxPwd = new TextBox();
            label2 = new Label();
            btnRegister = new Button();
            chckbxShowPwd = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 77);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Firebrick;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(124, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Location = new Point(124, 101);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(265, 32);
            txtbxUsername.TabIndex = 0;
            // 
            // txtbxPwd
            // 
            txtbxPwd.Location = new Point(124, 168);
            txtbxPwd.Name = "txtbxPwd";
            txtbxPwd.Size = new Size(265, 32);
            txtbxPwd.TabIndex = 1;
            txtbxPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 144);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Firebrick;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(275, 240);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // chckbxShowPwd
            // 
            chckbxShowPwd.AutoSize = true;
            chckbxShowPwd.BackColor = Color.Brown;
            chckbxShowPwd.CheckAlign = ContentAlignment.MiddleRight;
            chckbxShowPwd.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chckbxShowPwd.ForeColor = Color.White;
            chckbxShowPwd.Location = new Point(280, 201);
            chckbxShowPwd.Name = "chckbxShowPwd";
            chckbxShowPwd.Size = new Size(135, 23);
            chckbxShowPwd.TabIndex = 2;
            chckbxShowPwd.Text = "show password";
            chckbxShowPwd.UseVisualStyleBackColor = false;
            chckbxShowPwd.CheckedChanged += chckbxShowPwd_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(556, 403);
            Controls.Add(chckbxShowPwd);
            Controls.Add(btnRegister);
            Controls.Add(txtbxPwd);
            Controls.Add(label2);
            Controls.Add(txtbxUsername);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox txtbxUsername;
        private TextBox txtbxPwd;
        private Label label2;
        private Button btnRegister;
        private CheckBox chckbxShowPwd;
    }
}