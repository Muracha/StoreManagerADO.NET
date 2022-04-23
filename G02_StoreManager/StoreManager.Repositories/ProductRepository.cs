using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(string commandText = null)
        {
            _commandText = commandText;
        }
    }
}
