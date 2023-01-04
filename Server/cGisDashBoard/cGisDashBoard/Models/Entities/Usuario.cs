using cGisDashBoard.Enums;

namespace cGisDashBoard.Models.Entities
{
    public class Usuario: BaseEntity
    {

        public string Username { get; set; } = string.Empty;

        public string PrimeiroNome { get; set; } = string.Empty;

        public string UltimoNome { get; set; } = string.Empty;

        //public string Password { get; set; } = string.Empty;

        public TypeUser TipoUsuario { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
