using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Repositories.Interfaces;

namespace cGisDashBoard.Repositories
{
    public class HomeRepository: IHomeRepository
    {
        private readonly DataContext _context;

        public HomeRepository(DataContext context)
        {
            _context = context;
        }

        public Task index()
        {
            throw new NotImplementedException();
        }
    }
}
