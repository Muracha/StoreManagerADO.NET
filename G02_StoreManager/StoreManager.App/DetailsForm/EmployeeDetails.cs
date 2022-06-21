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
    public partial class EmployeeDetails : Form, IDetailsForm
    {
        private DetailsHelper<Employee, EmployeeRepository, EmployeeService> _detailsHelper;
        public EmployeeDetails()
        {
            InitializeComponent();
            _detailsHelper = new DetailsHelper<Employee, EmployeeRepository, EmployeeService>(this);
        }

        public EmployeeDetails(int id)
        {
            InitializeComponent();
            _detailsHelper = new DetailsHelper<Employee, EmployeeRepository, EmployeeService>(this);
            LoadData(id);
        }

        public void LoadData(int id)
        {
            _detailsHelper.LoadData(id);
        }

        public void SaveData()
        {
            _detailsHelper.SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            txtBirthDate.Text = dtBirthDate.Value.ToString();
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            dtBirthDate.Value = Convert.ToDateTime(txtBirthDate.Text);
        }

        private void dtHireDate_ValueChanged(object sender, EventArgs e)
        {
            txtHireDate.Text = dtHireDate.Value.ToString();
        }

        private void txtHireDate_TextChanged(object sender, EventArgs e)
        {
            dtHireDate.Value = Convert.ToDateTime(txtHireDate.Text);
        }
    }
}
