using StoreManager.App.Interfaces;
using StoreManager.Services;
using System;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class MainForm : Form
    {
        private readonly RolePermissionsService _rolePermissionsService;
        private readonly UserService _userService;
        public static bool _updatebuttonClick;

        public MainForm()
        {
            InitializeComponent();
            _rolePermissionsService = new RolePermissionsService();
            _userService = new UserService();
            //_rolePermissionsService.StartTableDependenc();
        }

        private void verticaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void casadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void colseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (MdiChildren.Length > 0)
            {
                ActiveMdiChild.Close();
            }
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<ProductList>();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenListForm<UserList>();
        }

        private void OpenListForm<T>() where T : Form, new()
        {
            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild is IListForm)
            {
                (ActiveMdiChild as IListForm).InsertRecord();
            }

            //DesingerFormOpenen("Details");
        }

        private void DesingerFormOpenen(string text)
        {
            if (MdiChildren.Length > 0)
            {
                string formNameText = ActiveMdiChild.Text.Substring(0, ActiveMdiChild.Text.Length - 4) + text;
                var form = Activator.CreateInstance(Type.GetType("StoreManager.App." + $"{formNameText}")) as Form;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a list!");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            _updatebuttonClick = true;
            DesingerFormOpenen("Details");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DesingerFormOpenen("List");
        }
    }
}
