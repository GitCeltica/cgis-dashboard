using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces
{
    public interface IIndicadoresService
    {
        public Task<List<IndicadoresPerda>> GetAll();

        public Task<List<IndicadoresPerda>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresPerda>> ObterPorFiltro(ParametrosIndicador parametros);
    }
}
