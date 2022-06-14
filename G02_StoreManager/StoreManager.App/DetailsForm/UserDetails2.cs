using StoreManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager.App.DetailsForm
{
    public partial class UserDetails2 : Form
    {
        private int _id;
        private UserService _userService;

        public bool EditMode => _id != 0;

        public UserDetails2(int id = 0)
        {
            InitializeComponent();

            _id = id;
            _userService = new UserService();

            if (EditMode)
            {
                LoadData();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// კითხულობს მონაცემთა ბაზიდან ჩანაწერს და ასახავს ვიზუალურ კომპონენტებში.
        /// </summary>
        private void LoadData()
        {

        }

        /// <summary>
        /// ქმნის ობიექტს ვიზუალურ კომპონენტებში შეყვანილი ინფორმაციის საფუძველზე
        /// და წერს მონაცემთა ბაზაში.
        /// </summary>
        private void SaveData()
        {
            ValidateData();

            if (!EditMode)
            {
                _userService.Insert(null);
            }
            else
            {
                _userService.Update(null);
            }
        }

        /// <summary>
        /// ამოწმებს შეყვანილ ინფორმაციას მართებულობაზე.
        /// </summary>
        private void ValidateData()
        {

        }
    }
}
