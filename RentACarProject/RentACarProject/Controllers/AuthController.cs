using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACarProject.Dtos.AuthDtos;
using RentACarProject.Entities;
using System;
using System.Threading.Tasks;

namespace RentACarProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            User user = await _userManager.FindByNameAsync(registerDto.Username);
            if (user != null)
            {
                return BadRequest();
            }
            user = new User
            {
                UserName = registerDto.Username,
                Name = registerDto.Name,
                Surname = registerDto.Surname,
                Email = registerDto.Email
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            result = await _userManager.AddToRoleAsync(user, "Admin");

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("User registiried succesfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            User user = await _userManager.FindByNameAsync(loginDto.Username);
            if (user == null) return NotFound();
            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
            {
                return BadRequest();
            }
            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
                }
            };
            return Ok("Roles Created");
        }
    }
}
