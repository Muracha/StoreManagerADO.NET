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
        private SingleTon _singleTone;

        public UserRepositoryTest()
        {
            _userRepository = new UserRepository();
            _singleTone = SingleTon.Instance;
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
                _singleTone.CleareInstance();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void B_TestGet()
        {
            if (_singleTone.CheckInstance())
            {
                try
                {
                    var result = _userRepository.Get(_userId);
                    Assert.IsTrue(result != null);
                }
                catch
                {
                    _singleTone.CleareInstance();
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void C_TestSelect()
        {
            if (_singleTone.CheckInstance())
            {
                try
                {
                    var result = _userRepository.Select();
                    Assert.IsTrue(result != null);
                }
                catch
                {
                    _singleTone.CleareInstance();
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void D_TestUpdate()
        {
            if (_singleTone.CheckInstance())
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
                    User user2 = _userRepository.Get(_userId);
                    Assert.IsTrue(user2.Username == user1.Username);
                }
                catch
                {
                    _singleTone.CleareInstance();
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void E_TestDelete()
        {
            if (_singleTone.CheckInstance())
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
                    _singleTone.CleareInstance();
                    Assert.Fail();
                }
            }
        }
    }
}
