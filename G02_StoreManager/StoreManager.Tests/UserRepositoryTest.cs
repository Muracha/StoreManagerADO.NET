using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;


namespace StoreManager.Tests
{
    [TestClass]
    public class UserRepositoryTest
    {
        private UserRepository _userRepository;
        private static int _userId;
        private bool _testExit;

        public UserRepositoryTest()
        {
            _userRepository = new UserRepository();
        }

        [TestMethod]
        public void A_TestInsert()
        {
            try
            {
                var user = new User
                {
                    ID = 1,
                    Username = "gio",
                    Password = "123"
                };
                int id = _userRepository.Insert(user);
                _userId = id;
                Assert.IsTrue(id > 0);
            }
            catch
            {
                Assert.Fail();
                _testExit = true;
            }
        }


        [TestMethod]
        public void B_TestGet()
        {
            if (!_testExit)
            {
                try
                {
                    var result = _userRepository.Get(_userId);
                    Assert.IsTrue(result != null);
                }
                catch
                {
                    Assert.Fail();
                    _testExit = true;
                }
            }
        }

        [TestMethod]
        public void C_TestSelect()
        {
            if (!_testExit)
            {
                try
                {
                    var result = _userRepository.Select();
                    Assert.IsTrue(result != null);
                }
                catch
                {
                    Assert.Fail();
                    _testExit = true;
                }
            }          
        }

        [TestMethod]
        public void D_TestUpdate()
        {
            if (!_testExit)
            {
                try
                {
                    var user1 = new User
                    {
                        ID = _userId,
                        Username = "kakha",
                        IsActive = true
                    };
                    _userRepository.Update(user1);
                    User user2 = _userRepository.Get(1);
                    Assert.IsTrue(user2.Username == user1.Username);
                }
                catch
                {
                    Assert.Fail();
                    _testExit = true;
                }
            }
        }

        [TestMethod]
        public void E_TestDelete()
        {
            if (!_testExit)
            {
                try
                {
                    var user1 = _userRepository.Get(_userId);
                    _userRepository.Delete(_userId);
                    var user2 = _userRepository.Get(_userId);

                    Assert.IsTrue(user1.IsDeleted != user2.IsDeleted);
                }
                catch
                {
                    Assert.Fail();
                    _testExit = true;
                }
            }
        }
    }
}
