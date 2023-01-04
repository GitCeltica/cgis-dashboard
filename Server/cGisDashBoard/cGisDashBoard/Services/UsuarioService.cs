using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Services.Interfaces;

namespace cGisDashBoard.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        { 
            _repository = repository; 
        }
        public Task<Usuario> Create(Usuario user)
        {
            return _repository.Create(user);
        }

        public Task Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Task<List<Usuario>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Usuario> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task Update(Usuario user, int id)
        {
            return _repository.Update(user, id);
        }
    }
}
