using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using System;


namespace StoreManager.Tests
{
    [TestClass]
    public class ContactInfoRepositoryTest : TestRepositoryBase<ContactInfo, ContactInfoRepository>
    {
        private ContactInfo contactInfo = new ContactInfo() 
        { 
            EmployeeID = 1,
            ContactType = 1,
            ContactData = "idk",
            IsPrimary = true
        };

        public ContactInfoRepositoryTest()
        {
            base.GetModel = contactInfo;
        }

        [TestMethod]
        public override void D_TestUpdate()
        {
            if (base.TestStatus)
            {
                try
                {
                    contactInfo.ID = ModelID;
                    contactInfo.ContactType = 2;
                    contactInfo.ContactData = "yes";
                    contactInfo.IsPrimary = false;
                    base._repository.Update(contactInfo);
                    var record = base._repository.Get(contactInfo.ID);

                    Assert.IsTrue
                        (
                        contactInfo.ContactType == record.ContactType &&
                        contactInfo.ContactData == record.ContactData &&
                        contactInfo.IsPrimary == record.IsPrimary
                        );
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
