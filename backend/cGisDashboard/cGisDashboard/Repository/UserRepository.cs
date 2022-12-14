using cGisDashboard.Entities;
using cGisDashboard.Helpers;
using Microsoft.EntityFrameworkCore;

namespace cGisDashboard.Repository
{

    public interface IUserRepository
    {
        public Task<User> Create(User user);

        public Task<User> GetById(int id);

        public Task<User> GetByUserName(string userName);

        public Task<List<User>> GetAll();

        public Task Update(User userIn, int Id);

        public Task Delete(int id);
    }
    public class UserRepository: IUserRepository 
    {

        private readonly DataContext _context;
        public UserRepository(DataContext context) 
        { 
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            User userDb = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.UserName== user.UserName);

            if (userDb is not null)
            {
                throw new Exception($"UserName {user.UserName} já existe");
            }


            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return user;
        }

        public async Task Delete(int id)
        {
            User userDb = await _context.Users.SingleOrDefaultAsync(u => u.Id == id);

            if (userDb is null)
            {
                throw new Exception($"User {id} não existe.");
            }

            _context.Users.Remove(userDb);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            User userDb = await _context.Users.SingleOrDefaultAsync(u => u.Id == id);

            if(userDb is null)
            {
                throw new Exception($"User {id} não foi encontrado");
            }

            return userDb;
        }

        public async Task<User> GetByUserName(string userName)
        {
            User user = await _context.Users.SingleOrDefaultAsync(u => u.UserName == userName);

            if (user is null)
            {
                throw new Exception($"User {userName} não foi encontrado");
            }

            return user;
        }

        public async Task Update(User userIn, int id)
        {
            
            User userDb = await _context.Users 
                                    .AsNoTracking()
                                    .SingleOrDefaultAsync(u => u.Id == id);

            if(userDb is null)
            {
                throw new Exception($"User {id} nao encontrado");
            }

            _context.Entry(userIn).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
