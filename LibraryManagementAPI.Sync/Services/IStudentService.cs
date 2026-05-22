using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        void AddStudent(Student student);
    }
}