namespace cGisDashBoard.Models.DTOs
{
    public class UserRegister
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty; 
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
