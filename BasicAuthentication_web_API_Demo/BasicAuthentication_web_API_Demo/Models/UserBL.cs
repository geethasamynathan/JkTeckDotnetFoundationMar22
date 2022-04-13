using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication_web_API_Demo.Models
{
    public class UserBL
    {
        public List<User> GetUser()
        {
            List<User> userList = new List<User>();
            userList.Add(new User { ID = 101, UserName = "MaleUser", Password = "password" });
            userList.Add(new User { ID = 102, UserName = "FemaleUser", Password = "abcdef" });
            return userList;
        }
    }
}