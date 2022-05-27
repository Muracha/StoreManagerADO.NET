using System;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenLoadHome();
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            OpenLoadHome();
        }

        private void OpenLoadHome()
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

    }
}
