using System;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class UserRepository : RepositoryBase<User>
    {
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public int GetUserID(string username)
        {
            throw new NotImplementedException();
        }
    }
}
