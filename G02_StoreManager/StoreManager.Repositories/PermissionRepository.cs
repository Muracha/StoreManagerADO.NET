using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class PermissionRepository : RepositoryBase<Permission>
    {
        public IEnumerable<Permission> GetRolePermissions(int id)
        {
            using (var reader = _database.GetTable("SelectRolePermission_SP", CommandType.StoredProcedure,
                                       new SqlParameter("@ID", id)))
            {
                foreach (DataRow rows in reader.Rows)
                {
                    yield return GetItem(rows);
                }
            }
        }
    }
}
