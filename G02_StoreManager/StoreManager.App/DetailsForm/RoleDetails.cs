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

namespace StoreManager.App.DetailsForm
{
    public partial class RoleDetails : Form, IDetailsForm<Role>
    {
        public RoleDetails()
        {
            InitializeComponent();
        }

        public void LoadData(int id)
        {
            throw new NotImplementedException();
        }

        public Role SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
