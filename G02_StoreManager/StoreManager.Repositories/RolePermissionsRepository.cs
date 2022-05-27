using StoreManager.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StoreManager.Repositories
{
    public class RolePermissionsRepository : RepositoryBase<RolePermissions>
    {
        public IEnumerable<object> SelectRolePermissions(int userID)
        {
            yield return _database.GetTable("SelectUserPermissions_SP", CommandType.StoredProcedure,
                           new SqlParameter("@UserID", userID));
        }
    }
}
