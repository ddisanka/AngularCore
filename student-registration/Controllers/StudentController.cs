using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student_registration.Models;

namespace student_registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }


        // GET All Students
        [HttpGet]
        [Route("GetStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET Selected Student
        [HttpGet("{id}")]
        
        public async Task<ActionResult<Student>> GetStudent(String id)
        {
            var sid = await _context.Students.FindAsync(id);

            if (sid == null)
            {
                return NotFound();
            }

            return sid;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }
    }
}