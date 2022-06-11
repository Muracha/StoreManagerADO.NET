using StoreManager.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App
{
    public partial class UserList : Form
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
            ShowUsersData();
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

    }
}
