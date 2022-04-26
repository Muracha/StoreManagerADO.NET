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
                var data = database.GetTable($"Select{_objectName}_SP", CommandType.StoredProcedure);

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
                    database.BeginTransaction();
                    id = (int)database.ExecuteScalar($"Insert{_objectName}_SP", CommandType.StoredProcedure, GetParametrs(record).ToArray());
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
                    database.BeginTransaction();
                    database.ExecuteNonQuery($"Update{_objectName}_SP", CommandType.StoredProcedure, GetParametrs(record).ToArray());
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

        private IEnumerable<SqlParameter> GetParametrs(T record)
        {
            foreach (var property in typeof(T).GetType().GetProperties())
            {
                if (property.GetValue(record) != null)
                {
                    yield return new SqlParameter($"@{property.Name}", property.GetValue(record));
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
        #endregion
    }
}
