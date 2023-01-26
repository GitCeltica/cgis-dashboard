using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Services.Interfaces.Indicadores;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers.Indicadores
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PerdasController : ControllerBase
    {
        private readonly IPerdasService _service;

        public PerdasController(IPerdasService service)
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

        [HttpGet]
        [Route("Filtro/{cidadeId}")]
        public async Task<IActionResult> ObterDadosFiltro([FromRoute] int cidadeId)
        {
            var result = await _service.ObterDadosFiltro(cidadeId);

            return Ok(result);
        }
    }
}
