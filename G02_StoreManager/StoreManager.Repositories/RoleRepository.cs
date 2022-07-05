using System;
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
        public void UnassignUserToRole(int UserID, int RoleID)
        {
            try
            {
                var table = _database.GetTable($"UnassignUserToRole_SP", CommandType.StoredProcedure, new SqlParameter("@UserID", UserID),
                                                                                                    new SqlParameter("@RoleID", RoleID));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
