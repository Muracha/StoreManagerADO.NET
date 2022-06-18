using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class UserDetails : Form
    {
        private readonly UserService _userService;

        public UserDetails(UserService service)
        {
            InitializeComponent();
            _userService = service;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            if (MainForm.updateButtonClick)
            {
                LoadData();
                MainForm.updateButtonClick = false;
            }
        }

        /// <summary>
        /// კითხულობს მონაცემთა ბაზიდან ჩანაწერს და ასახავს ვიზუალურ კომპონენტებში.
        /// </summary>
        private void LoadData()
        {
            var _user = new User();
            _user = _userService.Get(UserList.clickedUserID);
            txtUserID.Text = _user.ID.ToString();
            txtPassword.Text = _user.Password;
            txtUserName.Text = _user.Username;
            cmbIsActive.Text = _user.IsActive.ToString();
        }

        /// <summary>
        /// ქმნის ობიექტს ვიზუალურ კომპონენტებში შეყვანილი ინფორმაციის საფუძველზე
        /// და წერს მონაცემთა ბაზაში.
        /// </summary>
        private void SaveData()
        {
            if (ValidateData())
            {
                var _user = new User();
                _user.ID = int.Parse(txtUserID.Text);
                _user.Username = txtUserName.Text;
                _user.Password = txtPassword.Text;
                _user.IsActive = Convert.ToBoolean(cmbIsActive.Text);
                LocalStorage.Record = _user;
                DialogResult = DialogResult.OK;
            }
        }


        /// <summary>
        /// ამოწმებს შეყვანილ ინფორმაციას მართებულობაზე.
        /// </summary>
        private bool ValidateData()
        {
            if (CheckAllTextBox())
            {
                return true;
            }

            return false;
        }

        private bool CheckAllTextBox()
        {
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {
                if (txtBox.Text == string.Empty)
                {
                    MessageBox.Show("Fill the missed lines.");
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
