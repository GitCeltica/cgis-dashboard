using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> Create(User user);

        public Task<List<User>> GetAll();

        public Task<User> GetById(int id);

        public Task Update(User user, int id);

        public Task Delete(int id);
    }
}
