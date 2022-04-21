using DataHelper;
using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StoreManager.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public EmployeeRepository(string commandText = null)
        {
            _commandText = commandText;
        }
    }
}
