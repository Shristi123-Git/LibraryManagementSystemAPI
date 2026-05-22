using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LibraryManagementAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;

        public UserService(IUserRepository userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _config = config;
        }
        public void Register(UserRegisterDTO dto)
        {
            User user = new User()
            {
                FullName = dto.FullName,
                Email = dto.Email,
                PasswordHash = dto.Password
            };

            _userRepository.Register(user);
        }

        public string? Login(UserLoginDTO dto)
        {
            var user = _userRepository.Login(dto.Email, dto.Password);

            if (user == null)
                return null;

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"])
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                 issuer: _config["Jwt:Issuer"],
                 audience: _config["Jwt:Audience"],
                 claims: new List<Claim>
                 {
                    new Claim(ClaimTypes.Name, user.Email)
                 },
                 expires: DateTime.Now.AddHours(1),
                 signingCredentials: creds
             );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}