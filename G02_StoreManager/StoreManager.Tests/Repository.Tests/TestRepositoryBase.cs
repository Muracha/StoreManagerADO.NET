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
        protected TModel _model;
        protected static bool _checker = true;
        protected static int _modelID = 0;

        public TestRepositoryBase()
        {
            _repository = new TRepository();
        }

        [TestMethod]
        public void A_TestInsert()
        {
            try
            {
                GetID = _repository.Insert(GetModel);
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
                    Assert.IsTrue(_repository.Get(GetID) != null);
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
                    _repository.Delete(GetID);
                    var record = _repository.Get(GetID);
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
