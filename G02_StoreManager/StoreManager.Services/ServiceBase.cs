using StoreManager.Repositories;
using System.Collections.Generic;

namespace StoreManager.Services
{
    public abstract class ServiceBase<T>: RepositoryBase<T> where T : class, new()
    {
        //protected IRepositoryBase<T> _IRepositoryBase;

        //public ServiceBase()
        //{
        //    //_IRepositoryBase = new RepositoryBase<T>();
        //}

        //public virtual T Gets(object id)=> _IRepositoryBase.Get(id);
      
        public override T Get(object id)
        {
            return base.Get(id);
        }

        public override IEnumerable<T> Select() => base.Select();
     
        public override int Insert(T record) => base.Insert(record);

        public override void Update(T record)=> base.Update(record);
    
        public override void Delete(object id)=> base.Delete(id);
        
    }
  
}
