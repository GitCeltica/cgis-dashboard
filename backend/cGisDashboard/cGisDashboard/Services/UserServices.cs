using cGisDashboard.Entities;
using cGisDashboard.Repository;
using BC = BCrypt.Net.BCrypt;

namespace cGisDashboard.Services
{
    public interface IUserService
    {
        public Task<User> Create(User user);

        public Task<User> GetById(int id);

        public Task<List<User>> GetAll();

        public Task Update(User userIn, int Id);

        public Task Delete(int id);
    }
    public class UserServices : IUserService
    {
        private readonly IUserRepository _repository;

        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }
        public Task<User> Create(User user)
        {

            user.Password = BC.HashPassword(user.Password);

            user.Created_At = DateTime.Now;
            user.Updated_At = DateTime.Now;

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

        public Task Update(User userIn, int Id)
        {
            return _repository.Update(userIn, Id);
        }
    }
}
