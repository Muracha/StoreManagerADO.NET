using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class UserRolesRepository : RepositoryBase<UserRoles>
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
