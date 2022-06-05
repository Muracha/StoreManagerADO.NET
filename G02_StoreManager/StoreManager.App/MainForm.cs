using System;
using StoreManager.Services;
using StoreManager.Models;
using System.Windows.Forms;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace StoreManager.App
{
    public partial class MainForm : Form
    {
        private readonly RolePermissionsService _rolePermissionsService;

        public MainForm()
        {
            InitializeComponent();
            _rolePermissionsService = new RolePermissionsService();
            _rolePermissionsService.StartDableDependenc();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
