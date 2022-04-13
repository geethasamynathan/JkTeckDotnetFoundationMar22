using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication_web_API_Demo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}