using StudentInfoSys.Core;
using StudentInfoSys.DataObject;
using StudentInfoSys.Model;

namespace StudentInfoSys.View
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }


        private void Account_Load(object sender, EventArgs e)
        {
            LoadAccount();
            LoadWallet();
        }

        private void LoadAccount()
        {
            UserAccount? account = AuthModel.Get();

            txtbxUsername.Text = account?.username;
            txtbxPassword.Text = account?.password;
            txtbxCPassword.Text = "";
            txtbxEmail.Text = account?.email;

        }

        private void LoadWallet()
        {
            Student? wallet = WalletModel.Get();

            txtbxAccntName.Text = wallet?.accountname;
            txtbxPhoneNumber.Text = wallet?.phonenumber;
        }

        private void btnUpdateWallet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            WalletModel.Update(new Student
            {
                walletid = MyAppData.WalletID,
                accountname = txtbxAccntName.Text,
                phonenumber = txtbxPhoneNumber.Text
            });
            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateAccnt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            AuthModel.Update(new UserAccount
            {
                userid = MyAppData.UserID,
                username = txtbxUsername.Text,
                password = txtbxPassword.Text,
                email = txtbxEmail.Text
            });
            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
