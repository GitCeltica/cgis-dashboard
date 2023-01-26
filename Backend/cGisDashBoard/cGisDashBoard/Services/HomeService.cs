using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Services.Interfaces;

namespace cGisDashBoard.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _repository;

        public HomeService(IHomeRepository repository)
        {
            _repository = repository;
        }
        public Task index()
        {
            throw new NotImplementedException();
        }
    }
}
