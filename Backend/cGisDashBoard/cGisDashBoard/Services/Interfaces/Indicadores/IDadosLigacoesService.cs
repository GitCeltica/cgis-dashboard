using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces.Indicadores
{
    public interface IDadosLigacoesService
    {
        public Task<List<IndicadoresLigacoes>> GetAll();
        public Task<List<IndicadoresLigacoes>> ObterPorCidade(int cidadeId);
        public Task<List<IndicadoresLigacoes>> ObterPorFiltro(ParametrosIndicador parametros);
    }
}
