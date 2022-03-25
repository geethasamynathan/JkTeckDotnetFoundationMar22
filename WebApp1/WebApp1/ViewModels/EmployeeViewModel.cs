using System.Collections.Generic;
using WebApp1.Models;

namespace WebApp1.ViewModels
{
    public class EmployeeViewModel
    {
        public IList<Employee> Employee { get; set; }
        public IList<Address> Address { get; set; }
        public string PageTitle { get; set; }
    }
}