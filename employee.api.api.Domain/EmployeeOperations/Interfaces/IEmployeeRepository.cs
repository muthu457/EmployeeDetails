using employee.api.api.Domain.EmployeeOperations.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace employee.api.api.Domain.EmployeeOperations.Interfaces
{
    public interface IEmployeeRepository
    {
        public  Task<int> AddEmployee(Employee employee);
        public  Task<int> DeleteEmployee(int id);
        public  Task<IEnumerable<Employee>> GetAllEmployeeList();
        public  Task<Employee> GetEmployee(int id);
  
    }
}
