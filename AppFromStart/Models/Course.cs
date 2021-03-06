using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Models
{
    public class Course
    {
        [Key]
        public int CourseNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
