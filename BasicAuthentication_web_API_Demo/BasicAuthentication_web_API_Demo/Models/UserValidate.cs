using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication_web_API_Demo.Models
{
    public class UserValidate
    {
        public static bool Login(string username, string password)
        {
            UserBL userBL = new UserBL();
            var UserList = userBL.GetUser();
            return UserList.Any(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
            u.Password == password);
        }

    }
}