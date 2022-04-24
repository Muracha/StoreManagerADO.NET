using StoreManager.Models;
using StoreManager.Repositories;
using System;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            User user = new User();
            userRepository.Insert(user);
        }
    }
}
