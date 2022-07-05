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
    public partial class RoleList : Form, IListForm, IRoles
    {
        private readonly ListHelper<RoleDetails, Role, RoleRepository, RoleService> _listHelper;
        private List<RoleID> _roleID;
        private int _userID;
        public RoleList()
        {
            InitializeComponent();
            _listHelper = new ListHelper<RoleDetails, Role, RoleRepository, RoleService>(grdRoleList);
            _roleID = new List<RoleID>();
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

        private void RoleList_FormClosing(object sender, FormClosingEventArgs e)
        {
            InsertRoleID();
        }

        private void ManipulateRoleID()
        {
            bool isChecked = Convert.ToBoolean((grdRoleList.CurrentCell as DataGridViewCheckBoxCell).EditedFormattedValue);

            foreach (var item in _roleID)
            {
                if (item.ID == _listHelper.ClickedModelID)
                {
                    item.Check = isChecked;
                    return;
                }
            }

            _roleID.Add(new RoleID { ID = _listHelper.ClickedModelID, Check = isChecked });
        }

        private void InsertRoleID()
        {
            foreach (var item in _roleID)
            {
                if (item.Check)
                    _listHelper._service.AssignUserToRole(_userID, item.ID);
                else
                    _listHelper._service.UnassignUserToRole(_userID, item.ID);
            }
        }

        public void LoadRoles(int id = 0)
        {
            _userID = id;
            Select.Visible = true;
        }

        private class RoleID
        {
            public int ID { get; set; }
            public bool Check { get; set; }
        }
    }
}
