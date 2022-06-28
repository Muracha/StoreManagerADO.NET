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
    public partial class ContactInfoDetails : Form, IDetailsForm<ContactInfo>
    {
        private DetailsHelper<ContactInfo, ContactInfoRepository, ContactInfoService> _detailsHelper;
        public ContactInfoDetails()
        {
            InitializeComponent();
            _detailsHelper = new DetailsHelper<ContactInfo, ContactInfoRepository, ContactInfoService>(this);
        }

        public ContactInfoDetails(int id)
        {
            InitializeComponent();
            _detailsHelper = new DetailsHelper<ContactInfo, ContactInfoRepository, ContactInfoService>(this);
            LoadData(id);
        }

        public void LoadData(int id)
        {
            _detailsHelper.LoadData(id);
        }

        public ContactInfo SaveData()
        {
            _detailsHelper.SaveData();
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
