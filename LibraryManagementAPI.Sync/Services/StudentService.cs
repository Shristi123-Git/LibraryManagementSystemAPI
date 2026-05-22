using LibraryManagementAPI.Models;
using LibraryManagementAPI.Repositories;

namespace LibraryManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.GetAll();
        }

        public void AddStudent(Student student)
        {
            _repo.Add(student);
        }
    }
}