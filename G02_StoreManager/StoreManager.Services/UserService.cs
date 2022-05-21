using System;
using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Services
{
    public class UserService : ServiceRepositoryBase<User, UserRepository>
    {
        public bool Login(string username, string password)
        {
            return _repository.Login(username, password);
        }

        public int GetUserID(string username)
        {
            return _repository.GetUserID(username); 
        }
    }
}
