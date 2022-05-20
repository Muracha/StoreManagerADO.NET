﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Tests
{
    [TestClass]
    public class UserRepositoryTest : TestRepositoryBase<User, UserRepository>
    {
        private User user = new User()
        {
            ID = 1,
            Username = "Misho",
            Password = "123",
            IsActive = true
        };

        public UserRepositoryTest()
        {
            base.GetModel = user;
        }

        [TestMethod]
        public override void D_TestUpdate()
        {
            if (base.TestStatus)
            {
                try
                {
                    user.ID = ModelID;
                    user.Username = "Michael";
                    user.IsActive = false;
                    base._repository.Update(user);
                    var record = base._repository.Get(ModelID);

                    Assert.IsTrue(user.Username == record.Username &&
                                  user.IsActive == record.IsActive);
                }
                catch
                {
                    TestStatus = false;
                    Assert.Fail();
                }
            }
        }
    }
}
