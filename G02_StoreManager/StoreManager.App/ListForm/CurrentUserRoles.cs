using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm.ListHelper;
using StoreManager.App.DetailsForm;

namespace StoreManager.App.ListForm
{
    public partial class CurrentUserRoles : Form
    {
        private readonly ListHelper<RoleDetails, Role, RoleRepository, RoleService> _listHelper;
        private int _userID;
        public CurrentUserRoles()
        {
            InitializeComponent();
            _listHelper = new ListHelper<RoleDetails, Role, RoleRepository, RoleService>(grdCurrentUserRoles);
        }

        public void Initialize(int id)
        {
            _userID = id;
            RefreshRecords();
        }

        public void RefreshRecords()
        {
            grdCurrentUserRoles.DataSource = _listHelper._service.SelectUserRoles(_userID).ToList();
        }

        private void deleteRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _listHelper._service.UnassignUserToRole(_userID, _listHelper.ClickedModelID);
            }
            RefreshRecords();
        }

        private void addNewRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleList roleList = new RoleList();
            roleList.LoadRoles(_userID);
            roleList.ShowDialog();
            RefreshRecords();
        }

        private void grdCurrentUserRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _listHelper.ClickedModelID = e.RowIndex;
        }
    }
}
