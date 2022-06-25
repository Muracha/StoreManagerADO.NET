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
        private TModel _model;

        private readonly Form _detailsForm;
        private readonly TService _service;

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
                foreach (Control control in _detailsForm.Controls)
                {
                    if (control is TextBox)
                    {
                        if (control.Name.ToLower().Substring(3).Equals(propertyInfo.Name.ToLower() + "value"))
                        {
                            control.Text = Convert.ToString(propertyInfo.GetValue(_model));
                            break;
                        }
                    }
                    else if (control is CheckBox)
                    {
                        if (control.Name.ToLower().Substring(3).Equals(propertyInfo.Name.ToLower() + "value"))
                        {
                            (control as CheckBox).Checked = Convert.ToBoolean(propertyInfo.GetValue(_model));
                            break;
                        }
                    }
                }
            }
        }

        public void SaveData()
        {
            if (ValidateData())
            {
                foreach (Control control in _detailsForm.Controls)
                {
                    foreach (PropertyInfo propertyInfo in _model.GetType().GetProperties())
                    {
                        if (control.Name.ToLower().Substring(3).Equals(propertyInfo.Name.ToLower() + "value"))
                        {
                            propertyInfo.SetValue(_model, Convert.ChangeType(control.Text, propertyInfo.PropertyType));
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
