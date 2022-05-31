using StoreManager.Models;
using StoreManager.Repositories;
using System.Collections.Generic;
using TableDependency.SqlClient.Base.EventArgs;

namespace StoreManager.Services
{
    public class RolePermissionsService : ServiceRepositoryBase<RolePermissions, RolePermissionsRepository>
    {
        private static bool _dependencyStatusIs { get; set; }

        public IEnumerable<int> SelectRolePermissios(int userId)
        {
            return _repository.SelectRolePermissions(userId);
        }

        public bool CheckPermissions()
        {
            var dependency = _repository.TSqlTableDependency();
            dependency.OnChanged += Dependency_OnChanged;
            dependency.Start();
            return _dependencyStatusIs;
        }

        private void Dependency_OnChanged(object sender, RecordChangedEventArgs<RolePermissions> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    _dependencyStatusIs = true;
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    _dependencyStatusIs = true;
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    _dependencyStatusIs = true;
                    break;
                default:
                    break;
            }
        }
    }
}
