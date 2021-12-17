using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        public SchoolContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseNumber = 1, Name = "RDBMS", Description = "Master teh art of databse" },
                new Course { CourseNumber = 2, Name = "C#", Description = "Microsoft C# for Dotnet" }
                );
            modelBuilder.Entity<Student>().HasData(
               new Student { Id = 101, Name = "Jim", Status="Registered",Course_Id=1},
               new Student { Id = 102, Name = "Jack", Status = "Enrolled",Course_Id=1 }
               );
        }
    }
}
