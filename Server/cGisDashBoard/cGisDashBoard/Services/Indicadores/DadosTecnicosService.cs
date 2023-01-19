using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using cGisDashBoard.Services.Interfaces.Indicadores;

namespace cGisDashBoard.Services.Indicadores
{
    public class DadosTecnicosService : IDadosTecnicosService
    {
        private readonly IDadosTecnicosRepository _repository;

        public DadosTecnicosService(IDadosTecnicosRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<IndicadoresDadosTecnicos>> GetAll()
        {
            
            return await _repository.GetAll();
        }

        public async Task<DadosTecnicosFiltro> ObterDadosFiltro(int cidadeId)
        {
            return await _repository.ObterDadosFiltro(cidadeId);
        }

        public async Task<List<IndicadoresDadosTecnicos>> ObterPorCidade(int cidadeId)
        {
            return await _repository.ObterPorCidade(cidadeId);
        }

        public async Task<List<IndicadoresDadosTecnicos>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            return await _repository.ObterPorFiltro(parametros);
        }

    }
}
