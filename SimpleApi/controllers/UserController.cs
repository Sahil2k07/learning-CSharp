using BlogApp.Dto;
using BlogApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class UserController(UserService userService) : ControllerBase
    {
        private readonly UserService _userService = userService;

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateName([FromBody] CreateUserRequest request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                return BadRequest("Name cannot be empty.");
            }

            await _userService.CreateUserAsync(request.Name);

            return Ok(new { Message = "User created successfully." });
        }
    }
}
