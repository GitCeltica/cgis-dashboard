using cGisDashBoard.Models.DTOs;
using cGisDashBoard.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        public Task<User> CreateUser(User user);
        public Task<User> GetUser(string username);
    }
}
