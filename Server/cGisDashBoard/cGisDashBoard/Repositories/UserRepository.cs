using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<User> Create(User user)
        {
            var dbResult = await _dataContext.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Username == user.Username);

            if (dbResult is not null) 
            {
                throw new Exception($" {user.Username} already exists");
            }
            
            _dataContext.Users.Add(user);
            
            await _dataContext.SaveChangesAsync();

            return user;
        }

        public async Task Delete(int id)
        {
            var dbResult = await _dataContext.Users.SingleOrDefaultAsync(x => x.Id == id);

            if (dbResult is null)
            {
                throw new Exception($"the {id} not found");
            }

            _dataContext.Users.Remove(dbResult);

            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            var dbResult = await _dataContext.Users.ToListAsync();

            return dbResult;
        }

        public async Task<User> GetById(int id)
        {
            
            var dbResult = await _dataContext.Users.SingleOrDefaultAsync(x => x.Id == id);

            return dbResult;
        }

        public async Task Update(User user, int id)
        {

            var dbResult = await _dataContext.Users
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
