using StoreManager.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        public static int _userID;
        private static int _attempt = 2;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        //btnOk -Login ღილაკი 
        private void btnOk_Click(object sender, EventArgs e)
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
                this.Close();
            }
            else if (_attempt >= 1)
            {
                MessageBox.Show($"The login or password is incorrect! {_attempt--} - attempts left");
                TryAgain();
            }
            else
            {
                MessageBox.Show("Login failed!");
                Application.Exit();
            }
        }

        //აფერადებს ცარიელ textbox-ებს.
        private void ShowEmpty()
        {
            if (txtUsername.Text == "")
                pnlUserName.BackColor = Color.Red;
            if (txtUsername.Text != "")
                pnlUserName.BackColor = Color.Green;
            if (txtPassword.Text == "")
                pnlPassword.BackColor = Color.Red;
            if (txtPassword.Text != "")
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

        //გამოდუს აპლიკაციიდან
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        //ხურავს აპლიკაციას cansel ღილაკის დაჭერისას.
        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        // txtUsername-textbox.
        private void txtUsername_TextChanged(object sender, EventArgs e) => ShowEmpty();

        // txtPassword-textbox.
        private void txtPassword_TextChanged(object sender, EventArgs e) => ShowEmpty();
    }
}
