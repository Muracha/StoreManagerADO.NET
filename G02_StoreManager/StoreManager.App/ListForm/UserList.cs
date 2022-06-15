
using StoreManager.App.DetailsForm;
using StoreManager.App.Interfaces;
using StoreManager.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm
    {
        public int TableRowIndex { get; private set; }
        private readonly UserRepository _userRepository;
        private UserDetails2 _userDetails;

        public UserList()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _userDetails = new UserDetails2();
        }
        private void UserList_Load(object sender, EventArgs e)
        {
            ShowUsersData();
        }

        public void ShowUsersData()
        {
            try
            {
                grdUserList.DataSource = _userRepository.Select().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GrdUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TableRowIndex = e.RowIndex;
        }

        public void InsertRecord()
        {
            _userDetails = new UserDetails2();
            if (_userDetails.ShowDialog() == DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void UpdateRecord()
        {
            _userDetails = new UserDetails2();
            _userDetails = new UserDetails2(int.Parse(grdUserList.Rows[TableRowIndex].Cells["ID"].Value.ToString()));
            if (_userDetails.ShowDialog() == DialogResult.OK)
            {
                ShowUsersData();
            }
        }

        public void DeleteRecord()
        {
            _userDetails = new UserDetails2();
            if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _userRepository.Delete(grdUserList.Rows[TableRowIndex].Cells["ID"].Value.ToString());
                DialogResult = DialogResult.OK;
                RefreshRecords();
                this.Close();
            }  
        }

        public void SearchRecords(string text)
        {
            foreach (DataGridViewRow row in grdUserList.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(text) && text != string.Empty)
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        public void RefreshRecords()
        {
            ShowUsersData();
        }

    }
}
