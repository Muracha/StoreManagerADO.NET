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

namespace StoreManager.App.DetailsForm
{
    public partial class ContactInfoDetails : Form, IDetailsForm<ContactInfo>
    {
        public ContactInfoDetails()
        {
            InitializeComponent();
            
        }

        public void LoadData(int id)
        {
            
        }

        public ContactInfo SaveData()
        {
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
