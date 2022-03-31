using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF_CF_Approach_Demo.Models
{
    public class EmployeeDepartmentDbContext:DbContext
    {
        public EmployeeDepartmentDbContext():base("name=myconnection")
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}