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
        protected int ModelID { get; set; }
        protected bool TestStatus { get; set; }
        protected TModel GetModel { get; set; }
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
                    Assert.IsNotNull(_service.Get(ModelID));
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
                    Assert.IsNotNull(_service.Select());
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
                    Assert.IsNull(_service.Get(ModelID));
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
