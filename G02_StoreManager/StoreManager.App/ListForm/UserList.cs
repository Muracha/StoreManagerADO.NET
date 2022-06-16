
using StoreManager.App.DetailsForm;
using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm
    {
        public int TableRowIndex { get; private set; }
        private readonly UserRepository _userRepository;
        private UserDetails2 _userDetails;
        private List<User> _userLits;

        public UserList()
        {
            InitializeComponent();
            _userLits = new List<User>();
            _userRepository = new UserRepository();
            _userDetails = new UserDetails2();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            ShowUsersData();
        }

        private  void ShowUsersData()
        {
            try
            {
                _userLits = _userRepository.Select().ToList();
                grdUserList.DataSource = _userLits;
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
            _userDetails = new UserDetails2();
            if (_userDetails.ShowDialog() == DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void UpdateRecord()
        {
            _userDetails = new UserDetails2(int.Parse(grdUserList.Rows[TableRowIndex].Cells["ID"].Value.ToString()));// dasaxvewia!!!
            if (_userDetails.ShowDialog() == DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void DeleteRecord()
        {
            if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _userRepository.Delete(grdUserList.Rows[TableRowIndex].Cells["ID"].Value.ToString());
                DialogResult = DialogResult.OK;
                RefreshRecords();
                this.Close();
            }
        }

        public void SearchRecords(string text)
        {
            grdUserList.DataSource = _userLits.Where(x => x.Username.Contains(text) || x.ID.ToString().Contains(text)).ToList();
        }

        public void RefreshRecords()
        {
            ShowUsersData();
        }

    }
}
