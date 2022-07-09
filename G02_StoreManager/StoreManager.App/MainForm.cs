using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.App.ListForm;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class MainForm : Form
    {
        private readonly RolePermissionsService _rolePermissionsService;

        public MainForm()
        {
            InitializeComponent();
            _rolePermissionsService = new RolePermissionsService();
            _rolePermissionsService.StartTableDependenc();
            LocalStorage.Permissions = new List<int>() { 1, 2, 3, 4, 5, 8 };
            GiveItemsToCheckTagsMethod(menuStrip1);
        }

        private void VerticaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CasadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<ProductList>();
        }

        private void UserListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<UserList>();
        }

        private void employeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<EmployeeList>();
        }

        private void contactInfoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<ContactInfoList>();
        }

        private void PermissionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<PermissionList>();
        }

        private void ColseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (MdiChildren.Length > 0)
            {
                ActiveMdiChild.Close();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).RefreshRecords();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).InsertRecord();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).UpdateRecord();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).DeleteRecord();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).SearchRecords(txtSearch.Text);
            }
        }

        private void OpenListForm<T>() where T : Form, new()
        {
            T form = new T
            {
                MdiParent = this
            };
            form.Show();
        }

        private void GiveItemsToCheckTagsMethod(MenuStrip menuStrip)
        {
            foreach (var item in menuStrip.Items)
            {
                CheckTags(item as ToolStripMenuItem);
            }
        }

        private void CheckTags(ToolStripMenuItem toolStripMenuItem)
        {
            foreach (var dropDownItem in toolStripMenuItem.DropDownItems)
            {
                if ((dropDownItem as ToolStripMenuItem) == null)
                    continue;

                if ((dropDownItem as ToolStripMenuItem).Tag != null && (dropDownItem as ToolStripMenuItem).Tag != string.Empty)
                {
                    if (!LocalStorage.Permissions.ToList<int>().Contains((Convert.ToInt32((dropDownItem as ToolStripMenuItem).Tag))))
                    {
                        (dropDownItem as ToolStripMenuItem).Visible = false;
                        continue;
                    }

                    if ((dropDownItem as ToolStripMenuItem).DropDownItems.Count > 0)
                    {
                        CheckTags((dropDownItem as ToolStripMenuItem));
                    }
                }
             }
        }

        private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is ILoadRoles)
            {
                (ActiveMdiChild as ILoadRoles).LoadRoles();
            }
        }
    }
}
