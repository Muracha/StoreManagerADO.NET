﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Tests
{
    [TestClass]
    public class PermissionRepositoryTest : TestRepositoryBase<Permission, PermissionRepository>
    {
        private Permission permission = new Permission()
        {
            Name = "123",
            Code = 0001,
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
                    permission.Name = "3232";
                    permission.Code = 0002;
                    permission.Description = "Not for Officers";
                    base._repository.Update(permission);
                    var record = base._repository.Get(permission);

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
