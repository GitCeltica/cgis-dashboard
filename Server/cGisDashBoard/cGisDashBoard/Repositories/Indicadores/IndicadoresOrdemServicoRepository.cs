using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories.Indicadores
{
    public class IndicadoresOrdemServicoRepository : IIndicadoresOrdemServicoRepository
    {
        private readonly DataContext _context;

        public IndicadoresOrdemServicoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<IndicadoresOrdemServico>> GetAll()
        {
            
            return await _context.IndicadoresOrdemServico.ToListAsync();
            
        }

        public async Task<List<IndicadoresOrdemServico>> ObterPorCidade(int cidadeId)
        {
            var result = await _context.IndicadoresOrdemServico.Where(x => x.CidadeId == cidadeId).ToListAsync();

            return result;

        }

        public async Task<List<IndicadoresOrdemServico>> ObterPorFiltro(ParametrosIndicadorOS parametros)
        {
            var dados = await _context.IndicadoresOrdemServico.ToListAsync();

            List<IndicadoresOrdemServico> resultado = new List<IndicadoresOrdemServico>();


            if (parametros.CidadeId != 0)
            {
                resultado = dados.Where(x => x.CidadeId == parametros.CidadeId).ToList();
            }

            if (parametros.Ano != 0)
            {
                resultado = dados.Where(x => x.Ano == parametros.Ano).ToList();
            }

            if (parametros.Mes != 0)
            {
                resultado = dados.Where(x => x.Mes == parametros.Mes).ToList();
            }

            if (parametros.Natureza != "")
            {
                resultado = dados.Where(x => x.Natureza == parametros.Natureza).ToList();
            }

            if (parametros.Equipe != "")
            {
                resultado = dados.Where(x => x.Equipe == parametros.Equipe).ToList();
            }

            return resultado;
        }
    }
}
