using DataHelper.Facade;
using DataHelper.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Design.PluralizationServices;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace StoreManager.Repositories
{
    public abstract class RepositoryBase<TModel> : IDisposable where TModel : class, new()
    {
        protected readonly string _objectName;
        protected readonly IDatabase _database;

        public RepositoryBase()
        {
            _objectName = typeof(TModel).Name;
            _database = DatabaseFactory.GetInstance();
        }

        public virtual TModel Get(object id)
        {
            try
            {
                var table = _database.GetTable($"Select{_objectName}_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                if (table.Rows.Count > 0)
                    return GetItem(table.Rows[0]);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<TModel> Select()
        {
            IList<TModel> list = new List<TModel>();

            try
            {
                var table = _database.GetTable($"Select{GetPluralize(_objectName)}_SP", CommandType.StoredProcedure);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(GetItem(row));
                    }
                    return list;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual int Insert(TModel record)
        {
            using (var database = DatabaseFactory.GetInstance(true))
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

        public virtual void Update(TModel record)
        {
            using (var database = DatabaseFactory.GetInstance(true))
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

        public virtual void Delete(object id)
        {
            using (var database = DatabaseFactory.GetInstance(true))
            {
                try
                {
                    database.BeginTransaction();
                    database.ExecuteNonQuery($"Delete{_objectName}_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                    database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    database.RollBack();
                    throw ex;
                }
            }
        }
        
        public void Dispose()
        {
            _database.Dispose();
            GC.SuppressFinalize(this);
        }

        #region Method Helper

        public IEnumerable<SqlParameter> GetParametrs(TModel record, string procedureName)
        {
            var parametrsTable = GetProcedureParametrs(procedureName);
            var properties = typeof(TModel).GetProperties();

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

        public TModel GetItem(DataRow dr)
        {
            TModel item = new TModel();

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

        public DataTable GetProcedureParametrs(string procedureName)
        {
            return _database.GetTable("SelectParameters_SP", CommandType.StoredProcedure, new SqlParameter("@ProcedureNume", procedureName));
        }

        public string GetPluralize(string objectName)
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
