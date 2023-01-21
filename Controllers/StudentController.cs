using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TESTKUSUM.Data;
using TESTKUSUM.Model;
using Microsoft.AspNetCore.Authorization;

namespace TESTKUSUM.Controllers
{
    //[Authorize(Roles ="Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly StudentDbContext dbContext;

        public StudentsController(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Getstudent()
        {
            return Ok(await dbContext.Students.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student getStudent)
        {
            Student student = new Student()
            {
                StudentId = Guid.NewGuid(),
                FirstName = getStudent.FirstName,
                LastName = getStudent.LastName,
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return Ok(student);
        }
      
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student != null)
            {
                dbContext.Remove(student);
                await dbContext.SaveChangesAsync();
                return Ok(student);
            }
            return NotFound();
        }
    }
}

