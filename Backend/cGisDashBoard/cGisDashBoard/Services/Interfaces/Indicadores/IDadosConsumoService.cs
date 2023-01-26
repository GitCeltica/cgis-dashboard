using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces.Indicadores
{
    public interface IDadosConsumoService
    {
        public Task<List<IndicadoresConsumo>> GetAll();
        public Task<List<IndicadoresConsumo>> ObterPorCidade(int cidadeId);
        public Task<List<IndicadoresConsumo>> ObterPorFiltro(ParametrosIndicador parametros);
    }
}
