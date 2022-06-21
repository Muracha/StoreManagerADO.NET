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
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;
using StoreManager.App.DetailsForm.DetailsHelper;

namespace StoreManager.App.DetailsForm
{
    public partial class PermissionDetails : Form, IDetailsForm
    {
        private DetailsHelper<Permission, PermissionRepository, PermissionService> detailsHelper;
        public PermissionDetails()
        {
            InitializeComponent();
            detailsHelper = new DetailsHelper<Permission, PermissionRepository, PermissionService>(this);
        }

        public PermissionDetails(int id)
        {
            InitializeComponent();
            detailsHelper = new DetailsHelper<Permission, PermissionRepository, PermissionService>(this);
            LoadData(id);
        }

        public void LoadData(int id)
        {
            detailsHelper.LoadData(id);
        }

        public void SaveData()
        {
            detailsHelper.SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
