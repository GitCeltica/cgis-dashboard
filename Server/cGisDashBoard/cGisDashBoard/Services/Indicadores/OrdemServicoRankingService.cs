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

    }
}
