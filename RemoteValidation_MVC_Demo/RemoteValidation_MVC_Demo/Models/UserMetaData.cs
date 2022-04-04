using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RemoteValidation_MVC_Demo.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
    }
        public class UserMetaData
    {
        [Remote("IsUserNameAvailable","Users",HttpMethod ="POST",ErrorMessage ="UserName already in use.")]
        public string Username { get; set; }
    }
}