using AppFromStart.Filters;
using AppFromStart.Models;
using AppFromStart.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepo<Student> _repo;
        private readonly DummyService _dummy;

        public StudentController(IRepo<Student> repo, DummyService dummy)
        {
            _repo = repo;
            _dummy = dummy;
        }
        // StudentRepo _repo = new StudentRepo();
        public IActionResult Index()
        {
            List<Student> students = _repo.GetAll().ToList();
            return View(students);
            //return View();
        }
        public IActionResult Details(int id)
        {
            Student student = _repo.Get(id);
            return View(student);
            //return View();
        }
        [MyCreateLoggingFilter]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        //public IActionResult Create(IFormCollection form )
        //{
        //    Student student = new Student();
        //    student.Id = Convert.ToInt32(form["Id"]);
        //    student.Name = form["Name"].ToString();
        //    _repo.Add(student);
        //    return RedirectToAction("Index");
        //}
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(student);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int Id)
        {
            Student student = _repo.Get(Id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(int Id,Student student)
        {
            if (ModelState.IsValid)
            {
                if (_repo.Update(student) != null)
                    return RedirectToAction("Index");
            }
            //else
            //    ModelState.ClearValidationState(nameof(Student));
            ModelState.AddModelError("All Errors", "Details are not complete");
            return View(student);
        }
        public IActionResult Delete(int Id)
        {
            Student student = _repo.Get(Id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(int Id, Student student)
        {
            if (_repo.Delete(Id) != null )
                return RedirectToAction("Index");
            else
                return View(student);
        }
        //public string ShowNumber()
        //{
        //    return "The number is     "+_dummy.GetNumber().ToString();
        //}
        // [ActionName("ShowNumber")]
        // [Route("")]
        //[Route("User")]
        //[Route("User/MyMethod")]
        //[Route("User/MyMethod/{name?}")]
        public IActionResult ShowNumber(string name)
        {
            int[] arr = { 10, 45, 90, 21 };
            ViewData["Username"] = name;
            ViewBag.Username = name;
            ViewData["nums"] = arr;
            ViewBag.nums = arr;
            return View();
        }
    }
}
