using StoreManager.Models;
using StoreManager.Repositories;
using System;
using System.Collections.Generic;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace StoreManager.Services
{
    public class UserRoleService : ServiceRepositoryBase<UserRoles, UserRolesRepository>
    {
    }

}
