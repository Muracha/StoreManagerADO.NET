using StoreManager.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private static int _attempts = 2;
        public static int _userID { get; private set; }
        public static  bool _loginSuccessful { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        //btnOk -Login ღილაკი 
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //თუ txtUsername.Text და txtPassword.Text ცარიელია, აჩვენებს ცარიელ ველებს ShowEmpty() გამოყენებით.
            if (txtUsername.Text != "" && txtPassword.Text != "")
                LoginSolution();
            else
                ShowEmpty();
        }

        // სისტემაში შესვლის  ფუნქცია.
        private void LoginSolution()
        {
            //თუ _userID > 0 (_userID-ის ენიჭება -1 ან userID ) მაშინ ხურავს ფანჯარას ან გვაძლევს 3 მცდელობას.
            //3 წარუმატებელი მცდელობისას გამოდის აპლიკაციიდან. 

            if ((_userID = _userService.Login(txtUsername.Text, txtPassword.Text)) > 0)
            {
                _loginSuccessful = true;
                this.Close();
            }
            else if (_attempts >= 1)
            {
                MessageBox.Show($"The login or password is incorrect! {_attempts--} - attempts left");
                TryAgain();
            }
            else
            {
                MessageBox.Show("Login failed!");
                Application.Exit();
            }
        }

        //აფერადებს ცარიელ textbox-ებს.
        public  void ShowEmpty()
        {
            if (txtUsername.Text == string.Empty)
                pnlUserName.BackColor = Color.Red;
            if (txtUsername.Text != string.Empty)
                pnlUserName.BackColor = Color.Green;
            if (txtPassword.Text == string.Empty)
                pnlPassword.BackColor = Color.Red;
            if (txtPassword.Text != string.Empty)
                pnlPassword.BackColor = Color.Green;
        }

        //წარუმატებელი მცდელობისას იწყებს თავიდან.
        private void TryAgain()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            pnlUserName.BackColor = Color.Transparent;
            pnlPassword.BackColor = Color.Transparent;
        }

        // აჩვენებს დამალულ პაროლს და ან პირიქით.
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        //ხურავს აპლიკაციას cancel ღილაკის დაჭერისას.
        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        // txtUsername-textbox.
        private void TxtUsername_TextChanged(object sender, EventArgs e) => ShowEmpty();

        // txtPassword-textbox.
        private void TxtPassword_TextChanged(object sender, EventArgs e) => ShowEmpty();

        // form closing
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_loginSuccessful)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
