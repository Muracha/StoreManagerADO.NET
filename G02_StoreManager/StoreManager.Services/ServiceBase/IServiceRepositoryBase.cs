using System.Collections.Generic;

namespace StoreManager.Services
{
    public interface IServiceRepositoryBase<TModel> where TModel : class, new()
    {
        void Delete(object id);
        TModel Get(object id);
        int Insert(TModel record);
        IEnumerable<TModel> Select();
        void Update(TModel record);
    }
}