using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using RemoteValidation_MVC_Demo.Common;
namespace RemoteValidation_MVC_Demo.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
    }
        public class UserMetaData
    {
        [RemoteClientServer("IsUserNameAvailable","Users",HttpMethod ="POST",ErrorMessage ="UserName already in use.")]
        public string Username { get; set; }
    }
}