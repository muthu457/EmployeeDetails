using System;
using System.Collections.Generic;
using System.Text;

namespace employee.api.api.Domain.EmployeeOperations.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeType { get; set; }
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
    }
}
