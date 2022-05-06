using System;
using System.Data;
using System.Data.SqlClient;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class UserRepository : RepositoryBase<User>
    {
        public int Login(User user)
        {
            var result = (int)_database.ExecuteScalar("Login_SP", CommandType.StoredProcedure,
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password));
            
            return result;
        }
    }
}
