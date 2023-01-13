using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces
{
    public interface IIndicadoresRepository
    {
        public Task<List<IndicadoresPerda>> GetAll();

        public Task<List<IndicadoresPerda>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresPerda>> ObterPorFiltro(ParametrosIndicador parametros);
    }
}
