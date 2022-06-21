﻿using System;
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
    public partial class ContactInfoDetails : Form, IDetailsForm
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

        public void SaveData()
        {
            _detailsHelper.SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void cbIsPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIsPrimary.Text = cbIsPrimary.SelectedItem.ToString();
        }

        private void txtPrimary_TextChanged(object sender, EventArgs e)
        {
            cbIsPrimary.Text = txtIsPrimary.Text;
        }
    }
}