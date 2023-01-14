using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IDadosLigacoesRepository
    {
        public Task<List<IndicadoresLigacoes>> GetAll();

        public Task<List<IndicadoresLigacoes>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresLigacoes>> ObterPorFiltro(ParametrosIndicador parametros);
    }
}
