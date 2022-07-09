using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm.ListHelper;
using StoreManager.Models;
using StoreManager.Services;
using StoreManager.Repositories;
using StoreManager.App.DetailsForm;

namespace StoreManager.App.ListForm
{
    public partial class RoleList : Form, IListForm
    {
        private readonly ListHelper<RoleDetails, Role, RoleRepository, RoleService> _listHelper;
        private List<Role> _roleIDList;

        private int _userID;
        public RoleList()
        {
            InitializeComponent();
            _listHelper = new ListHelper<RoleDetails, Role, RoleRepository, RoleService>(grdRoleList);
            _roleIDList = new List<Role>();
            RefreshRecords();
        }

        public void InsertRecord() => _listHelper.InsertRecord();
        public void UpdateRecord() => _listHelper.UpdateRecord();
        public void DeleteRecord() => _listHelper.DeleteRecord();
        public void RefreshRecords() => _listHelper.RefreshRecords();
        public void SearchRecords(string text) => _listHelper.SearchRecords(text);
        private void grdRoleList_CellClick(object sender, DataGridViewCellEventArgs e) => _listHelper.ClickedModelID = e.RowIndex;

        private void grdRoleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (_listHelper.ValidateSelection())
                {
                    PermissionList permissionList = new PermissionList();
                    permissionList.LoadPermissions(_listHelper.ClickedModelID);
                    permissionList.ShowDialog();
                }
            }

            if ((sender as DataGridView).Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                ManipulateRoleID();
            }
        }


        private void ManipulateRoleID()
        {
            bool isChecked = Convert.ToBoolean((grdRoleList.CurrentCell as DataGridViewCheckBoxCell).EditedFormattedValue);

            foreach (var item in _roleIDList)
            {
                if (item.ID == _listHelper.ClickedModelID)
                {
                    _roleIDList.Remove(item);
                    return;
                }
            }

            _roleIDList.Add(new Role { ID = _listHelper.ClickedModelID});
        }

        public void LoadRoles(int id = 0)
        {
            _userID = id;
            Select.Visible = true;
            menuStrip.Visible = true;
        }

        private void addRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_roleIDList.Count == 0)
            {
                MessageBox.Show("Please select Roles.");
                return;
            }

            foreach (var item in _roleIDList)
            {
                try
                {
                    _listHelper._service.AssignUserToRole(_userID, item.ID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            MessageBox.Show("Succesfully Added.");
            DialogResult = DialogResult.OK;
        }
    }
}
