using System.Collections.Generic;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Services
{
    public class RolePermissionsService : ServiceRepositoryBase<RolePermission, RolePermissionsRepository>
    {
        public IEnumerable<int> SelectRolePermissions(int userId)
        {
            return _repository.SelectRolePermissions(userId);
        }
        public void StartTableDependenc()
        {
            _repository.StartTableDependency();
        }
    }
}
