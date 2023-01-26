using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces.Indicadores
{
    public interface IDadosTecnicosService
    {
        public Task<List<IndicadoresDadosTecnicos>> GetAll();
        public Task<List<IndicadoresDadosTecnicos>> ObterPorCidade(int cidadeId);
        public Task<List<IndicadoresDadosTecnicos>> ObterPorFiltro(ParametrosIndicador parametros);

        public Task<DadosTecnicosFiltro> ObterDadosFiltro(int cidadeId);
    }
}
