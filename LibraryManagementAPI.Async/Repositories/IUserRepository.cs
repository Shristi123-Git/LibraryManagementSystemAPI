using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Repositories
{
    public interface IUserRepository
    {
        Task RegisterAsync(User user);

        Task<User?> LoginAsync(string email, string password);
    }
}