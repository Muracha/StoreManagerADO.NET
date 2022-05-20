using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using System;

namespace StoreManager.Tests
{
    [TestClass]
    public class CategoryRepositoryTest : TestRepositoryBase<Category, CategoryRepository>
    {
        private Category category = new Category()
        {
            ParentID = 1,
            Name = "123",
            Description = "idk",
            CreateDate = DateTime.Now
        };
        public CategoryRepositoryTest()
        {
            base.GetModel = category;
        }

        [TestMethod]
        public override void D_TestUpdate()
        {
            if (base.TestStatus)
            {
                try
                {
                    category.ID = ModelID;
                    category.ParentID = 2;
                    category.Name = "222";
                    category.Description = "1233";
                    category.CreateDate = new DateTime(2000,1,02);
                    base._repository.Update(category);
                    var record = base._repository.Get(category.ID);

                    Assert.IsTrue(category.Name == record.Name &&
                                  category.Description == record.Description &&
                                  category.CreateDate == record.CreateDate);
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
