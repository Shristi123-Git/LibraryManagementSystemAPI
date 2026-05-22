using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Repositories;

namespace LibraryManagementAPI.Async.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task AddStudentAsync(Student student)
        {
            await _repo.AddAsync(student);
        }
    }
}