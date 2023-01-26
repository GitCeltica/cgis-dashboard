using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class PerdasService : IPerdasService
    {
        private readonly IPerdasRepository _repository;

        public PerdasService(IPerdasRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<IndicadoresPerda>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<DadosFiltro> ObterDadosFiltro(int cidadeId)
        {
            return await _repository.ObterDadosFiltro(cidadeId);
        }

        public async Task<List<IndicadoresPerda>> ObterPorCidade(int cidadeId)
        {
            return await _repository.ObterPorCidade(cidadeId);
        }

        public async Task<List<IndicadoresPerda>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            return await _repository.ObterPorFiltro(parametros);
        }
    }
}
