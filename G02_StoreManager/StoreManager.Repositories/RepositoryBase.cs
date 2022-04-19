using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Repositories
{
	public abstract class RepositoryBase<T>
	{
		public virtual T Get(int id)
		{
			throw new NotImplementedException();
		}

		public virtual IEnumerable<T> Select()
		{
			throw new NotImplementedException();
		}

		public virtual int Insert(T record)
		{
			throw new NotImplementedException();
		}

		public virtual void Update(T record)
		{
			throw new NotImplementedException();
		}

		public virtual void Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
