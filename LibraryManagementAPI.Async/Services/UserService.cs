using LibraryManagementAPI.Async.DTOs;
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LibraryManagementAPI.Async.Services
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

        public async Task RegisterAsync(UserRegisterDTO dto)
        {
            User user = new User()
            {
                FullName = dto.FullName,
                Email = dto.Email,
                PasswordHash = dto.Password
            };

            await _userRepository.RegisterAsync(user);
        }

        public async Task<string?> LoginAsync(UserLoginDTO dto)
        {
            var user = await _userRepository.LoginAsync(dto.Email, dto.Password);

            if (user == null)
                return null;

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"]!)
            );

            var creds = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256
            );

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