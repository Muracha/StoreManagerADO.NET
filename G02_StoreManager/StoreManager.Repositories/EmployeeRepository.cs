using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DataHelper;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public IEnumerable<Employee> GetEmployeesNotRegisteredUser()
        {
            var table = _database.GetTable($"GetEmployeesToAdded_SP", CommandType.StoredProcedure);
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
