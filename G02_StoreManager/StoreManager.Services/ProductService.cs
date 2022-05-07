using StoreManager.Models;
using StoreManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Services
{

    //todo: gavitanot dziritadi punqcionali sabazo servisis klasshi ise rom moergos memkvidre klasebs.
    public class ProductService : ServiceBase
    {
        private ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public virtual Product Get(object id)
        {
            return _productRepository.Get(id);
        }

        public virtual IEnumerable<Product> Select()
        {
            return _productRepository.Select();
        }

        public virtual int Insert(Product record)
        {
            return _productRepository.Insert(record);
        }

        public virtual void Update(Product record)
        {
            _productRepository.Update(record);
        }

        public virtual void Delete(object id)
        {
            _productRepository.Delete(id);
        }
    }
}
