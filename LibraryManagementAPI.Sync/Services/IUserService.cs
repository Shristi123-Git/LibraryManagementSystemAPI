using LibraryManagementAPI.DTOs;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services
{
    public interface IUserService
    {
        void Register(UserRegisterDTO dto);

        //User? Login(UserLoginDTO dto);
        string Login(UserLoginDTO dto);
    }
}