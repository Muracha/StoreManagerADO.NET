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
        protected TModel _model;
        protected static bool _checker = true;
        protected static int _modelID = 0;

        public TestServiceBase()
        {
            _service = new TService();
        }

        [TestMethod]
        public void A_TestInsert()
        {
            try
            {
                GetID = _service.Insert(GetModel);
                Assert.IsTrue(GetID > 0);
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
                    Assert.IsTrue(_service.Get(GetID) != null);
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

        public abstract void D_TestUpdate();

        [TestMethod]
        public void E_TestDelete()
        {
            if (TestStatus)
            {
                try
                {
                    _service.Delete(GetID);
                    var record = _service.Get(GetID);
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

        public int GetID
        {
            get => _modelID;
            set => _modelID = value;
        }

        public bool TestStatus
        {
            get => _checker;
            set => _checker = value;
        }

        public TModel GetModel
        {
            get => _model;
            set => _model = value;
        }
    }
}
