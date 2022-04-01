using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="enter the FirstName")]
        [StringLength(10)]
        public string FirstName { get; set; }
        [Required (ErrorMessage ="Enter the Lastname")]
        [StringLength(15,MinimumLength =3,ErrorMessage ="Last name should be between 3 to 15 characters long")]
        public string LastName { get; set; }
        [Range(18,70,ErrorMessage ="Age must be between 18 to 70")]
        public int Age { get; set; }



        [DataType(DataType.Date)]
      //  [Range(typeof(DateTime),"01-01-2010 ","01-01-2022",ErrorMessage = "DOB must between 01-01-1952 01-01-2002")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
         [DOBValidation]
        public DateTime DateOfBirth { get; set; }



        [DataType(DataType.PostalCode,ErrorMessage ="enter valid Postal/Zip Code")]
        public int PostalCode { get; set; }
        [Required(ErrorMessage ="Please Enter mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Enter a valid Email address")]
        public string EmailId { get; set; }
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-Za-z]+))$")]

        [MinLength(5,ErrorMessage ="Address must be atleast 5 characters")]
        [MaxLength(50, ErrorMessage = "Address cannot more than 50 characters")]
        public string Address { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Enter the Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the ConfirmPassword")]
        [Compare("Password",ErrorMessage ="Password and confirm does not match")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber,ErrorMessage ="Enter valid mobile Number")]
        public string Mobile { get; set; }
        [DataType(DataType.Url)]
        public string URL { get; set; }


    }
}