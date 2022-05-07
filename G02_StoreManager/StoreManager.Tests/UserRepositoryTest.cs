using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Tests
{
    [TestClass]
    public class UserRepositoryTest
    {
        private UserRepository _userRepository;
        private static int _userId;

        public UserRepositoryTest()
        {
            _userRepository = new UserRepository();
        }

        [TestMethod]
        public void A_TestInsert()
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

        [TestMethod]
        public void B_TestGet()
        {
            var result = _userRepository.Get(_userId);
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void B_TestUpdate()
        {
            var user1 = new User
            {
                ID = 1,
                Username = "kakha",
                IsActive = false
            };
            _userRepository.Update(user1);
            User user2 = _userRepository.Get(1);

            Assert.IsTrue(user2.Username == user1.Username);
        }

        [TestMethod]
        public void C_TestDelete()
        {
            var user1 = _userRepository.Get(1);
            var id = 1;
            _userRepository.Delete(id);
            var user2 = _userRepository.Get(1);

            Assert.IsTrue(user1.IsDeleted != user2.IsDeleted);
        }

        [TestMethod]
        public void E_TestSelect()
        {
            var result = _userRepository.Select();
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void F_TestLogin()
        {
            var user = new User
            {
                Username = "gio",
                Password = "123"
            };
            // if result =0 Username or password is incorrect! 
            int result = _userRepository.Login(user);
            Assert.IsTrue(result > 0);
        }
    }
}
