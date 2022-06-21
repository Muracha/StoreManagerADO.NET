using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App.ListForm.ListHelper
{
    public class ListHelper<TDetails, TModel, TRepository, TService>
        where TDetails : Form, new()
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        private int _id = 0;

        private readonly TService _service;
        private readonly DataGridView _dataGridView;

        public int ClickedModelID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > -1)
                {
                    _id = Convert.ToInt32(_dataGridView.Rows[value].Cells["ID"].Value);
                }
            }
        }

        public ListHelper(DataGridView grid)
        {
            _service = new TService();
            _dataGridView = grid;
        }

        public void InsertRecord()
        {
            var details = new TDetails();
            if (details.ShowDialog() == DialogResult.OK)
            {
                _service.Insert(LocalStorage.Record as TModel);
                RefreshRecords();
            }
        }

        public void UpdateRecord()
        {
            if (!ValidateSelection())
            {
                return;
            }

            var details = (TDetails)Activator.CreateInstance(typeof(TDetails), new object[] { ClickedModelID });
            if (details.ShowDialog() == DialogResult.OK)
            {
                _service.Update(LocalStorage.Record as TModel);
                RefreshRecords();
            }
        }

        public void DeleteRecord()
        {
            if (ValidateSelection() && MessageBox.Show($"Are you sure you want to delete this User with {ClickedModelID} ID?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(ClickedModelID);
                RefreshRecords();
            }
        }

        public void RefreshRecords()
        {
            _dataGridView.DataSource = _service.Select().ToList();
        }

        public void SearchRecords(string text)
        {

        }

        private bool ValidateSelection()
        {
            if (ClickedModelID > 0)
                return true;

            MessageBox.Show("Select Line");
            return false;
        }
    }
}
