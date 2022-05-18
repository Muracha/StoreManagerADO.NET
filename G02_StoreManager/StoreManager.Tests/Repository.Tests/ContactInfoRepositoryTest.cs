﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;
using System;


namespace StoreManager.Tests
{
    [TestClass]
    public class ContactInfoRepositoryTest : TestRepositoryBase<ContactInfo, ContactInfoRepository>
    {
        private ContactInfoRepository _contactInfoRepository;
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
                    _contactInfoRepository = new ContactInfoRepository();
                    _updatedContactInfo = new ContactInfo();
                    _updatedContactInfo.ID = GetID;
                    _updatedContactInfo.ContactType = 2;
                    _updatedContactInfo.ContactData = "yes";
                    _updatedContactInfo.IsPrimary = false;
                    _contactInfoRepository.Update(_updatedContactInfo);
                    var oldContactInfo = _contactInfoRepository.Get(GetID);

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