using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dataContext;

        public UsuarioRepository(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<Usuario> Create(Usuario user)
        {
            var dbResult = await _dataContext.Usuarios
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Username == user.Username);

            if (dbResult is not null) 
            {
                throw new Exception($" {user.Username} already exists");
            }
            
            _dataContext.Usuarios.Add(user);
            
            await _dataContext.SaveChangesAsync();

            return user;
        }

        public async Task Delete(int id)
        {
            var dbResult = await _dataContext.Usuarios.SingleOrDefaultAsync(x => x.Id == id);

            if (dbResult is null)
            {
                throw new Exception($"the {id} not found");
            }

            _dataContext.Usuarios.Remove(dbResult);

            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<Usuario>> GetAll()
        {
            var dbResult = await _dataContext.Usuarios.ToListAsync();

            return dbResult;
        }

        public async Task<Usuario> GetById(int id)
        {
            
            var dbResult = await _dataContext.Usuarios.SingleOrDefaultAsync(x => x.Id == id);

            return dbResult;
        }

        public async Task Update(Usuario user, int id)
        {

            var dbResult = await _dataContext.Usuarios
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);

            if (dbResult is null)
            {
                throw new Exception($"The {id} doesnt exists");
            }


            _dataContext.Entry(user).State = EntityState.Modified;

            await _dataContext.SaveChangesAsync();
      
        }
    }
}
