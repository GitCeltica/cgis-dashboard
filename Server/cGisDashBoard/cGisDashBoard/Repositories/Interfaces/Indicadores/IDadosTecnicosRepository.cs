using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IDadosTecnicosRepository
    {
        public Task<List<IndicadoresDadosTecnicos>> GetAll();
    }
}
