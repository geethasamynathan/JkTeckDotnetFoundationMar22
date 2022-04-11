using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Consuming_WebAPI_using_MVC_Demo.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Designation { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}