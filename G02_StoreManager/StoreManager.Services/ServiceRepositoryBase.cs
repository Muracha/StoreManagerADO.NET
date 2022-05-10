using System.Collections.Generic;
using StoreManager.Repositories;

namespace StoreManager.Services
{
    public abstract class ServiceRepositoryBase<TModel, TRepository> : ServiceBase<TModel>
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
    {
        protected TRepository _repository;

        public ServiceRepositoryBase()
        {
            _repository = new TRepository();
        }

        public virtual TModel Get(object id)
        {
            return _repository.Get(id);
        }

        public virtual IEnumerable<TModel> Select()
        {
            return _repository.Select();
        }

        public virtual int Insert(TModel record)
        {
            return _repository.Insert(record);
        }

        public virtual void Update(TModel record)
        {
            _repository.Update(record);
        }

        public virtual void Delete(object id)
        {
            _repository.Delete(id);
        }
    }
}
