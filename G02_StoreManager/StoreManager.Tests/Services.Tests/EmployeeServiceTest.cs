using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.Services;
using StoreManager.Repositories;
using StoreManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreManager.Tests.Services.Tests
{
    [TestClass]
    public class EmployeeServiceTest : TestServiceBase<Employee, EmployeeService, EmployeeRepository>
    {
        private Employee employee = new Employee()
        {
            FirstName = "Michael",
            LastName = "Murachashvili",
            BirthDate = DateTime.MinValue,
            HireDate = DateTime.Today,
        };

        public EmployeeServiceTest()
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
                    employee.BirthDate = new DateTime(1999, 02, 01);
                    employee.HireDate = new DateTime(1999, 02, 02);
                    base._service.Update(employee);
                    var record = base._service.Get(employee.ID);

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
