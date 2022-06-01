using System;
using StoreManager.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TableDependency.SqlClient;

namespace StoreManager.Repositories
{
    public class RolePermissionsRepository : RepositoryBase<RolePermissions>
    {
        public IEnumerable<int> SelectRolePermissions(int userID)
        {
            using (var reader = _database.ExecuteReader("SelectUserPermissions_SP", CommandType.StoredProcedure,
                                       new SqlParameter("@UserID", userID)))
            {
                foreach (IDataRecord record in reader)
                {
                    yield return record.GetInt32(0);
                }
            }
        }
    }
}
