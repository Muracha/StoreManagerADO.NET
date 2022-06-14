using StoreManager.App.Interfaces;
using StoreManager.Repositories;
using StoreManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreManager.App.ListForm.ListBase
{
    public class ListBase<TDetails, TModel, TService, TRepository>
        where TDetails : Form, new()
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        public TService _service;

        public ListBase()
        {
            _service = new TService();
        }

        public void DeleteRecord(object id)
        {
            try
            {
                _service.Delete(id);    
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }

        public void InsertRecord()
        {
            try
            {
                TDetails details = new TDetails();
                if (details.ShowDialog() == DialogResult.OK)
                {
                    _service.Insert((LocalStorage.Record as TModel));
                    LocalStorage.Record = null;
                    MessageBox.Show("Successfully Added!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TModel> RefreshRecords()
        {
            return _service.Select().ToList();
        }

        public void SearchRecords()
        {
            TDetails details = new TDetails();
            if (details.ShowDialog() == DialogResult.OK)
            {
                var record = (LocalStorage.Record as TModel);
                _service.Get(record.GetType().GetProperties()); // ID s dabruneba gvchirdeba
                LocalStorage.Record = null;
            }
        }

        public void UpdateRecord()
        {
            TDetails details = new TDetails();
            if (details.ShowDialog() == DialogResult.OK)
            {
                var record = (LocalStorage.Record as TModel);
                _service.Update(record);
                LocalStorage.Record = null;
                details.Close();
            }
        }
    }
}
