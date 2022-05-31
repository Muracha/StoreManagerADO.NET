using StoreManager.Services;
using System;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class MainForm : Form
    {
        private  RolePermissionsService _rolePermissionsService;

        public MainForm()
        {
            InitializeComponent();
            _rolePermissionsService = new RolePermissionsService();
        }

        private void BtnSubUser_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMenuUser);
        }

        private void BtnMainEmployees_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMenuEmployees);
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMenuProduct);
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMenuCategories);
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            OpenFormToMainPanel(new Home());
            RefreshRolePermissions();
        }

        private void RefreshRolePermissions()
        {
            StartTableDependency();
        }

        private void SelectPermission()
        {
            LocalStorage.Permissions = _rolePermissionsService.SelectRolePermissios(LocalStorage.LoggedUserID);
        }

        private void StartTableDependency()
        {
            if (!RolePermissionsService._dependencyStatusIs)
                SelectPermission();
            else
                RefreshRolePermissions();
        }

        private void OpenFormToMainPanel(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMainForm.Controls.Add(childForm);
            pnlMainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
                subMenu.Visible = true;
            else
                subMenu.Visible = false;
        }

    }
}
