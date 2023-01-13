using cGisDashBoard.Services.Interfaces.Indicadores;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers.Indicadores
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DadosTecnicosController : ControllerBase
    {
        private readonly IDadosTecnicosService _service;

        public DadosTecnicosController(IDadosTecnicosService service)
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
