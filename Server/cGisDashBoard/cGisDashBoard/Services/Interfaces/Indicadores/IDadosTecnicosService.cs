using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces.Indicadores
{
    public interface IDadosTecnicosService
    {
        public Task<List<IndicadoresDadosTecnicos>> GetAll();
    }
}
