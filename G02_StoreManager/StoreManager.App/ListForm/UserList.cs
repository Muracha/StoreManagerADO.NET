
using StoreManager.App.DetailsForm;
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
        private  UserDetails2 _userDetails;

        public UserList()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _userDetails = new UserDetails2();
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
            if (_userDetails.ShowDialog() == DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void UpdateRecord()
        {
            _userDetails = new UserDetails2(int.Parse(grdUserList.Rows[TableRowIndex].Cells["ID"].Value.ToString()));
            if (_userDetails.ShowDialog() == DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void DeleteRecord()
        {
            if (_userDetails.ShowDialog() == DialogResult.OK)
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
