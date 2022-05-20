using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using StoreManager.Services;

namespace StoreManager.Tests
{
    [TestClass]
    public class ContactInfoServiceTest : TestServiceBase<ContactInfo, ContactInfoService, ContactInfoRepository>
    {
        protected ContactInfo contactInfo = new ContactInfo()
        {
            EmployeeID = 1,
            ContactType = 1,
            ContactData = "idk",
            IsPrimary = true
        };

        public ContactInfoServiceTest()
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
                    base._service.Update(contactInfo);
                    var record = base._service.Get(ModelID);

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
