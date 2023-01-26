using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class DadosConsumoService : IDadosConsumoService
    {
        private readonly IDadosConsumoRepository _repository;

        public DadosConsumoService(IDadosConsumoRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<IndicadoresConsumo>> GetAll()
        {
            
            return await _repository.GetAll();
        }

        public async Task<List<IndicadoresConsumo>> ObterPorCidade(int cidadeId)
        {
            return await _repository.ObterPorCidade(cidadeId);
        }

        public async Task<List<IndicadoresConsumo>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            return await _repository.ObterPorFiltro(parametros);
        }

    }
}
