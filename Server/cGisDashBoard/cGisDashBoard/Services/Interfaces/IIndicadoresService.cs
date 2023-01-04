using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces
{
    public interface IIndicadoresService
    {
        public Task<List<IndicadoresPerda>> GetAll();
    }
}
