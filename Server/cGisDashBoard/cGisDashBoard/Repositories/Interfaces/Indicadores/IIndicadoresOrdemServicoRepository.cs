using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Indicadores;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IIndicadoresOrdemServicoRepository
    {
        public Task<List<IndicadoresOrdemServico>> GetAll();

        public Task<List<IndicadoresOrdemServico>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresOrdemServico>> ObterPorFiltro(ParametrosIndicadorOS parametros);
    }
}
