using LibraryManagementAPI.Async.DTOs.Student;
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Async.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _studentService.GetStudentsAsync();
            return Ok(students);
        }

        /*[HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Invalid student data");
            }

            await _studentService.AddStudentAsync(student);

            return Ok("Student added successfully");
        }*/
        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentCreateDTO dto)
        {
            var student = new Student
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Phone = dto.Phone
            };

            await _studentService.AddStudentAsync(student);

            return Ok("Student added successfully");
        }
    }
}