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


namespace StoreManager.App
{
    public partial class ProductDetails : Form, IDetailsForm<Product>
    {
        public ProductDetails()
        {
            InitializeComponent();
        }
        
        public void LoadData(int id)
        {
           
        }

        public Product SaveData()
        {
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
