using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class DadosTecnicosService : IDadosTecnicosService
    {
        private readonly IDadosTecnicosRepository _repository;

        public DadosTecnicosService(IDadosTecnicosRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<IndicadoresDadosTecnicos>> GetAll()
        {
            
            return await _repository.GetAll();
        }
    }
}
