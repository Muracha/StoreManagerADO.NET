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

namespace StoreManager.App.DetailsForm
{
    public partial class EmployeeDetails : Form, IDetailsForm<Employee>
    {
        public EmployeeDetails()
        {
            InitializeComponent();
            
        }

        public void LoadData(int id)
        {
            
        }

        public Employee SaveData()
        {
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
