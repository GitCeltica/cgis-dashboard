using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories.Indicadores
{
    public class OrdemServicoRankingRepository : IOrdemServicoRankingRepository
    {
        private readonly DataContext _context;

        public OrdemServicoRankingRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<IndicadoresOrdemServicoRanking>> GetAll()
        {
            
            return await _context.IndicadoresOrdemServicoRanking.ToListAsync();
            
        }

        public async Task<List<IndicadoresOrdemServicoRanking>> ObterPorCidade(int cidadeId)
        {
            var result = await _context.IndicadoresOrdemServicoRanking.Where(x => x.CidadeId == cidadeId).ToListAsync();

            return result;

        }

        public async Task<List<IndicadoresOrdemServicoRanking>> ObterPorFiltro(ParametrosIndicadorOS parametros)
        {
            var dados = await _context.IndicadoresOrdemServicoRanking.ToListAsync();

            List<IndicadoresOrdemServicoRanking> resultado = new List<IndicadoresOrdemServicoRanking>();


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

            if (parametros.Natureza != "")
            {
                resultado = resultado.Where(x => x.Natureza == parametros.Natureza).ToList(); //.OrderByDescending(x => x.Quantidade).Take(5).ToList()
            }

            if (parametros.Equipe != "")
            {
                resultado = resultado.Where(x => x.Equipe == parametros.Equipe).ToList(); //.OrderByDescending(x => x.Quantidade).Take(5).ToList()
            }

            return resultado;
        }
    }
}
