using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
    }
}
