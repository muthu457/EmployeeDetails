using employee.api.api.Domain.EmployeeOperations.Interfaces;
using employee.api.api.Domain.EmployeeOperations.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace employee.api.api.Tests.Data
{
    public class TestEmployeeRepository : IEmployeeRepository
    {
        public async Task<int> AddEmployee(Employee employee)
        {
            if (employee.LastName.Equals("Veerappan"))
                return 0;
            else return 1;
        }

        public async Task<int> DeleteEmployee(int id)
        {
            if (id == 1)
                return 0;
            else
                return 1;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeeList()
        {
            return new List<Employee> {
                new Employee { EmployeeId = 1, AddressLine = "Shollinganalur", City = "Chennai", Email = "123@gmail.com", EmployeeType = "Permanent", FirstName = "MuthuKumaran", LastName = "Veerappan" }
                , new Employee { EmployeeId = 1, AddressLine = "Shollinganalur1", City = "Chennai1", Email = "345@gmail.com", EmployeeType = "Contract", FirstName = "Ram", LastName = "Bhopal" }
                };
        }

        public async Task<Employee> GetEmployee(int id)
        {
            if (id == 1)
                return new Employee { EmployeeId = 1, AddressLine = "Shollinganalur", City = "Chennai", Email = "123@gmail.com", EmployeeType = "Permanent", FirstName = "MuthuKumaran", LastName = "Veerappan" };
            else
                return null;
        }
    }
}
