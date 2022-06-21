using StoreManager.Repositories;
using StoreManager.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App.ListForm.ListHelper
{
    public class ListHelper<TDetails, TModel, TRepository, TService>
        where TDetails : Form, new()
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        private readonly TService _service;
        private readonly DataGridView _dataGridView;
        private int _id = 0;
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

        public ListHelper(DataGridView value)
        {
            _service = new TService();
            _dataGridView = value;
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
            if (CheckClick())
            {
                var details = (TDetails)Activator.CreateInstance(typeof(TDetails), new object[] { ClickedModelID });
                if (details.ShowDialog() == DialogResult.OK)
                {
                    _service.Update(LocalStorage.Record as TModel);
                    RefreshRecords();
                }
            }
        }

        public void DeleteRecord()
        {
            if (CheckClick())
            {
                if (MessageBox.Show($"Are you sure you want to delete this User with {ClickedModelID} ID?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _service.Delete(ClickedModelID);
                    RefreshRecords();
                }
            }
        }

        public void RefreshRecords()
        {
            _dataGridView.DataSource = _service.Select().ToList();
        }

        public void SearchRecords(string text)
        {

        }

        private bool CheckClick()
        {
            if (ClickedModelID > 0)
                return true;

            MessageBox.Show("Select Line");
            return false;
        }
    }
}
