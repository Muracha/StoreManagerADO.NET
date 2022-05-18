using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
    public interface IRepositoryBase<TModel> where TModel : class, new()
    {
        void Delete(object id);
        void Dispose();
        TModel Get(object id);
        TModel GetItem(DataRow dr);
        IEnumerable<SqlParameter> GetParametrs(TModel record, string procedureName);
        string GetPluralize(string objectName);
        DataTable GetProcedureParametrs(string procedureName);
        int Insert(TModel record);
        IEnumerable<TModel> Select();
        void Update(TModel record);
    }
}