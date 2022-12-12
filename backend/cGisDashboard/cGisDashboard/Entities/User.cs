using cGisDashboard.Enums;

namespace cGisDashboard.Entities
{
    public class User: BaseEntity
    {

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string UserName { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

        public TypeUser Type { get; set; }
    }
}
