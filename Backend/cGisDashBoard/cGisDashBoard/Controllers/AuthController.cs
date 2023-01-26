using cGisDashBoard.Models.DTOs;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserRegister register)
        {
            return Ok(await _service.Register(register));
        }

        [HttpPost("login")]
        public async Task<UserResponse> Login([FromBody] UserLogin login)
        {
            return await _service.Login(login);
        }
    }
}
