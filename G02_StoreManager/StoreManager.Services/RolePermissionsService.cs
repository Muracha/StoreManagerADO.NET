using StoreManager.Models;
using StoreManager.Repositories;
using System.Collections.Generic;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace StoreManager.Services
{
    public class RolePermissionsService : ServiceRepositoryBase<RolePermissions, RolePermissionsRepository>
    {
        public IEnumerable<int> SelectRolePermissions(int userId)
        {
            return _repository.SelectRolePermissions(userId);
        }
        public void StartDableDependenc()
        {
            _repository.StartTableDependency();
        }
    }
}
