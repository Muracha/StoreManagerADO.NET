using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class RolePermissionsRepository : RepositoryBase<RolePermissions>
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

        public void StartTableDependency()
        {
            /*
          create  procedure  SelectTableDependecy_SP
          as 
          begin 
	             select UserID, RoleID from dbo.UserRoles;
	             select RoleID, PermissionID from dbo.RolePermissions
          end
            */
            try
            {
                var dependecy = _database.GetSqlDependency("SelectTableDependecy_SP");
                dependecy.OnChange += new OnChangeEventHandler(StartDableDependenc_OnChange);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void StartDableDependenc_OnChange(object sender, SqlNotificationEventArgs e)
        {
            LocalStorage.Permissions = SelectRolePermissions(LocalStorage.LoggedUserID);
            StartTableDependency();
        }
    }
}
