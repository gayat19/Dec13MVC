using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Models
{
    public partial class Student
    {
        //[Display(Name ="Student ID")]
        //[RegularExpression("[1][0-9][0-9]")]
        //public int Id { get; set; }

        //[Required(ErrorMessage ="Name cannot be empty")]
        //[MinLength(3,ErrorMessage ="Invalid entry for name")]
        //[TextCheckValidation(ErrorMessage ="Only chars allowed")]
        //public string Name { get; set; }
        //public string Status { get; set; }
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int Course_Id { get; set; }
        [ForeignKey("Course_Id")]
        public Course Course { get; set; }
    }
}
