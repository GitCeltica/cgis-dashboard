using cGisDashBoard.Enums;

namespace cGisDashBoard.Models.Entities
{
    public class User: BaseEntity
    {

        public string Username { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        //public string Password { get; set; } = string.Empty;

        public TypeUser TypeUser { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
