using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Services
{
    public class RoleService : ServiceRepositoryBase<Role, RoleRepository>
    {
        public void AssignUserToRole(int userID, int roleID)
        {
            _repository.AssignUserToRole(userID, roleID);
        }
        public void UnassignUserToRole(int userID, int roleID)
        {
            _repository.UnassignUserToRole(userID, roleID);
        }
    }
}
