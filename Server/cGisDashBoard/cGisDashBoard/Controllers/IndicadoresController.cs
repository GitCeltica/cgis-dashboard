using cGisDashBoard.Models.DTOs.IndicadorPerdas;
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

        [HttpGet("{cidadeId}")]
        public async Task<IActionResult> ObterPorCidade([FromRoute] int cidadeId)
        {
            var result = await _service.ObterPorCidade(cidadeId);

            return Ok(result);
        }

        [HttpPost]
        [Route("Parametros")]
        public async Task<IActionResult> ObterPorFiltro([FromBody] ParametrosIndicador parametros)
        {
            var result = await _service.ObterPorFiltro(parametros);

            return Ok(result);
        }
    }
}
