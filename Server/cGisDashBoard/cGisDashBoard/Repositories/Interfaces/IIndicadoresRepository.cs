using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces
{
    public interface IIndicadoresRepository
    {
        public Task<List<IndicadoresPerda>> GetAll();
    }
}
