using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppFromStart.Models;

namespace AppFromStart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ChangesName()
        {
            Student student = new Student() { Id = 101, Name = "Tim" };
            return View(student);
        }
        public IActionResult Index()
        {
            Student student = new Student() { Id = 101, Name = "Tim" };
            List<Student> students = new List<Student>();
            students.Add(student);
            return View(students);
        }
    }
}
