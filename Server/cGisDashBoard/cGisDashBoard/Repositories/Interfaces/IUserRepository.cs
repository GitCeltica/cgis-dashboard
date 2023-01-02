using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> Create(User user);

        public Task<User> GetById(int id);

        public Task<List<User>> GetAll();

        public Task Update(User user, int id);

        public Task Delete(int id);
    }
}
