using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebAPI.Controllers
{
   // [Produces("application/xml")]
    [EnableCors("default")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id=101,Name="jim"}
        };
        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(students);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var student = students.Where(s => s.Id == id).SingleOrDefault();
            if (student != null)
                return Ok(student);
            return BadRequest("NO such student");
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Post(Student student)
        {
            students.Add(student);
            return Created("StudentCreated", student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
