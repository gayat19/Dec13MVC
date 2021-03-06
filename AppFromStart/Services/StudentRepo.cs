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

        public Student Delete(int id)
        {
            Student student = Get(id);
            if (student != null)
            {
                students.Remove(student);
                return student;
            }
            return null;
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

        public Student Update(Student t)
        {
            Student student = Get(t.Id);
            if(student != null)
            {
                student.Name = t.Name;
                student.Status = t.Status;
                return student;
            }
            return null;
        }
    }
}
