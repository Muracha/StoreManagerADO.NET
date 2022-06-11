using StoreManager.Models;
using StoreManager.Services;
using System;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserDetails : Form
    {
        private User _user;
        private UserService _userService;

        public UserDetails()
        {
            InitializeComponent();
            _user = new User();
            _userService = new UserService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ChechTextBox())
            {
                _user.ID = int.Parse(txtUserID.Text);
                _user.Username = txtUserName.Text;
                _user.Password = txtPassword.Text;
                _userService.Insert(_user);
                MessageBox.Show("Successfully Added!");
                ClearAllTextBox();
            }
            else
            {
                MessageBox.Show("Fill the missed lines !!!");
            }
        }

        private bool ChechTextBox()
        {
            if (txtUserID.Text == string.Empty || txtUserName.Text == string.Empty || txtPassword.Text == string.Empty)
                return false;
            return true;
        }

        private void ClearAllTextBox()
        {
            txtUserID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ChechTextBox())
            {
                _user.ID = int.Parse(txtUserID.Text);
                _user.Username = txtUserName.Text;
                _user.IsActive = bool.Parse(cmbIsActive.Text);
                _userService.Update(_user);
                MessageBox.Show("Successfully Updated!");
                this.Close();
            }

        }

        private void SelectRowToTextBox()
        {
            var index = UserList.RowIndex;
            txtUserID.Text = UserList.grdtable.Rows[index].Cells[1].Value.ToString();
            txtUserName.Text = UserList.grdtable.Rows[index].Cells[2].Value.ToString();
            txtPassword.Text = UserList.grdtable.Rows[index].Cells[3].Value.ToString();
            cmbIsActive.Text = UserList.grdtable.Rows[index].Cells[5].Value.ToString();

        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            if (MainForm._updatebuttonClick == true)
            {   
                txtUserID.Enabled= false;
                txtPassword.Enabled = false;
                btnAdd.Enabled = false; 
                SelectRowToTextBox();
                MainForm._updatebuttonClick = false;
            }
            else
            {
                cmbIsActive.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
    }
}
