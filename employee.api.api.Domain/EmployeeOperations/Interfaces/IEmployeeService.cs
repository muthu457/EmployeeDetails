using employee.api.api.Domain.EmployeeOperations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace employee.api.api.Domain.EmployeeOperations.Interfaces
{
    public interface IEmployeeService
    {
        public int AddEmployee(Employee employee);
        public int DeleteEmployee(int id);
        public IEnumerable<Employee> GetAllEmployeeList();
        public Employee GetEmployee(int id);
    }
}
