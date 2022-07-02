using StoreManager.Models;
using StoreManager.Repositories;
using System.Collections.Generic;

namespace StoreManager.Services
{
    public class EmployeeService : ServiceRepositoryBase<Employee, EmployeeRepository>
    {
        public IEnumerable<Employee> GetEmployeesNotRegisteredUser()
        {  
            return _repository.GetEmployeesNotRegisteredUser();
        }
    }
}
