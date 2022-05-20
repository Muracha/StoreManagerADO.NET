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
        protected int ModelID { get; set; }
        protected bool TestStatus { get; set; }
        protected TModel GetModel { get; set; }

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
                    Assert.IsNotNull(_repository.Get(ModelID));
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
                    Assert.IsNotNull(_repository.Select());
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
                    _repository.Delete(ModelID);
                    Assert.IsNull(_repository.Get(ModelID));
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
