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
using StoreManager.App.ListForm.ListHelper;
using StoreManager.App.DetailsForm;

namespace StoreManager.App.ListForm
{
    public partial class ContactInfoList : Form, IListForm
    {
        private ListHelper<ContactInfoDetails, ContactInfo, ContactInfoRepository, ContactInfoService> _listHelper;
        public ContactInfoList()
        {
            InitializeComponent();
            _listHelper = new ListHelper<ContactInfoDetails, ContactInfo, ContactInfoRepository, ContactInfoService>(grdContactInfo);
            RefreshRecords();
        }

        public void InsertRecord()
        {
            _listHelper.InsertRecord();
        }

        public void UpdateRecord()
        {
            _listHelper.UpdateRecord();
        }

        public void DeleteRecord()
        {
            _listHelper.DeleteRecord();
        }

        public void RefreshRecords()
        {
            _listHelper.RefreshRecords();
        }

        public void SearchRecords(string text)
        {
            _listHelper.SearchRecords(text);
        }

        private void grdContactInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _listHelper.ClickedModelID = e.RowIndex;
        }
    }
}
