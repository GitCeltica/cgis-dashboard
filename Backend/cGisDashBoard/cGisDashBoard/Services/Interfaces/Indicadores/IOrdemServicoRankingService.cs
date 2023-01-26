using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces.Indicadores
{
    public interface IOrdemServicoRankingService
    {
        public Task<List<IndicadoresOrdemServicoRanking>> GetAll();
        public Task<List<IndicadoresOrdemServicoRanking>> ObterPorCidade(int cidadeId);
        public Task<List<IndicadoresOrdemServicoRanking>> ObterPorFiltro(ParametrosIndicadorOS parametros);

        public Task<List<RegiaoAfetada>> ObterRegiaoAfetadaPorFiltro(ParametrosIndicadorOS parametros);
        public Task<List<MaterialGasto>> ObterMaterialGastoPorFiltro(ParametrosIndicadorOS parametros);

        public Task<List<EconomiaOrdemServico>> ObterEconomiaGeradaPorFiltro(ParametrosIndicadorOS parametros);

        public Task<Decimal> ObterEconomiaTotalGeradaPorFiltro(ParametrosIndicadorOS parametros);
    }
}
