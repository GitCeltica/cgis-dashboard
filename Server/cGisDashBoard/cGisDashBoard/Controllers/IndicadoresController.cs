using cGisDashBoard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IndicadoresController : ControllerBase
    {
        private readonly IIndicadoresService _service;

        public IndicadoresController(IIndicadoresService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAll();

            return Ok(result);
        }
    }
}
