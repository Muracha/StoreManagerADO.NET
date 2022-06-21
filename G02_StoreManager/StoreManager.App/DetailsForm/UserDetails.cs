using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.DetailsForm.DetailsHelper;
using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class UserDetails : Form, IDetailsForm
    {
        private DetailsHelper<User, UserRepository, UserService> _detailsHelper;
        public UserDetails()
        {
            InitializeComponent();
            _detailsHelper = new DetailsHelper<User, UserRepository, UserService>(this);
        }

        public UserDetails(int id)
        {
            InitializeComponent();
            _detailsHelper = new DetailsHelper<User, UserRepository, UserService>(this);
            LoadData(id);
        }

        public void LoadData(int id)
        {
            _detailsHelper.LoadData(id);
        }

        public void SaveData()
        {
            _detailsHelper.SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIsActive.Text = cmbIsActive.SelectedItem.ToString();
        }

        private void txtIsActive_TextChanged(object sender, EventArgs e)
        {
            cmbIsActive.Text = txtIsActive.Text;
        }
    }
}
