using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserDetails : Form
    {
        private readonly User _user;
        private readonly UserService _userService;

        public UserDetails()
        {
            InitializeComponent();
            _user = new User();
            _userService = new UserService();
        }
        private bool CheckAllTextBox()
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

        public void SelectRowFromTable(UserList userList)
        {
            try
            {
                txtUserID.Text = userList.grdUserList.Rows[userList.TableRowIndex].Cells["ID"].Value.ToString();
                txtUserName.Text = userList.grdUserList.Rows[userList.TableRowIndex].Cells["UserName"].Value.ToString();
                txtPassword.Text = userList.grdUserList.Rows[userList.TableRowIndex].Cells["Password"].Value.ToString();
                cmbIsActive.Text = userList.grdUserList.Rows[userList.TableRowIndex].Cells["IsActive"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAllTextBox())
            {
                _user.ID = int.Parse(txtUserID.Text);
                _user.Username = txtUserName.Text;
                _user.Password = txtPassword.Text;
                _userService.Insert(_user);
                //LocalStorage.Record = _user;
                ClearAllTextBox();
            }
            else
            {
                MessageBox.Show("Fill the missed lines !!!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckAllTextBox())
            {
                _user.ID = int.Parse(txtUserID.Text);
                _user.Username = txtUserName.Text;
                _user.IsActive = bool.Parse(cmbIsActive.Text);
                _userService.Update(_user);
                MessageBox.Show("Successfully Updated!");
                this.Close();
            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CheckAllTextBox())
            {
                if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userService.Delete(txtUserID.Text);
                    MessageBox.Show("Successfully Deleted!");
                    this.Close();
                }
            }
        }
    }
}
