using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories.Indicadores
{
    public class DadosTecnicosRepository : IDadosTecnicosRepository
    {
        private readonly DataContext _context;

        public DadosTecnicosRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<IndicadoresDadosTecnicos>> GetAll()
        {
            
            return await _context.IndicadoresDadosTecnicos.ToListAsync();
            
        }

        public async Task<DadosTecnicosFiltro> ObterDadosFiltro(int cidadeId)
        {
            DadosTecnicosFiltro result = new DadosTecnicosFiltro();

            var anos = await _context.DadosTecnicosAnos.FromSqlRaw($"select distinct Ano from IndicadoresDadosTecnicos where cidadeID = {cidadeId}").ToListAsync();

            foreach(var item in anos)
            {
                result.Ano.Add(item.Ano);
            }


            return result;
        }

        public async Task<List<IndicadoresDadosTecnicos>> ObterPorCidade(int cidadeId)
        {
            var result = await _context.IndicadoresDadosTecnicos.Where(x => x.CidadeId == cidadeId).ToListAsync();

            return result;

        }

        public async Task<List<IndicadoresDadosTecnicos>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            var dados = await _context.IndicadoresDadosTecnicos.ToListAsync();

            List<IndicadoresDadosTecnicos> resultado = new List<IndicadoresDadosTecnicos>();


            if (parametros.CidadeId != 0)
            {
                resultado = dados.Where(x => x.CidadeId == parametros.CidadeId).ToList();
            }

            if (parametros.Ano != 0)
            {
                resultado = resultado.Where(x => x.Ano == parametros.Ano).ToList();
            }

            if (parametros.Mes != 0)
            {
                resultado = resultado.Where(x => x.Mes == parametros.Mes).ToList();
            }

            if (parametros.Regiao != "")
            {
                resultado = resultado.Where(x => x.Regiao == parametros.Regiao).ToList();
            }

            return resultado;
        }
    }
}
