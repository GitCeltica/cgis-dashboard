
using cGisDashboard.Dto;
using cGisDashboard.Dto.User;
using cGisDashboard.Entities;
using cGisDashboard.Repository;
using Microsoft.AspNetCore.Mvc;
using BC = BCrypt.Net.BCrypt;

namespace cGisDashboard.Services
{
    public interface IUserService
    {

        public Task<AuthenticateResponse> Authenticate(AuthenticateRequest request);
        public Task<UserResponse> Create(UserRequest request);

        public Task<User> GetById(int id);

        public Task<List<User>> GetAll();

        public Task Update(User userIn, int Id);

        public Task Delete(int id);
    }
    public class UserServices : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IJwtService _jwtService;

        public UserServices(IUserRepository repository , IJwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest request)
        {
            User user = await _repository.GetByUserName(request.UserName);

            if(user is null)
            {
                throw new KeyNotFoundException($" User {request.UserName} not found");
            }else if (!BC.Verify(request.Password, user.Password))
            {
                throw new BadHttpRequestException("Incorrect Password");
            }

            string token = _jwtService.GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public async Task<UserResponse> Create(UserRequest request)
        {

            User user = new User();
            UserResponse response = new UserResponse();

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            
            user.Password = BC.HashPassword(request.Password);

            user.Created_At = DateTime.Now;
            user.Updated_At = DateTime.Now;


            User result = await _repository.Create(user);

            response.UserName = result.UserName;
            response.CreatedAt = result.Created_At;
            response.UpdatedAt = result.Updated_At;

            return response;
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
