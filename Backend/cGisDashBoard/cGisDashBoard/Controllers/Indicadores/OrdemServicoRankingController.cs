using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Services.Interfaces.Indicadores;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Controllers.Indicadores
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrdemServicosRankingController : ControllerBase
    {
        private readonly IOrdemServicoRankingService _service;

        public OrdemServicosRankingController(IOrdemServicoRankingService service)
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
        public async Task<IActionResult> ObterPorFiltro([FromBody] ParametrosIndicadorOS parametros)
        {
            var result = await _service.ObterPorFiltro(parametros);

            return Ok(result);
        }

        [HttpPost]
        [Route("RegioesAfetadas/Parametros")]
        public async Task<IActionResult> ObterRegioesAfetadasPorFiltro([FromBody] ParametrosIndicadorOS parametros)
        {
            var result = await _service.ObterRegiaoAfetadaPorFiltro(parametros);

            return Ok(result);
        }

        [HttpPost]
        [Route("MaterialGasto/Parametros")]
        public async Task<IActionResult> ObterMaterialGastoPorFiltro([FromBody] ParametrosIndicadorOS parametros)
        {
            var result = await _service.ObterMaterialGastoPorFiltro(parametros);

            return Ok(result);
        }

        [HttpPost]
        [Route("EconomiaGerada/Parametros")]
        public async Task<IActionResult> ObterEconomiaGeradaPorFiltro([FromBody] ParametrosIndicadorOS parametros)
        {
            var result = await _service.ObterEconomiaGeradaPorFiltro(parametros);

            return Ok(result);
        }

        [HttpPost]
        [Route("EconomiaTotalGerada/Parametros")]
        public async Task<IActionResult> ObterEconomiaTotalGeradaPorFiltro([FromBody] ParametrosIndicadorOS parametros)
        {
            var result = await _service.ObterEconomiaTotalGeradaPorFiltro(parametros);

            return Ok(result);
        }
    }
}
