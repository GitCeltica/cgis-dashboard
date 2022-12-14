using cGisDashboard.Enums;

namespace cGisDashboard.Dto.User
{
    public class UserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public TypeUser Type { get; set; }
     }
}
