
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm.ListBase;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm
    {
        public int TableRowIndex { get; private set; }
        private readonly UserRepository _userRepository;
        private readonly ListBase<UserDetails, User, UserService, UserRepository> listBase;
        private readonly UserDetails _userDetails;

        public UserList()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _userDetails = new UserDetails();
            listBase = new ListBase<UserDetails, User, UserService, UserRepository>();
        }
        private void UserList_Load(object sender, EventArgs e)
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

        private void GrdUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TableRowIndex = e.RowIndex;
        }

        public void InsertRecord()
        {
            var userDetails = new UserDetails();
            userDetails.btnUpdate.Enabled = false;
            if (userDetails.ShowDialog() != DialogResult.OK)
            {
                ShowUsersData();
            }
            //listBase.InsertRecord();
        }

        public void UpdateRecord()
        {
            _userDetails.btnAdd.Enabled = false;
            _userDetails.btnDelete.Enabled = false;
            _userDetails.txtUserID.Enabled = false;
            _userDetails.txtPassword.Enabled = false;
            _userDetails.SelectRowFromTable(this);
            if (_userDetails.ShowDialog() != DialogResult.OK)
            {
                ShowUsersData();
            }
            //listBase.UpdateRecord();
        }

        public void DeleteRecord()
        {
            _userDetails.btnAdd.Enabled = false;
            _userDetails.btnUpdate.Enabled = false;
            _userDetails.txtUserID.Enabled = false;
            _userDetails.txtUserName.Enabled = false;
            _userDetails.txtPassword.Enabled = false;
            _userDetails.cmbIsActive.Enabled = false;
            _userDetails.SelectRowFromTable(this);
            if (_userDetails.ShowDialog() != DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void SearchRecords()
        {
            throw new NotImplementedException();
        }

        public void RefreshRecords()
        {
            ShowUsersData();
        }
    }
}
