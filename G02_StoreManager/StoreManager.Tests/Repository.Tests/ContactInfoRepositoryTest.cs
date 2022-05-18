using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using System;


namespace StoreManager.Tests
{
    [TestClass]
    public class ContactInfoRepositoryTest : TestRepositoryBase<ContactInfo, ContactInfoRepository>
    {
        private ContactInfo _updatedContactInfo;
        public ContactInfoRepositoryTest()
        {
            var contactInfo = new ContactInfo();
            contactInfo.EmployeeID = 1;
            contactInfo.ContactType = 1;
            contactInfo.ContactData = "idk";
            contactInfo.IsPrimary = true;
            GetModel = contactInfo;
        }

        [TestMethod]
        public override void D_TestUpdate()
        {
            if (TestStatus)
            {
                try
                {
                    var oldContactInfo = GetModel;
                    _updatedContactInfo = new ContactInfo();
                    _updatedContactInfo.ID = ModelID;
                    _updatedContactInfo.ContactType = 2;
                    _updatedContactInfo.ContactData = "yes";
                    _updatedContactInfo.IsPrimary = false;
                    _repository.Update(_updatedContactInfo);

                    Assert.IsTrue
                        (
                        _updatedContactInfo.ContactType != oldContactInfo.ContactType &&
                        _updatedContactInfo.ContactData != oldContactInfo.ContactData &&
                        _updatedContactInfo.IsPrimary != oldContactInfo.IsPrimary
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
