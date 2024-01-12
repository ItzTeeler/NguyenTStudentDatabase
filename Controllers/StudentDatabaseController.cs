using Microsoft.AspNetCore.Mvc;
using NguyenTStudent.Services.StudentList;
using NguyenTStudentDatabase.Models;

namespace NguyenTStudentDatabase.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class StudentDatabaseController : ControllerBase
    {
        public StudentDatabaseController(IStudentDatabaseService studentDatabaseService)
        {
        _studentDatabaseService = studentDatabaseService;
        }
    private readonly IStudentDatabaseService _studentDatabaseService;

    [HttpPost]
        [Route("StudentList/{firstName}/{lastName}/{hobbies}")]
        public List<StudentDatabase> AddStudent(string firstName, string lastName, string hobbies)
        {
            return _studentDatabaseService.AddStudent(firstName, lastName, hobbies);
        }

        [HttpGet]
        [Route("StudentList")]
        public List<StudentDatabase> ReadStudent()
        {
            return _studentDatabaseService.ReadStudent();
        }

        [HttpDelete]
        [Route("studentList/{firstName}")]
        public List<StudentDatabase> RemoveStudent(string firstName)
        {
            return _studentDatabaseService.RemoveStudent(firstName);
        }
    }
