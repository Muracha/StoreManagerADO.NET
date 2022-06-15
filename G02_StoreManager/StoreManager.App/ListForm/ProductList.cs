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

namespace StoreManager.App
{
    public partial class ProductList : Form, IListForm
    {
        public ProductList()
        {
            InitializeComponent();
        }

        public void InsertRecord()
        {
            ProductDetails productDetails = new ProductDetails();
            if (productDetails.ShowDialog() != DialogResult.OK)
            {

            }
        }

        public void UpdateRecord()
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public void RefreshRecords()
        {
            throw new NotImplementedException();
        }

        public void SearchRecords(string text)
        {
            throw new NotImplementedException();
        }
    }
}
