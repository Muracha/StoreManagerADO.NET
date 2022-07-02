using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class UserDetails : Form, IDetailsForm<User>
    {
        private readonly UserService _userService;
        private User _user;
        public UserDetails()
        {
            InitializeComponent();
            _user = new User();
            _userService = new UserService();
        }

        public void LoadData(int id)
        {
            LoadUserModel(id);
        }

        public User SaveData()
        {
            var _save = SaveUserModel();
            if (_save != null)
            {
                DialogResult = DialogResult.OK;
                return _save;
            }

            DialogResult = DialogResult.Cancel;
            return null;
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

        private void LoadUserModel(int id)
        {
            _user = _userService.Get(id);
            txtIDValue.Enabled = false;
            txtPasswordValue.Enabled = false;
            txtIDValue.Text = _user.ID.ToString();
            txtUserNameValue.Text = _user.Username.ToString();
            txtPasswordValue.Text = _user.Password.ToString();
            cmbIsActiveValue.SelectedItem = _user.IsActive.ToString();
        }

        private User SaveUserModel()
        {
            if (!ValidateData())
            {
                return null;
            }

            _user.ID = int.Parse(txtIDValue.Text);
            _user.Username = txtUserNameValue.Text;
            _user.Password = txtPasswordValue.Text;
            _user.IsActive = Convert.ToBoolean(cmbIsActiveValue.SelectedItem);
            return _user;
        }

        private bool ValidateData()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Text == string.Empty || control.Text == null)
                {
                    MessageBox.Show("Fill the missed lines, next time.");
                    return false;
                }
            }

            return true;
        }
    }
}
