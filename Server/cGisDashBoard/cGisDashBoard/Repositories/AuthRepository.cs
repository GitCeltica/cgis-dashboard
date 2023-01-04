using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.DTOs;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories
{
    public class AuthRepository: IAuthRepository
    {
        private readonly DataContext _context;
 

        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Usuario> CreateUser(Usuario user)
        {
            Usuario dbResult = await _context.Usuarios
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Username == user.Username);

            if (dbResult is not null) 
            {
                throw new Exception($"{user.Username} already exists");
            }

            _context.Usuarios.Add(user);

            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<Usuario> GetUser(string username)
        {

            var dbResult  = await _context.Usuarios
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Username == username);

            return dbResult;
        }
    }
}
