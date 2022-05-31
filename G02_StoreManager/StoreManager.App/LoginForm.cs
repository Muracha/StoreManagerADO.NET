using System;
using System.Collections.Generic;
using StoreManager.Services;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private readonly RolePermissionsService _rolePermissionsService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _rolePermissionsService = new RolePermissionsService();
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

            if ((LocalStorage.LoggedUserID = _userService.Login(txtUsername.Text, txtPassword.Text)) > 0)
            {
                //LocalStorage.Permissions= _rolePermissionsService.SelectRolePermisios(LocalStorage.LoggedUserID);
                DialogResult = DialogResult.OK;
            }
            else if (Properties.Settings.Default.Attempts >= 1)
            {
                TryAgain();
                MessageBox.Show($"Login Failed : \n{Properties.Settings.Default.Attempts--} attempts left.");
            }
            else
            {
                Properties.Settings.Default.FailedLoginDateTime = DateTime.Now.AddMinutes(1);
                MessageBox.Show("You have failed too many time.");
                DialogResult = DialogResult.Cancel;
            }
        }

        //აფერადებს ცარიელ textbox-ებს.
        private void ShowEmpty()
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
        private void BtnCancel_Click(object sender, EventArgs e) => Application.Exit();

        // txtUsername-textbox.
        private void TxtUsername_TextChanged(object sender, EventArgs e) => ShowEmpty();

        // txtPassword-textbox.
        private void TxtPassword_TextChanged(object sender, EventArgs e) => ShowEmpty();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FailedLoginDateTime > DateTime.Now)
            {
                MessageBox.Show("You have been blocked out of System.");
                DialogResult = DialogResult.Cancel;
            }
            if (Properties.Settings.Default.LastAttemptToLogin.AddMinutes(.3) < DateTime.Now)
            {
                Properties.Settings.Default.Attempts = 2;
            }
            Properties.Settings.Default.LastAttemptToLogin = DateTime.Now;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
