using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces.Indicadores
{
    public interface IOrdemServicosService
    {
        public Task<List<IndicadoresOrdemServico>> GetAll();
        public Task<List<IndicadoresOrdemServico>> ObterPorCidade(int cidadeId);
        public Task<List<IndicadoresOrdemServico>> ObterPorFiltro(ParametrosIndicadorOS parametros);
    }
}
