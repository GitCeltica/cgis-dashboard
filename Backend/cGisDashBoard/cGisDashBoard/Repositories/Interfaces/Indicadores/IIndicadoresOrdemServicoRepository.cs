
using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces.Indicadores
{
    public interface IOrdemServicoRepository
    {
        public Task<List<IndicadoresOrdemServico>> GetAll();

        public Task<List<IndicadoresOrdemServico>> ObterPorCidade(int cidadeId);

        public Task<List<IndicadoresOrdemServico>> ObterPorFiltro(ParametrosIndicadorOS parametros);

        public Task<OrdemServicoFiltro> ObterDadosFiltro(int cidadeId);

        
    }
}
