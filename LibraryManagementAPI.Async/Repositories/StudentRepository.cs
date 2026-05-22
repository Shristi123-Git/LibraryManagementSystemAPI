using LibraryManagementAPI.Async.Data;
using LibraryManagementAPI.Async.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Async.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LibraryDbContext _context;

        public StudentRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync();
        }
    }
}