using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class OrdemServicoRankingService : IOrdemServicoRankingService
    {
        private readonly IOrdemServicoRankingRepository _repository;

        public OrdemServicoRankingService(IOrdemServicoRankingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<IndicadoresOrdemServicoRanking>> GetAll()
        {
            
            return await _repository.GetAll();
        }



        public async Task<List<IndicadoresOrdemServicoRanking>> ObterPorCidade(int cidadeId)
        {
            return await _repository.ObterPorCidade(cidadeId);
        }

        public async Task<List<IndicadoresOrdemServicoRanking>> ObterPorFiltro(ParametrosIndicadorOS parametros)
        {
            return await _repository.ObterPorFiltro(parametros);
        }

        public async Task<List<RegiaoAfetada>> ObterRegiaoAfetadaPorFiltro(ParametrosIndicadorOS parametros)
        {
            return await _repository.ObterRegiaoAfetadaPorFiltro(parametros);
        }

        public async Task<List<MaterialGasto>> ObterMaterialGastoPorFiltro(ParametrosIndicadorOS parametros)
        {
            return await _repository.ObterMaterialGastoPorFiltro(parametros);
        }

        public async Task<List<EconomiaOrdemServico>> ObterEconomiaGeradaPorFiltro(ParametrosIndicadorOS parametros)
        {
            return await _repository.ObterEconomiaGeradaPorFiltro(parametros);
        }

        public async Task<Decimal> ObterEconomiaTotalGeradaPorFiltro(ParametrosIndicadorOS parametros)
        {
            
            List< EconomiaOrdemServico> dados = new List<EconomiaOrdemServico>();

            Decimal resultado = 0;

            dados = await _repository.ObterEconomiaGeradaPorFiltro(parametros);

            foreach(var item in dados)
            {
                resultado = resultado + item.ValorEconomia;
            }

            return resultado;
        }
    }
}
