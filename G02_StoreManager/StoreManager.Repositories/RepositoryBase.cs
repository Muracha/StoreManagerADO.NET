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
    public abstract class RepositoryBase<T> where T : class
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public string _commandText { get; set; }

        public virtual T Get(int id)
        {
            T obj = null;
            using (var database = new Database(_connectionString))
            {
                var table = database.GetTable(_commandText, CommandType.StoredProcedure, new SqlParameter("@ID", id));

                foreach (DataRow row in table.Rows)
                {
                    obj = GetItem(row);
                }
                return obj;
            }
        }

        public virtual IEnumerable<T> Select()
        {
            T obj = null;
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
                IList<SqlParameter> list = new List<SqlParameter>();
                int outPutID = 0;
                try
                {
                    database.BeginTransaction();

                    list = GetParametrs(record);
                    var outParn = new SqlParameter("@Iddentity", SqlDbType.Int);
                    outParn.Direction = ParameterDirection.Output;
                    list.Add(outParn);

                    database.ExecuteNonQuery(_commandText, CommandType.StoredProcedure, list.ToArray());

                    database.CommitTransaction();
                    outPutID = (int)outParn.Value;
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

        private IList<SqlParameter> GetParametrs(T record)
        {
            Type temp = typeof(T);
            var list = new List<SqlParameter>();

            foreach (PropertyInfo pro in temp.GetProperties())
            {
                if (pro.GetValue(record) != null)
                {
                    list.Add(new SqlParameter($"@{pro.Name}", pro.GetValue(record)));
                }
            }
            return list;
        }

        private T GetItem(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return obj;
        }

        #endregion
    }
}
