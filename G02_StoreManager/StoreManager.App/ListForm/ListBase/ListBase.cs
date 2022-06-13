using StoreManager.App.Interfaces;
using StoreManager.Repositories;
using StoreManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager.App.ListForm.ListBase
{
    public class ListBase<TDetails, TModel, TService, TRepository, TDataGridView> : IListForm
        where TDataGridView : DataGridView, new()
        where TDetails : Form, new()
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        public TService Service { get; set; }
        public ListBase()
        {
            Service = new TService();
        }

        public void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public void InsertRecord()
        {
            TDetails details = new TDetails();
            if (details.ShowDialog() == DialogResult.OK)
            {
                var record = (LocalStorage.Record as TModel);
                Service.Insert(record);
                LocalStorage.Record = null;
            }
        }

        public void RefreshRecords()
        {
            TDataGridView data = new TDataGridView();
            data.DataSource = Service.Select().ToList();
        }

        public void SearchRecords()
        {
            TDetails details = new TDetails();
            if (details.ShowDialog() == DialogResult.OK)
            {
                var record = (LocalStorage.Record as TModel);
                Service.Get(record.GetType().GetProperties()); // ID s dabruneba gvchirdeba
                LocalStorage.Record = null;
            }
        }

        public void UpdateRecord()
        {
            TDetails details = new TDetails();
            if (details.ShowDialog() == DialogResult.OK)
            {
                var record = (LocalStorage.Record as TModel);
                Service.Update(record);
                LocalStorage.Record = null;
                details.Close();
            }
        }
    }
}
