using AppFromStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public class StudentRepoEF : IRepo<Student>
    {
        private readonly SchoolContext _context;

        public StudentRepoEF()
        {

        }
        private void FixDatabase()
        {
            _context.SaveChanges();
        }
        public StudentRepoEF(SchoolContext context)
        {
            _context = context;
        }
        public bool Add(Student t)
        {
            _context.Students.Add(t);
            FixDatabase();
            return true;
        }

        public Student Delete(int id)
        {
            _context.Students.Remove(Get(id));
            FixDatabase();
            return  Get(id);
        }

        public Student Get(int id)
        {
            var student = _context.Students.Where(s => s.Id == id).SingleOrDefault();
            return student;
        }

        public ICollection<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student Update(Student t)
        {
            var student = _context.Students.Where(s => s.Id == t.Id).SingleOrDefault();
            student.Name = t.Name;
            student.Status = t.Status;
            student.Course_Id = t.Course_Id;
            _context.Students.Update(student);
            FixDatabase();
            return student;
        }
    }
}
