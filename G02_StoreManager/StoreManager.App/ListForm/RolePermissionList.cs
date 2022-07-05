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
using System.Collections;

namespace StoreManager.App.ListForm
{
    public partial class RolePermissionList : Form
    {
        private RolePermissionsService _rolePermissionsService;
        private PermissionService _permissionService;
        public RolePermissionList()
        {
            InitializeComponent();
            _rolePermissionsService = new RolePermissionsService();
            _permissionService = new PermissionService();
            GetRolePermissions(1);
        }

        public void GetRolePermissions(int id)
        {
            
            
            
            grdRolePermission.DataSource = _permissionService.GetRolePermissions(id).ToList();
        }
    }
}
