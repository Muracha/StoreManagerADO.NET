using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserDetails : Form, IListForm
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
            if (CheckTextBox())
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

        private bool CheckTextBox()
        {
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {
                if (txtBox.Text == string.Empty)
                    return false;
                else
                    return true;
            }
            return false;
        }

        private void ClearAllTextBox()
        {
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Text = string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
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
            //var index = UserList.RowIndex;
            //txtUserID.Text = UserList.grdtable.Rows[index].Cells[1].Value.ToString();
            //txtUserName.Text = UserList.grdtable.Rows[index].Cells[2].Value.ToString();
            //txtPassword.Text = UserList.grdtable.Rows[index].Cells[3].Value.ToString();
            //cmbIsActive.Text = UserList.grdtable.Rows[index].Cells[5].Value.ToString();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                _userService.Delete(txtUserID.Text);
                MessageBox.Show("Successfully Deleted!");
                this.Close();
            }
        }

        public void InsertRecord()
        {
            throw new NotImplementedException();
        }

        public void UpdateRecord()
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public void SearchRecords()
        {
            throw new NotImplementedException();
        }
    }
}
