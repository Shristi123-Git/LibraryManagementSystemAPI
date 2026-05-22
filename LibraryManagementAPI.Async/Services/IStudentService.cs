using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudentsAsync();

        Task AddStudentAsync(Student student);
    }
}