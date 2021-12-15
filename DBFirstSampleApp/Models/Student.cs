using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirstSampleApp.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
