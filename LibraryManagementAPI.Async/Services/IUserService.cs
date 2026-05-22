using LibraryManagementAPI.Async.DTOs;

namespace LibraryManagementAPI.Async.Services
{
    public interface IUserService
    {
        Task RegisterAsync(UserRegisterDTO dto);

        Task<string?> LoginAsync(UserLoginDTO dto);
    }
}