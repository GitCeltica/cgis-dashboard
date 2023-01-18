using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace cGisDashBoard.Repositories
{
    public class IndicadoresRepository: IIndicadoresRepository
    {
        private readonly DataContext _context;


        public IndicadoresRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<IndicadoresPerda>> GetAll()
        {
            return await _context.IndicadoresPerdas.ToListAsync();
        }

        public async Task<DadosFiltro> ObterDadosFiltro(int cidadeId)
        {

            DadosFiltro result = new DadosFiltro();

            var anos = await _context.PerdasAnos.FromSqlRaw("select distinct Ano from IndicadoresPerdas").ToListAsync();

            var regioes = await _context.PerdasRegioes.FromSqlRaw("select distinct Regiao from IndicadoresPerdas").ToListAsync();


            foreach(var item in anos)
            {
                result.Ano.Add(item.Ano);
            }


            foreach (var item in regioes)
            {
                result.Regioes.Add(item.Regiao);
            }

            return result;
        }

        public async Task<List<IndicadoresPerda>> ObterPorCidade(int cidadeId)
        {
            var result = await _context.IndicadoresPerdas.Where(x => x.CidadeId == cidadeId).ToListAsync();

            return result;

        }

        public async Task<List<IndicadoresPerda>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            var dados = await _context.IndicadoresPerdas.ToListAsync();

            List<IndicadoresPerda> resultado = new List<IndicadoresPerda>();

            
            if (parametros.CidadeId != 0)
            {
                resultado = dados.Where(x => x.CidadeId == parametros.CidadeId).ToList();
            }

            if (parametros.Ano != 0)
            {
                //resultado = dados.Where(x => x.Ano == parametros.Ano).ToList();
                resultado = resultado.Where(x => x.Ano == parametros.Ano).ToList();
            }

            if (parametros.Mes != 0)
            {
                //resultado = dados.Where(x => x.Mes == parametros.Mes).ToList();
                resultado = resultado.Where(x => x.Mes == parametros.Mes).ToList();
            }

            if (parametros.Regiao != "")
            {
                //resultado = dados.Where(x => x.Regiao == parametros.Regiao).ToList();
                resultado = resultado.Where(x => x.Regiao== parametros.Regiao).ToList();
            }

            return resultado;
        }


    }
}
