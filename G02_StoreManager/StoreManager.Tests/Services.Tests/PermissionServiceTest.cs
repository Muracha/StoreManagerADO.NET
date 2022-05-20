using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.Services;
using StoreManager.Repositories;
using StoreManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreManager.Tests.Services.Tests
{
    [TestClass]
    public class PermissionServiceTest : TestServiceBase<Permission, PermissionService, PermissionRepository>
    {
        private Permission permission = new Permission()
        {
            Name = "123",
            Code = 0001,
            Description = "for officers"
        };
        public PermissionServiceTest()
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
                    permission.Name = "3232";
                    permission.Code = 0002;
                    permission.Description = "Not for Officers";
                    base._service.Update(permission);
                    var record = base._service.Get(permission);

                    Assert.IsTrue(permission.Name == record.Name &&
                                  permission.Code == record.Code &&
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
