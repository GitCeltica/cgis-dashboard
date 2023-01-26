using cGisDashBoard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return NoContent();
        }
    }
}
