using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.Repositories;
using StoreManager.Services;
using StoreManager.App.Interfaces;

namespace StoreManager.App.ListForm
{
    public partial class ListBase<TDetails, TModel, TRepository, TService> : Form, IListForm
        where TDetails : Form, new()
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        protected readonly TService _service;
        protected int _clickedModelID;

        public ListBase()
        {
            InitializeComponent();
            _service = new TService();
            this.Text = typeof(TModel).Name + " " + "List";
            RefreshRecords();
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

            var details = (TDetails)Activator.CreateInstance(typeof(TDetails), new object[] { _clickedModelID });
            if (details.ShowDialog() == DialogResult.OK)
            {
                _service.Update(LocalStorage.Record as TModel);
                RefreshRecords();
            }
        }

        public void DeleteRecord()
        {
            if (ValidateSelection() && MessageBox.Show($"Are you sure you want to delete this {typeof(TModel).Name} with {_clickedModelID} ID?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(_clickedModelID);
                RefreshRecords();
            }
        }

        public void RefreshRecords()
        {
            grdList.DataSource = _service.Select().ToList();
        }

        public void SearchRecords(string text)
        {
            if (text == string.Empty)
                RefreshRecords();
            else
                grdList.DataSource = _service.Select($"\"{text}*\"").ToList();
        }

        private bool ValidateSelection()
        {
            if (_clickedModelID > 0)
                return true;

            MessageBox.Show("Select Line");
            return false;
        }

        private void grdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
               _clickedModelID = Convert.ToInt32(grdList.Rows[e.RowIndex].Cells["ID"].Value);
        }
    }
}
