using cGisDashBoard.Models.DTOs;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Interfaces;
using cGisDashBoard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace cGisDashBoard.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly IConfiguration _configuration;

        public AuthService(IAuthRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        private bool VerifyPassworHash(string Password, User user)
        {
            using(var hmac = new HMACSHA512(user.PasswordSalt))
            {
                var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));

                return hash.SequenceEqual(user.PasswordHash);
            }
        }

        public async Task<UserResponse> Login(UserLogin login)
        {

            UserResponse response = new UserResponse();

            
            User user = await _repository.GetUser(login.Username);

            if (user == null) 
            {
                response.Message = $"{login.Username} not found";
                return response;
            }

            if (! VerifyPassworHash(login.Password, user))
            {
                response.Message = $"the password is incorrect";
                return response;
            }


            response.Message = "User Logged";
            response.Token = CreateToken(user);

            return response;
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Secret").Value));

            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: credential
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        public async Task<User> Register(UserRegister register)
        {

            User user = new User();

            CreatePasswordHash(register.Password, out byte[] PasswordHash, out byte[] PasswordSalt);

            user.FirstName = register.FirstName;
            user.LastName= register.LastName;
            user.Username = register.Username;
            user.PasswordSalt = PasswordSalt;
            user.PasswordHash = PasswordHash;

            return await _repository.CreateUser(user);
        }
    }
}
