using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(_userService.Login(txtUsername.Text, txtPassword.Text))
            {
                int id = _userService.GetUserID(txtUsername.Text);
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
    }
}
