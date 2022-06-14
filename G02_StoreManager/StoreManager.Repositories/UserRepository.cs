using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using StoreManager.Models;

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

        public IEnumerable<User> SelectAll()
        {
            var table = _database.GetTable($"Select * from Users", CommandType.Text);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    yield return GetItem(row);
                }
            }
        }
    }
}
