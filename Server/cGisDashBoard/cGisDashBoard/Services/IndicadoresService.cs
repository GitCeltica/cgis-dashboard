using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Services.Interfaces;

namespace cGisDashBoard.Services
{
    public class IndicadoresService: IIndicadoresService
    {
        private readonly IIndicadoresRepository _repository;

        public IndicadoresService(IIndicadoresRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<IndicadoresPerda>> GetAll()
        {
            return  await _repository.GetAll();
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
