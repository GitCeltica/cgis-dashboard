using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IDadosConsumoRepository
    {
        public Task<List<IndicadoresConsumo>> GetAll();

        public Task<List<IndicadoresConsumo>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresConsumo>> ObterPorFiltro(ParametrosIndicador parametros);
    }
}
