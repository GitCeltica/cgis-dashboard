using cGisDashBoard.Models.Entities;

namespace cGisDashBoard.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Usuario> Create(Usuario user);

        public Task<List<Usuario>> GetAll();

        public Task<Usuario> GetById(int id);

        public Task Update(Usuario user, int id);

        public Task Delete(int id);
    }
}
