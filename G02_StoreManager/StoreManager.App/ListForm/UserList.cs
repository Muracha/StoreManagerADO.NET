
using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm.ListBase;
using StoreManager.Repositories;
using StoreManager.Models;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm
    {
        private readonly UserRepository _userRepository;
        public static int RowIndex { get; set; }
        ListBase<UserDetails, User, UserService, UserRepository, DataGridView> listBase;

        public UserList()
        {
            InitializeComponent();
            listBase = new ListBase<UserDetails, User, UserService, UserRepository, DataGridView>();
            _userRepository = new UserRepository();
        }
        private void UserList_Load(object sender, System.EventArgs e)
        {
            ShowUsersData();
        }

        public void ShowUsersData()
        {
            try
            {
                grdUserList.DataSource = _userRepository.Select().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            //if (e.ColumnIndex==0)
            //{
            //    if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm Detetion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        _userRepository.Delete(grdtable.Rows[RowIndex].Cells[1].Value.ToString());
            //        MessageBox.Show("Successfully deleted!");
            //    }
            //}
        }

        public void InsertRecord()
        {
            var userDetails = new UserDetails();
            userDetails.btnUpdate.Enabled = false;
            if (userDetails.ShowDialog() != DialogResult.OK)
            {
            }
        }

        public void UpdateRecord()
        {
            var userDetails = new UserDetails();
            userDetails.btnAdd.Enabled = false;
            userDetails.txtUserID.Enabled = false;
            userDetails.txtPassword.Enabled = false;
            if (userDetails.ShowDialog() != DialogResult.OK)
            {
                userDetails.Close();
            }
        }

        public void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public void SearchRecords()
        {
            throw new NotImplementedException();
        }

        private void grdUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshRecords()
        {
            listBase.RefreshRecords();
        }
    }
}
