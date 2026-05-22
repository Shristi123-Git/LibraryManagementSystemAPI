using LibraryManagementAPI.DTOs.Student;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("api/student")]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public IActionResult Create(StudentCreateDTO dto)
        {
            var student = new Student
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Phone = dto.Phone
            };

            _studentService.AddStudent(student);
            return Ok("Student created successfully");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentService.GetStudents();

            var result = students.Select(s => new StudentReadDTO
            {
                StudentId = s.StudentId,
                FullName = s.FullName,
                Email = s.Email,
                Phone = s.Phone
            });

            return Ok(result);
        }
    }
}