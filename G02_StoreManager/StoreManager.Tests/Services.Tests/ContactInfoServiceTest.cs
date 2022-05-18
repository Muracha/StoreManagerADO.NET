using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.Tests
{
    [TestClass]
    public class ContactInfoServiceTest : TestServiceBase<ContactInfo, ContactInfoService, ContactInfoRepository>
    {
        protected ContactInfo _updatedContactInfo;
        protected ContactInfoService _contactInfoService;

        public ContactInfoServiceTest()
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
                    _contactInfoService = new ContactInfoService();
                    _updatedContactInfo = new ContactInfo();
                    _updatedContactInfo.ID = GetID;
                    _updatedContactInfo.ContactType = 2;
                    _updatedContactInfo.ContactData = "yes";
                    _updatedContactInfo.IsPrimary = false;
                    _contactInfoService.Update(_updatedContactInfo);
                    var oldContactInfo = _contactInfoService.Get(GetID);

                    if (_updatedContactInfo.ContactType != oldContactInfo.ContactType)
                    {
                        if (_updatedContactInfo.ContactData != oldContactInfo.ContactData)
                        {
                            if (_updatedContactInfo.IsPrimary != oldContactInfo.IsPrimary)
                            {
                                Assert.IsTrue(true);
                            }
                        }
                    }

                    Assert.Fail();
                }
                catch
                {
                    TestStatus = false;
                }
            }
        }
    }
}
