using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Repositories;

namespace StoreManager.Tests
{
    [TestClass]
    public abstract class TestRepositoryBase<TModel, TRepository>
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
    {
        protected readonly TRepository _repository;
        public TestRepositoryBase()
        {
            _repository = new TRepository();
        }

        [TestMethod]
        public void A_TestInsert()
        {
            try
            {
                ModelID = _repository.Insert(GetModel);
                Assert.IsTrue(ModelID > 0);
            }
            catch
            {
                TestStatus = false;
                Assert.Fail();
            }
        }

        [TestMethod]
        public void B_TestGet()
        {
            if (TestStatus)
            {
                try
                {
                    Assert.IsTrue(_repository.Get(ModelID) != null);
                }
                catch
                {
                    TestStatus = false;
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void C_TestSelect()
        {
            if (true)
            {
                try
                {
                    Assert.IsTrue(_repository.Select() != null);
                }
                catch
                {
                    TestStatus = false;
                    Assert.Fail();
                }
            }
        }

        public abstract void D_TestUpdate();

        [TestMethod]
        public void E_TestDelete()
        {
            if (TestStatus)
            {
                try
                {
                    _repository.Delete(ModelID);
                    var record = _repository.Get(ModelID);
                    bool value = (bool)record.GetType().GetProperty("IsDeleted").GetValue(record);
                    Assert.IsTrue(value);
                }
                catch
                {
                    TestStatus = false;
                    Assert.Fail();
                }
            }
        }

        public int ModelID { get; set; }
        public bool TestStatus { get; set; }
        public TModel GetModel { get; set; }
    }
}
