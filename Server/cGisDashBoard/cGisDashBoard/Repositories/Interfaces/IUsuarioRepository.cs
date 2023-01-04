using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        public Task<Usuario> Create(Usuario user);

        public Task<Usuario> GetById(int id);

        public Task<List<Usuario>> GetAll();

        public Task Update(Usuario user, int id);

        public Task Delete(int id);
    }
}
