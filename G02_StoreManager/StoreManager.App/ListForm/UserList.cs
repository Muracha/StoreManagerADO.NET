using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.Repositories;

namespace StoreManager.App
{
    public partial class UserList : Form, IListForm
    {
        private readonly UserRepository _userRepository;
        public static DataGridView grdtable { get; set; }
        public static  int RowIndex { get; set; }

        public UserList()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void UserList_Load(object sender, System.EventArgs e)
        {
            //ShowUsersData();
        }

        public void ShowUsersData()
        {
            try
            {
                grdUserList.DataSource = _userRepository.Select().ToList();
                grdtable = grdUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            if (e.ColumnIndex==0)
            {
                if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm Detetion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userRepository.Delete(grdtable.Rows[RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show("Successfully deleted!");
                }
            }

        }

        public void InsertRecord()
        {
            UserDetails userDetails = new UserDetails();
            if (userDetails.ShowDialog() != DialogResult.OK)
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

        public void SearchRecords()
        {
            throw new NotImplementedException();
        }
    }
}
