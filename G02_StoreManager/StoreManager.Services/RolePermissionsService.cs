using StoreManager.Models;
using StoreManager.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace StoreManager.Services
{
    public class RolePermissionsService : ServiceRepositoryBase<RolePermissions, RolePermissionsRepository>
    {
        private SqlTableDependency<RolePermissions> _sqlTableDependency;

        public IEnumerable<int> SelectRolePermissions(int userId)
        {
            return _repository.SelectRolePermissions(userId);
        }

        public void  StartTableDependency()
        {
            SqlDependency h = new SqlDependency();
            _sqlTableDependency = _repository.TSqlTableDependency();
            _sqlTableDependency.OnChanged += SqlTableDependency_OnChanged;
            _sqlTableDependency.Start();
        }

        private void SqlTableDependency_OnChanged(object sender, RecordChangedEventArgs<RolePermissions> e)
        {
            if (e.ChangeType != ChangeType.None)
                LocalStorage.Permissions = _repository.SelectRolePermissions(LocalStorage.LoggedUserID);
        }

        public void StopTableDependency()
        {
            _sqlTableDependency.Stop();
        }
    }
}
