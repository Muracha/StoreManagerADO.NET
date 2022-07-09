using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using StoreManager.Models;

namespace StoreManager.Repositories
{
    public class RoleRepository : RepositoryBase<Role>
    {
        public void AssignUserToRole(int UserID, int RoleID)
        {
            try
            {
                var table = _database.GetTable($"AssignUserToRole_SP", CommandType.StoredProcedure, new SqlParameter("@UserID", UserID),
                                                                                                    new SqlParameter("@RoleID", RoleID));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UnassignUserToRole(int userID, int roleID)
        {
            try
            {
                var table = _database.GetTable($"UnassignUserToRole_SP", CommandType.StoredProcedure, new SqlParameter("@UserID", userID),
                                                                                                      new SqlParameter("@RoleID", roleID));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Role> SelectUserRoles(int userID)
        {
            using (var reader = _database.GetTable("SelectUserRoles_SP", CommandType.StoredProcedure,
                                                   new SqlParameter("@ID", userID)))
            {
                foreach (DataRow rows in reader.Rows)
                {
                    yield return base.GetItem(rows);
                }
            }
        }
    }
}
