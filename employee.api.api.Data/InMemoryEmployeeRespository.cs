using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee.api.api.Domain.EmployeeOperations.Interfaces;
using employee.api.api.Domain.EmployeeOperations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace employee.api.api.Data
{
    public class InMemoryEmployeeRespository : IEmployeeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly AppDBContext _appDbContext;
        public InMemoryEmployeeRespository(IConfiguration configuration, AppDBContext appDbContext)
        {
            _configuration = configuration;
            _appDbContext = appDbContext;
        }
        public async Task<int> AddEmployee(Employee employee)
        {
            _appDbContext.Employee.Add(employee);
            await _appDbContext.SaveChangesAsync();
            return 0;
        }

        public async Task<int> DeleteEmployee(int id)
        {
            var row = _appDbContext.Employee.AsNoTracking().Where(e => e.EmployeeId == id).FirstOrDefault();
            if (row != null)
            {
                _appDbContext.Employee.Remove(row);
                await _appDbContext.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeeList()
        {
            return await _appDbContext.Employee.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _appDbContext.Employee.AsNoTracking().Where(e => e.EmployeeId == id).FirstOrDefaultAsync();
        }
    }
}
