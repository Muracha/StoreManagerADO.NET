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
        protected readonly string _objectName;

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
                var data = database.GetTable($"Select{GetPluralize(_objectName)}_SP", CommandType.StoredProcedure);

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
                try
                {
                    string objectName = $"Insert{_objectName}_SP";
                    database.BeginTransaction();
                    int id = (int)database.ExecuteScalar(objectName, CommandType.StoredProcedure, GetParametrs(record, objectName).ToArray());
                    database.CommitTransaction();
                    return id;
                }
                catch (Exception ex)
                {
                    database.RollBack();
                    throw ex;
                }
            }
        }

        public virtual void Update(T record)
        {
            using (var database = new Database(_connectionString, true))
            {
                try
                {
                    string procedureName = $"Update{_objectName}_SP";
                    database.BeginTransaction();
                    database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, GetParametrs(record, procedureName).ToArray());
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

        private IEnumerable<SqlParameter> GetParametrs(T record, string procedureName)
        {
            var parametrsTable = GetProcedureParametrs(procedureName);
            var properties = typeof(T).GetProperties();

            foreach (DataRow row in parametrsTable.Rows)
            {
                foreach (var property in properties) 
                {
                    if (property.Name.ToLower() == row[0].ToString().Substring(1).ToLower())
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

        private DataTable GetProcedureParametrs(string procedureName)
        {
            using (var database = new Database(_connectionString))
            {
                return database.GetTable("SelectParameters_SP", CommandType.StoredProcedure, new SqlParameter("@ProcedureNume", procedureName));
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
