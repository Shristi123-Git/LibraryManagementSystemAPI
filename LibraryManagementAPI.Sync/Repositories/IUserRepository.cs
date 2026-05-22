using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);

        User? Login(string email, string password);
    }
}