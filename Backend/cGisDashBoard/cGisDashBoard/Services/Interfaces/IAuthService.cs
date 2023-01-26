using cGisDashBoard.Models.DTOs;
using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces
{
    public interface IAuthService
    {
        public Task<Usuario> Register(UserRegister register);
        public Task<UserResponse> Login(UserLogin login);
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
    }
}
