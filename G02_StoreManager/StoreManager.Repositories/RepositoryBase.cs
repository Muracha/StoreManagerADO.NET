using DataHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace StoreManager.Repositories
{
    public abstract class RepositoryBase<T> where T : class, new()
    {
        protected readonly string _connectionString;
        private readonly string _commandText;

        public RepositoryBase()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _commandText = GetTypeNameOf(typeof(T));

        }

        public virtual T Get(int id)
        {
            using (var database = new Database(_connectionString))
            {
                var table = database.GetTable($"Select{_commandText}_SP", CommandType.StoredProcedure, new SqlParameter("@ID", id));
                if (table.Rows.Count > 0)
                    return GetItem(table.Rows[0]);
                return null;
            }
        }

        public virtual IEnumerable<T> Select()
        {
            T obj;
            using (var database = new Database(_connectionString))
            {
                var data = database.GetTable(_commandText, CommandType.StoredProcedure);

                foreach (DataRow row in data.Rows)
                {
                    obj = GetItem(row);
                    yield return obj;
                }
            }
        }

        public virtual int Insert(T record)
        {
            using (var database = new Database(_connectionString, true))
            {
                int outPutID;
                try
                {
                    database.BeginTransaction();
                    outPutID = (int)database.ExecuteScalar($"Insert{_commandText}_SP", CommandType.StoredProcedure, GetParametrs(record).ToArray());
                    database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    database.RollBack();
                    throw ex;
                }
                return outPutID;
            }
        }

        public virtual void Update(T record)
        {
            using (var database = new Database(_connectionString, true))
            {
                try
                {
                    database.BeginTransaction();
                    database.ExecuteNonQuery(_commandText, CommandType.StoredProcedure, GetParametrs(record).ToArray());
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
                    database.ExecuteNonQuery(_commandText, CommandType.StoredProcedure, new SqlParameter("@ID", id));
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

        private string GetTypeNameOf(Type obj)
        {
            Type type = obj;
            return type.Name.ToString();
        }

        private IList<SqlParameter> GetParametrs(T record)
        {
            T temp = new T();
            var list = new List<SqlParameter>();

            foreach (var property in temp.GetType().GetProperties())
            {
                if (property.GetValue(record) != null)
                {
                    list.Add(new SqlParameter($"@{property.Name}", property.GetValue(record)));
                }
            }
            return list;
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

        #endregion
    }
}
