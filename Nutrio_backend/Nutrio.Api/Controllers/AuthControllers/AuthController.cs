using Microsoft.AspNetCore.Mvc;
using Nutrio.Application.DTOs.Users_and_profile;
using Nutrio.Application.Interfaces;
using Nutrio.Infrastructure.Interfaces;

namespace Nutrio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrerDto registerDto)
        {
            var result = await _authService.RegisterAsync(registerDto);
            if (!result)
                return BadRequest("Користувач з таким Email вже існує");

            return Ok(new { message = "Реєстрація успішна" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto loginDto)
        {
            var response = await _authService.LoginAsync(loginDto);
            if (response == null)
                return Unauthorized("Невірний Email або пароль");

            return Ok(response);
        }
    }
}