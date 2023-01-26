using cGisDashBoard.Models.DTOs;
using cGisDashBoard.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace cGisDashBoard.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        public Task<Usuario> CreateUser(Usuario user);
        public Task<Usuario> GetUser(string username);
    }
}
