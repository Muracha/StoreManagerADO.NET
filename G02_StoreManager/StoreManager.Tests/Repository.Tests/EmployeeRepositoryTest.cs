using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreManager.Models;
using StoreManager.Repositories;

namespace StoreManager.Tests
{
    [TestClass]
    public class EmployeeRepositoryTest : TestRepositoryBase<Employee, EmployeeRepository>
    {
        private Employee employee = new Employee()
        {
            FirstName = "Michael",
            LastName = "Murachashvili",
            BirthDate = DateTime.MinValue,
            HireDate = DateTime.Today,
        };

        public EmployeeRepositoryTest()
        {
            base.GetModel = employee;
        }

        [TestMethod]
        public override void D_TestUpdate()
        {
            if (base.TestStatus)
            {
                try
                {
                    employee.ID = ModelID;
                    employee.FirstName = "Mishka";
                    employee.LastName = "Muracha";
                    employee.BirthDate = new DateTime(1999,02, 01);
                    employee.HireDate = new DateTime(1999, 02, 02);
                    base._repository.Update(employee);
                    var record = base._repository.Get(employee.ID);

                    Assert.IsTrue(employee.FirstName == record.FirstName &&
                                  employee.LastName == record.LastName &&
                                  employee.BirthDate == record.BirthDate &&
                                  employee.CreateDate == record.CreateDate);
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
