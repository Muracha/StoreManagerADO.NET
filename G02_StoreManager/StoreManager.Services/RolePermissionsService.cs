using System;
using StoreManager.Models;
using StoreManager.Repositories;
using System.Collections.Generic;

namespace StoreManager.Services
{
    public class RolePermissionsService : ServiceRepositoryBase<RolePermissions, RolePermissionsRepository>
    {
        public IEnumerable<object> SelectRolePermisios(int userId)
        {
            return _repository.SelectRolePermissions(userId);   
        }
    }
}
