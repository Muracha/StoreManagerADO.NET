using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Tests
{
    [TestClass]
    public class PermissionRepositoryTest : TestRepositoryBase<Permission, PermissionRepository>
    {
        private Permission permission = new Permission()
        {
            PermissionName = "123",
            PermissionCode = 0001,
            Description = "for officers"
        };
        public PermissionRepositoryTest()
        {
            base.GetModel = permission;
        }

        [TestMethod]
        public override void D_TestUpdate()
        {
            if (base.TestStatus)
            {
                try
                {
                    permission.ID = ModelID;
                    permission.PermissionName = "3232";
                    permission.PermissionCode = 0002;
                    permission.Description = "Not for Officers";
                    base._repository.Update(permission);
                    var record = base._repository.Get(permission);

                    Assert.IsTrue(permission.PermissionName == record.PermissionName &&
                                  permission.PermissionCode == record.PermissionCode &&
                                  permission.Description == record.Description);
                }
                catch
                {
                    Assert.Fail();
                    TestStatus = false;
                }
            }
        }
    }
}
