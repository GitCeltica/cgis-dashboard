using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class OrdemServicosService : IOrdemServicosService
    {
        private readonly IOrdemServicoRepository _repository;

        public OrdemServicosService(IOrdemServicoRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<IndicadoresOrdemServico>> GetAll()
        {
            
            return await _repository.GetAll();
        }

        public async Task<OrdemServicoFiltro> ObterDadosFiltro(int cidadeId)
        {
            return await _repository.ObterDadosFiltro(cidadeId);
        }

        public async Task<List<IndicadoresOrdemServico>> ObterPorCidade(int cidadeId)
        {
            return await _repository.ObterPorCidade(cidadeId);
        }

        public async Task<List<IndicadoresOrdemServico>> ObterPorFiltro(ParametrosIndicadorOS parametros)
        {
            return await _repository.ObterPorFiltro(parametros);
        }

    }
}
