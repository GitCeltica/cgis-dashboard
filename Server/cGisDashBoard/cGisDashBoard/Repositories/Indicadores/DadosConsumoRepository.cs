using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.DTOs.IndicadorPerdas;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces.Indicadores;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories.Indicadores
{
    public class DadosConsumoRepository : IDadosConsumoRepository
    {
        private readonly DataContext _context;

        public DadosConsumoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<IndicadoresConsumo>> GetAll()
        {
            
            return await _context.IndicadoresConsumo.ToListAsync();
            
        }

        public async Task<List<IndicadoresConsumo>> ObterPorCidade(int cidadeId)
        {
            var result = await _context.IndicadoresConsumo.Where(x => x.CidadeId == cidadeId).ToListAsync();

            return result;

        }

        public async Task<List<IndicadoresConsumo>> ObterPorFiltro(ParametrosIndicador parametros)
        {
            var dados = await _context.IndicadoresConsumo.ToListAsync();

            List<IndicadoresConsumo> resultado = new List<IndicadoresConsumo>();


            if (parametros.CidadeId != 0)
            {
                resultado = dados.Where(x => x.CidadeId == parametros.CidadeId).ToList();
            }

            //if (parametros.Ano != 0)
            //{
            //    resultado = dados.Where(x => x.Ano == parametros.Ano).ToList();
            //}

            //if (parametros.Mes != 0)
            //{
            //    resultado = dados.Where(x => x.Mes == parametros.Mes).ToList();
            //}

            //if (parametros.Regiao != "")
            //{
            //    resultado = dados.Where(x => x.Regiao == parametros.Regiao).ToList();
            //}

            return resultado;
        }
    }
}
