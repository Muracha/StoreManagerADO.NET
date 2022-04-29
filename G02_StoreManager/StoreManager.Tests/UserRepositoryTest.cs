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

        public UserRepositoryTest()
        {
            _userRepository = new UserRepository();
        }   

        [TestMethod]
        public void A_TestInsert()
        {
            var user = new User() { };
            int id = _userRepository.Insert(user);
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void B_TestUpdate()
        {
            var user = new User() { };
             _userRepository.Update(user);
        }

        [TestMethod]
        public void C_TestDelete()
        {
            var id = 0;
            _userRepository.Delete(id);
        }
        public void D_TestGet()
        {
            var id = 5;
            var result = _userRepository.Get(id);
            Assert.IsTrue(result!=null);
        }
    }
}
