using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm;
using StoreManager.App.ListForm.ListHelper;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm, IRoles
    {
        public ListHelper<UserDetails, User, UserRepository, UserService> _listHelper;
        public UserList()
        {
            InitializeComponent();
            _listHelper = new ListHelper<UserDetails, User, UserRepository, UserService>(grdUserList);
            RefreshRecords();
        }

        public void InsertRecord() => _listHelper.InsertRecord();
        public void UpdateRecord() => _listHelper.UpdateRecord();
        public void DeleteRecord() => _listHelper.DeleteRecord();
        public void RefreshRecords() => _listHelper.RefreshRecords();
        public void SearchRecords(string text) => _listHelper.SearchRecords(text);
        private void GrdUserList_CellClick(object sender, DataGridViewCellEventArgs e) => _listHelper.ClickedModelID = e.RowIndex;

        public void LoadRoles(int id = 0)
        {
            if (_listHelper.ValidateSelection())
            {
                RoleList roles = new RoleList();
                roles.LoadRoles(_listHelper.ClickedModelID);
                roles.ShowDialog();
            }
        }
    }
}
