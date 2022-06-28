using System;
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
            //_rolePermissionsService.StartTableDependenc();
            LocalStorage.Permissions.ToList().Add(1);
            LocalStorage.Permissions.ToList().Add(3);
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

        private void ColseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (MdiChildren.Length > 0)
            {
                ActiveMdiChild.Close();
            }
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

        private void OpenListForm<T>() where T : Form, new()
        {
            T form = new T
            {
                MdiParent = this
            };
            form.Show();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).InsertRecord();
            }
        }
    
        private void Update_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).UpdateRecord();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).DeleteRecord();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).RefreshRecords();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).SearchRecords(txtSearch.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).SearchRecords(txtSearch.Text);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).InsertRecord();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is ToolStripMenuItem)
            {
                CheckTags(e.ClickedItem as ToolStripMenuItem);
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
                    if ((dropDownItem as ToolStripMenuItem).DropDownItems != null)
                    {
                        CheckTags((dropDownItem as ToolStripMenuItem));
                    }
                    if (!LocalStorage.Permissions.ToList<int>().Contains((Convert.ToInt32((dropDownItem as ToolStripMenuItem).Tag))))
                    {
                        (dropDownItem as ToolStripMenuItem).Visible = false;
                    }
                }
             }
        }
    }
}
