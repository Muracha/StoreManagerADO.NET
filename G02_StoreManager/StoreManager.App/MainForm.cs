using StoreManager.App.Interfaces;
using StoreManager.App.ListForm;
using StoreManager.Services;
using System;
using System.Windows.Forms;

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
            OpenListForm<UserListTest>();
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
    }
}
