using DataHelper;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
    public class UserRepository : RepositoryBase<User>
    {
        private readonly string _connectionString;
     
        public UserRepository(string commandText= null)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _commandText = commandText;
        }       
    }
}
