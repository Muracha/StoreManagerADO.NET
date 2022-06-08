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
            _rolePermissionsService.StartTableDependenc();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

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
            ProductList productList = new ProductList();
            productList.MdiParent = this;
            productList.Show();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.MdiParent = this;
            userList.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                DesingerFormOpenen();
                
        }

        private void DesingerFormOpenen()
        {
            string text = ActiveMdiChild.Text.Substring(0, ActiveMdiChild.Text.Length - 4);
            var form = Activator.CreateInstance(Type.GetType("StoreManager.App." + $"{text}Details")) as Form;
            form.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                DesingerFormOpenen();
        }
    }
}
