using cGisDashBoard.Helpers.Data;
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
    }
}
