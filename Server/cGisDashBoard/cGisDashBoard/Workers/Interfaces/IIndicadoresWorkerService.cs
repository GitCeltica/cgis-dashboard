using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Workers.Interfaces
{
    public interface IIndicadoresWorkerService
    {
        public Task<Usuario> ProcessaIndicadores();
    }
}
