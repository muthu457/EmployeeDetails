using employee.api.api.Domain.EmployeeOperations.Interfaces;
using employee.api.api.Domain.EmployeeOperations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace employee.api.api.Domain.EmployeeOperations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public int AddEmployee(Employee employee)
        {
            return _employeeRepository.AddEmployee(employee).Result;
        }

        public int DeleteEmployee(int id)
        {
            return _employeeRepository.DeleteEmployee(id).Result;
        }

        public IEnumerable<Employee> GetAllEmployeeList()
        {
            return _employeeRepository.GetAllEmployeeList().Result;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeRepository.GetEmployee(id).Result;
        }
    }
}
