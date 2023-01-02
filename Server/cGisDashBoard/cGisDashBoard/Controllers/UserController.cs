using cGisDashBoard.Models.Entities;
using cGisDashBoard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            var result = await _service.Create(user);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetById(id);

            return Ok(result);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update([FromBody]User user, int id)
        {
            await _service.Update(user, id);

            return NoContent();
        }
    }
}
