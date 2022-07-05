using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.App.DetailsForm;
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm.ListHelper;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;


namespace StoreManager.App.ListForm
{
    public partial class PermissionList : Form, IListForm, IPermission
    {
        private ListHelper<PermissionDetails, Permission, PermissionRepository, PermissionService> _listHelper;
        public PermissionList()
        {
            InitializeComponent();
            _listHelper = new ListHelper<PermissionDetails, Permission, PermissionRepository, PermissionService>(grdPermission);
            RefreshRecords();
        }

        public void InsertRecord() => _listHelper.InsertRecord();
        public void UpdateRecord() => _listHelper.UpdateRecord();
        public void DeleteRecord() => _listHelper.DeleteRecord();
        public void RefreshRecords() => _listHelper.RefreshRecords();
        public void SearchRecords(string text) => _listHelper.SearchRecords(text);
        private void grdPermission_CellClick(object sender, DataGridViewCellEventArgs e) => _listHelper.ClickedModelID = e.RowIndex;

        public void LoadPermissions(int id = 0)
        {
            grdPermission.DataSource = _listHelper._service.GetRolePermissions(id).ToList();
        }
    }
}
