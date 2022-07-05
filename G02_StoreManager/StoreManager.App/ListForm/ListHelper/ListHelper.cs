using System;
using System.Linq;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App.ListForm.ListHelper
{
    public class ListHelper<TDetails, TModel, TRepository, TService>
        where TDetails : Form, IDetailsForm<TModel>, new()
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        private int _id = 0;

        public readonly TService _service;
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
            if (details is IDetailsForm<TModel>)
            {
                if (details.ShowDialog() == DialogResult.OK)
                {
                    _service.Insert(details.SaveData());
                    RefreshRecords();
                }
            }
        }

        public void UpdateRecord()
        {
            if (!ValidateSelection())
            {
                return;
            }

            var details = new TDetails();
            if (details is IDetailsForm<TModel>)
            {
                details.LoadData(ClickedModelID);
                if (details.ShowDialog() == DialogResult.OK)
                {
                    _service.Update(details.SaveData());
                    RefreshRecords();
                }
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
            if (text == string.Empty)
                RefreshRecords();
            else
                _dataGridView.DataSource = _service.Select(text).ToList();
        }

        public bool ValidateSelection()
        {
            if (ClickedModelID > 0)
                return true;

            MessageBox.Show("Select Line");
            return false;
        }
    }
}
