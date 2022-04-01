using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationDemo.Models
{
    public class DOBValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //int validmobileno = value.ToString().Length;
            ////  if(validmobileno==10)
            //int fistdigitmobileno = value.ToString()[0];
            //    if(fistdigitmobileno<=5)
            //{

            //}
            DateTime CurrentDate = DateTime.Now;
            DateTime dobvalue = Convert.ToDateTime(value);
            //int age = CurrentDate.Year - dobvalue.Year;
            //if(age<=0 || age>70)
            //{ }
            string message = "";
            //(or)
           // string message = string.Empty;
            if(Convert.ToDateTime(value)>CurrentDate)
            {

                message = "DOB should not be greater than current Date";
                return new ValidationResult(message);
            }
            return ValidationResult.Success;
        }
    }
}