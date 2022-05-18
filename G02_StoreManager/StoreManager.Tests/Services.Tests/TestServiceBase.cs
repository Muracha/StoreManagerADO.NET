using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.Tests
{
    [TestClass]
    public abstract class TestServiceBase<TModel, TService, TRepository>
        where TModel : class, new()
        where TRepository : RepositoryBase<TModel>, new()
        where TService : ServiceRepositoryBase<TModel, TRepository>, new()
    {
        protected TService _service;
        public TestServiceBase()
        {
            _service = new TService();
        }

        [TestMethod]
        public void A_TestInsert()
        {
            try
            {
                ModelID = _service.Insert(GetModel);
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
                    Assert.IsTrue(_service.Get(ModelID) != null);
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
            if (TestStatus)
            {
                try
                {
                    Assert.IsTrue(_service.Select() != null);
                }
                catch
                {
                    TestStatus = false;
                    Assert.Fail();
                }
            }
        }

        public virtual void D_TestUpdate()
        {

        }

        [TestMethod]
        public void E_TestDelete()
        {
            if (TestStatus)
            {
                try
                {
                    _service.Delete(ModelID);
                    var record = _service.Get(ModelID);
                    var value = (bool)record.GetType().GetProperty("IsDeleted").GetValue(record);
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
