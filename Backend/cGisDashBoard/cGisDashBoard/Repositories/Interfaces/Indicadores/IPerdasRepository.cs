using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IPerdasRepository
    {
        public Task<List<IndicadoresPerda>> GetAll();

        public Task<List<IndicadoresPerda>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresPerda>> ObterPorFiltro(ParametrosIndicador parametros);

        public Task<DadosFiltro> ObterDadosFiltro(int cidadeId);
    }
}
