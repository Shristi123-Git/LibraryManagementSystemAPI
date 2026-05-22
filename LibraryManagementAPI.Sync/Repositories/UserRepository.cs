using LibraryManagementAPI.Data;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories;

public class UserRepository : IUserRepository
{
    private readonly LibraryDbContext _context;

    public UserRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public void Register(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public User? Login(string email, string password)
    {
        return _context.Users
            .FirstOrDefault(x =>
                x.Email == email &&
                x.PasswordHash == password);
    }
}