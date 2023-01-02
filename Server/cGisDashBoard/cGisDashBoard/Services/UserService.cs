using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Services.Interfaces;

namespace cGisDashBoard.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        { 
            _repository = repository; 
        }
        public Task<User> Create(User user)
        {
            return _repository.Create(user);
        }

        public Task Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Task<List<User>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task Update(User user, int id)
        {
            return _repository.Update(user, id);
        }
    }
}
