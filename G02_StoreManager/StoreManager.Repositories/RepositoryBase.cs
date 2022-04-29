using DataHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Design.PluralizationServices;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace StoreManager.Repositories
{
    public abstract class RepositoryBase<T> where T : class, new()
    {
        protected readonly string _connectionString;
        private readonly string _objectName;

        public RepositoryBase()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _objectName = typeof(T).Name;
        }

        public virtual T Get(int id)
        {
            using (var database = new Database(_connectionString))
            {
                var table = database.GetTable($"Select{_objectName}_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                if (table.Rows.Count > 0)
                    return GetItem(table.Rows[0]);
                return null;
            }
        }

        public virtual IEnumerable<T> Select()
        {
            using (var database = new Database(_connectionString))
            {
                //todo: გადავიყვანოთ _objectName მრავლობითში (მოძებნეთ შესაბამისი პაკეტი).
                string commandText = GetPluralize(_objectName);

                var data = database.GetTable($"Select{commandText}_SP", CommandType.StoredProcedure);

                foreach (DataRow row in data.Rows)
                {
                    yield return GetItem(row);
                }
            }
        }

        public virtual int Insert(T record)
        {
            using (var database = new Database(_connectionString, true))
            {
                int id;
                try
                {
                    string objectName = $"Insert{_objectName}_SP";
                    database.BeginTransaction();
                    id = (int)database.ExecuteScalar(objectName, CommandType.StoredProcedure, GetParametrs(record, objectName).ToArray());
                    database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    database.RollBack();
                    throw ex;
                }
                return id;
            }
        }

        public virtual void Update(T record)
        {
            using (var database = new Database(_connectionString, true))
            {
                try
                {
                    string commandText = $"Update{_objectName}_SP";
                    database.BeginTransaction();
                    database.ExecuteNonQuery(commandText, CommandType.StoredProcedure, GetParametrs(record, commandText).ToArray());
                    database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    database.RollBack();
                    throw ex;
                }
            }
        }

        public virtual void Delete(int id)
        {
            using (var database = new Database(_connectionString, true))
            {
                try
                {
                    database.BeginTransaction();
                    database.ExecuteNonQuery($"Delete{_objectName}_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                    database.CommitTransaction();
                }
                catch
                {
                    database.RollBack();
                    throw;
                }
            }
        }

        #region Methods Helper

        private IEnumerable<SqlParameter> GetParametrs(T record, string commandText)
        {
            Type item = typeof(T);
            var parametrsTable = GetProcedureParametrs(commandText);

            foreach (DataRow row in parametrsTable.Rows)
            {
                foreach (var property in item.GetProperties()) //typeof(T).GetType().GetProperties() <<< does not work 
                {
                    if (property.Name == row[0].ToString().Substring(1))
                    {
                        yield return new SqlParameter(row[0].ToString(), property.GetValue(record));
                    }
                }
            }
        }

        private T GetItem(DataRow dr)
        {
            T item = new T();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo property in item.GetType().GetProperties())
                {
                    if (property.Name == column.ColumnName)
                        property.SetValue(item, dr[column.ColumnName], null);
                }
            }
            return item;
        }

        private DataTable GetProcedureParametrs(string procedureNume)
        {
            using (var database = new Database(_connectionString))
            {
                var table = database.GetTable("SelectParameters_SP", CommandType.StoredProcedure, new SqlParameter("@ProcedureNume", procedureNume));
                return table;
            }
        }

        private string GetPluralize(string objectName)
        {
            CultureInfo ci = new CultureInfo("en-us");
            PluralizationService ps = PluralizationService.CreateService(ci);

            if (ps.IsSingular(objectName) == true)
                return ps.Pluralize(objectName);
            else
                return objectName;
        }
        #endregion
    }
}
