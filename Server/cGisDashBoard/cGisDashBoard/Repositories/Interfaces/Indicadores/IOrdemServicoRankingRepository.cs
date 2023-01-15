using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IOrdemServicoRankingRepository
    {
        public Task<List<IndicadoresOrdemServicoRanking>> GetAll();

        public Task<List<IndicadoresOrdemServicoRanking>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresOrdemServicoRanking>> ObterPorFiltro(ParametrosIndicadorOS parametros);
    }
}
