using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirstSampleApp.Models
{
    public partial class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        public int CourseNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
