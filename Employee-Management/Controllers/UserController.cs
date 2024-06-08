// Controllers/UsersController.cs
using Employee_Management.Models;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public UsersController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto user)
        {
            var existingUser = await _context.Users
                .SingleOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

            if (existingUser == null) return Unauthorized();

            return Ok(existingUser);
        }
    }
}
