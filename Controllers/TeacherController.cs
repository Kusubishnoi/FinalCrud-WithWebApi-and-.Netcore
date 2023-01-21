using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TESTKUSUM.Auth;
using TESTKUSUM.Data;
using TESTKUSUM.Model;

namespace TESTKUSUM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {
      
       
        private readonly UserManager<ApplicationUser> _usermanager;

        public TeacherController(UserManager<ApplicationUser> usermanager)
        {
             _usermanager = usermanager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Teacher> List = new List<Teacher>();
            var users=await _usermanager.Users.ToListAsync();
            foreach (var user in users)
            {
                if(await _usermanager.IsInRoleAsync(user,"Teacher"))
                {
                    List.Add(new Teacher()  
                    {
                        TeacherId=user.Id,
                        TeacherEmail=user.Email,
                        TeacherName=user.UserName,
                        
                    });
                }
            }
            return Ok(List);


        }
    }
}
