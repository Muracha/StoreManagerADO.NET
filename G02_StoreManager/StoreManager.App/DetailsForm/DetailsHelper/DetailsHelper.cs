using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.App.Interfaces;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.App.DetailsForm.DetailsHelper
{
    public class DetailsHelper<TModel, TRepository, TService>
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        private readonly Form _detailsForm;
        private readonly TService _service;
        private TModel _model;
        public DetailsHelper(Form form)
        {
            _detailsForm = form;
            _service = new TService();
            _model = new TModel();
        }

        public void LoadData(int id)
        {
            _model = _service.Get(id);
            foreach (PropertyInfo propertyInfo in _model.GetType().GetProperties())
            {
                foreach (var txtBox in _detailsForm.Controls.OfType<TextBox>())
                {
                    if (txtBox.Name.ToLower().Substring(3).Equals(propertyInfo.Name.ToLower()))
                    {
                        txtBox.Text = Convert.ToString(propertyInfo.GetValue(_model));
                        break;
                    }
                }
            }
        }

        public void SaveData()
        {
            if (ValidateData())
            {
                foreach (var txtBox in _detailsForm.Controls.OfType<TextBox>())
                {
                    foreach (PropertyInfo propertyInfo in _model.GetType().GetProperties())
                    {
                        if (txtBox.Name.ToLower().Substring(3).Equals(propertyInfo.Name.ToLower()))
                        {
                            propertyInfo.SetValue(_model, Convert.ChangeType(txtBox.Text, propertyInfo.PropertyType));
                            break;
                        }
                    }
                }

                LocalStorage.Record = _model;
                _detailsForm.DialogResult = DialogResult.OK;
            }
        }

        public bool ValidateData()
        {
            if (CheckAllTextBox())
            {
                return true;
            }

            return false;
        }

        private bool CheckAllTextBox()
        {
            foreach (var txtBox in _detailsForm.Controls.OfType<TextBox>())
            {
                if (txtBox.Text == string.Empty)
                {
                    MessageBox.Show("Fill the missed lines.");
                    return false;
                }
            }

            return true;
        }
    }
}
