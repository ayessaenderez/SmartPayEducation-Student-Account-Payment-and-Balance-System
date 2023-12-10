using StudentInfoSys.Core;
using StudentInfoSys.Model;

namespace StudentInfoSys.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MyAppData.Flush();
        }

        private void chckbxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxShowPwd.Checked) txtbxPwd.UseSystemPasswordChar = false;
            else txtbxPwd.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthModel.Login(txtbxUsername.Text, txtbxPwd.Text);
            if (!MyAppData.IsLogin)
            {
                MessageBox.Show("User not found");
            }
            else
            {
                ConfigModel.GetAllForeignID();
                new Dashboard().Show();
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new CreateAccount().ShowDialog();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}