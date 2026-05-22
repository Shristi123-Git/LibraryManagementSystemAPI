using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();

        Task AddAsync(Student student);
    }
}