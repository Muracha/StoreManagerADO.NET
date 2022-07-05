using StoreManager.Models;
using StoreManager.Repositories;
using System.Collections.Generic;

namespace StoreManager.Services
{
    public class PermissionService : ServiceRepositoryBase<Permission, PermissionRepository>
    {
        public IEnumerable<Permission> GetRolePermissions(int id)
        {
            return _repository.GetRolePermissions(id);
        }
    }
}
