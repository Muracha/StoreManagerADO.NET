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
using StoreManager.App.ListForm.ListHelper;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App
{
    public partial class ProductList : Form, IListForm
    {
        private readonly ListHelper<ProductDetails, Product, ProductRepository, ProductService> _listHelper;
        public ProductList()
        {
            InitializeComponent();
            _listHelper = new ListHelper<ProductDetails, Product, ProductRepository, ProductService>(grdProductList);
            RefreshRecords();
        }

        public void InsertRecord() => _listHelper.InsertRecord();
        public void UpdateRecord() => _listHelper.UpdateRecord();
        public void DeleteRecord() => _listHelper.DeleteRecord();
        public void RefreshRecords() => _listHelper.RefreshRecords();
        public void SearchRecords(string text) => _listHelper.SearchRecords(text);
        private void grdProductList_CellClick(object sender, DataGridViewCellEventArgs e) =>_listHelper.ClickedModelID = e.RowIndex;
    }
}
