using AppFromStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public class StudentRepo : IRepo<Student>
    {
        static IList<Student> students = new List<Student>() { new Student() { Id = 101, Name = "Tim",Status="Enrolled" }, new Student() { Id = 102, Name = "Jim" } };
        public bool Add(Student t)
        {
            students.Add(t);
            return true;
        }

        public Student Get(int id)
        {
            //LINQ
            var student = students.Where(s => s.Id == id).SingleOrDefault();
            return student;
        }

        public ICollection<Student> GetAll()
        {
            return students;
        }
    }
}
