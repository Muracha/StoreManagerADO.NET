using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.App.DetailsForm.DetailsHelper;
using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;


namespace StoreManager.App
{
    public partial class ProductDetails : Form, IDetailsForm<Product>
    {
        private DetailsHelper<Product, ProductRepository, ProductService> detailsHelper;
        public ProductDetails()
        {
            InitializeComponent();
            detailsHelper = new DetailsHelper<Product, ProductRepository, ProductService>(this);
        }

        public ProductDetails(int id)
        {
            InitializeComponent();
            detailsHelper = new DetailsHelper<Product, ProductRepository, ProductService>(this);
            LoadData(id);
        }
        
        public void LoadData(int id)
        {
            detailsHelper.LoadData(id);
        }

        public Product SaveData()
        {
            detailsHelper.SaveData();
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
