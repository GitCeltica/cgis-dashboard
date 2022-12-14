using cGisDashboard.Entities;

namespace cGisDashboard.Dto
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; } 

        public string UserName { get; set; }
        
        public Enums.TypeUser type { get; set; }

        public string Token { get; set; }


        public AuthenticateResponse(Entities.User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            type = user.Type;
            Token = token;
        }
    }
}
