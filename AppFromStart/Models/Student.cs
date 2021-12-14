using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Models
{
    public class Student
    {
        [Display(Name ="Student ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
