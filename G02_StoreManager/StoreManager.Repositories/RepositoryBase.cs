﻿using DataHelper.Facade;
using DataHelper.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Design.PluralizationServices;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace StoreManager.Repositories
{
    public abstract class RepositoryBase<T> : IDisposable where T : class, new()
    {
        protected readonly string _connectionString;
        protected readonly string _objectName;
        protected readonly IDatabase _database;

        public RepositoryBase()
        {
            _objectName = typeof(T).Name;
            _database = DatabaseFactory.GetInstance();
        }

        public virtual T Get(object id)
        {
            var table = _database.GetTable($"Select{_objectName}_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
            if (table.Rows.Count > 0)
                return GetItem(table.Rows[0]);
            return null;
        }

        public virtual IEnumerable<T> Select()
        {
            var data = _database.GetTable($"Select{GetPluralize(_objectName)}_SP", CommandType.StoredProcedure);

            foreach (DataRow row in data.Rows)
            {
                yield return GetItem(row);
            }
        }

        public virtual int Insert(T record)
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

        public virtual void Update(T record)
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
                catch
                {
                    database.RollBack();
                    throw;
                }
            }
        }

        public void Dispose()
        {
            _database.Dispose();
            GC.SuppressFinalize(this);
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
            return _database.GetTable("SelectParameters_SP", CommandType.StoredProcedure, new SqlParameter("@ProcedureNume", procedureName));
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
