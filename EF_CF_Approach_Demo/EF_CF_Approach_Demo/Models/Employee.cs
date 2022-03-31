using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_CF_Approach_Demo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}