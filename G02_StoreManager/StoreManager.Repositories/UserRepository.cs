using StoreManager.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
    public class UserRepository : RepositoryBase<User>
    {
        public int Login(string username, string password)
        {
            int result = (int)_database.ExecuteScalar("Login_SP", CommandType.StoredProcedure,
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password));
            return result;
        }
    }
}
