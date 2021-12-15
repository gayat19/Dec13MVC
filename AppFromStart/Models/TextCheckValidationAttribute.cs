using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Models
{
    public class TextCheckValidationAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ((string)value).All(char.IsLetter);
        }
    }
}
