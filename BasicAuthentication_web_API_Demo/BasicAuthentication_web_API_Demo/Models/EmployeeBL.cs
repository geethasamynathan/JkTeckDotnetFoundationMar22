using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication_web_API_Demo.Models
{
    public class EmployeeBL
    {
        public  List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                if(i<5)
                {
                    empList.Add(new Employee()
                    {
                        ID = i, Name = "Emp" + i,Gender="Male",Dept="IT",Salary=30000+i

                    });
                }
                else
                {
                    empList.Add(new Employee()
                    {
                        ID = i, Name= "Emp" + i,Gender = "Female",
                        Dept = "HR",Salary = 30000 + i

                    });
                }
               
            }
            return empList;
        }
    }
}