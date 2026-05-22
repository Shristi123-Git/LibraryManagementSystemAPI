using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        void Add(Student student);
    }
}