using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication_web_API_Demo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
    }
}