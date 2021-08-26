using employee.api.api.Domain.EmployeeOperations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace employee.api.api.Data
{
    public class AppDBContext : DbContext
    {
       public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
       {

       }
       public DbSet<Employee> Employee { get; set; }
        
    }
}
