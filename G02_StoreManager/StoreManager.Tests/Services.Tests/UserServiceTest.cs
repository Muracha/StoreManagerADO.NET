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
    public class UserServiceTest : TestServiceBase<User, UserService, UserRepository>
    {
        private User user = new User()
        {
            ID = 1,
            Username = "Misho",
            Password = "123",
            IsActive = true
        };

        public UserServiceTest()
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
                    base._service.Update(user);
                    var record = base._service.Get(ModelID);

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
