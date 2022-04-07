using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeService.Models;
namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(EmployeeContext  context=new EmployeeContext())
            {
                return context.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using(EmployeeContext context=new EmployeeContext())
            {
                return context.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
