using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class DadosLigacoesService : IDadosLigacoesService
    {
        private readonly IDadosLigacoesRepository _repository;

        public DadosLigacoesService(IDadosLigacoesRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<IndicadoresLigacoes>> GetAll()
        {
            
            return await _repository.GetAll();
        }

        public async Task<List<IndicadoresLigacoes>> ObterPorCidade(int cidadeId)
        {
            return await _repository.ObterPorCidade(cidadeId);
        }

        public async Task<List<IndicadoresLigacoes>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            return await _repository.ObterPorFiltro(parametros);
        }

    }
}
