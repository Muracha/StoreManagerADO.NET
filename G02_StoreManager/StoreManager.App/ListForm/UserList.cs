using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm
    {
        private readonly UserService _service;
        public static int clickedUserID;

        public UserList()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        private void GrdUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedUserID = Convert.ToInt32(grdUserList.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void RefreshUserData()
        {
            try
            {
                grdUserList.DataSource = _service.Select().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertRecord()
        {
            var details = new UserDetails(_service);
            if (details.ShowDialog() == DialogResult.OK)
            {
                _service.Insert(LocalStorage.Record as User);
                RefreshUserData();
            }
        }

        public void UpdateRecord()
        {
            if (CheckClick())
            {
                var details = new UserDetails(_service);
                if (details.ShowDialog() == DialogResult.OK)
                {
                    _service.Update(LocalStorage.Record as User);
                    RefreshUserData();
                }
            }
        }

        public void DeleteRecord()
        {
            if (CheckClick())
            {
                if (MessageBox.Show($"Are you sure you want to delete this User with {clickedUserID} ID?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _service.Delete(clickedUserID);
                    RefreshUserData();
                }
            }
        }

        public void SearchRecords(string searchValue)
        {
            
        }

        public void RefreshRecords()
        {
            RefreshUserData();
        }

        private bool CheckClick()
        {
            if (clickedUserID > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Select Line");
                return false;
            }
        }
    }
}
