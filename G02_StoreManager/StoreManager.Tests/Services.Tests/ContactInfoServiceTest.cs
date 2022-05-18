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
                    var oldContactInfo = GetModel;
                    _updatedContactInfo.ID = ModelID;
                    _updatedContactInfo.ContactType = 2;
                    _updatedContactInfo.ContactData = "yes";
                    _updatedContactInfo.IsPrimary = false;
                    _service.Update(_updatedContactInfo);

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
