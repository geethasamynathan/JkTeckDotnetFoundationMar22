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
        [HttpGet]
        public IEnumerable<Employee> FetchEmployees()
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

                public HttpResponseMessage PostAddNewEmployee([FromBody] Employee employee)
        {
            try
            {
                using (EmployeeContext context = new EmployeeContext())
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                    return message;
                }
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        public HttpResponseMessage Put(int id,[FromBody] Employee employee)
        {
            using(EmployeeContext context=new EmployeeContext())
            {
                Employee emp = context.Employees.FirstOrDefault(e => e.ID == id);
                if (emp == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound,
                        "Employee id " + id.ToString() + " Not Found to update");
                }
                else
                {
                    emp.Name = employee.Name;
                    emp.Designation = employee.Designation;
                    emp.Salary = employee.Salary;
                    //  context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, emp);
                }
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                Employee emp = context.Employees.FirstOrDefault(e => e.ID == id);
                if (emp == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound,
                        "Employee id " + id.ToString() + " Not Found to Delete");
                }
                else
                {
                    context.Employees.Remove(context.Employees.FirstOrDefault(e => e.ID == id));
                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, emp);
                }
            }
          
        }
    }
}
