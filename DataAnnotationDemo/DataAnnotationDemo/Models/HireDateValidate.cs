using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationDemo.Models
{
    public class HireDateValidate:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime CurrentDate = DateTime.Now;
            string message = string.Empty;
            if(Convert.ToDateTime(value)>CurrentDate)
            { message = "HireDate should not greater than currentDate";
                return new ValidationResult(message);
            }
            return ValidationResult.Success;
        }
    }
}