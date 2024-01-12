using NguyenTStudentDatabase.Models;

namespace NguyenTStudent.Services.StudentList;

    public interface IStudentDatabaseService
    {
         public List<StudentDatabase> AddStudent(string firstName, string lastName, string hobbies);
         public List<StudentDatabase> ReadStudent();
         public List<StudentDatabase> RemoveStudent(string firstName);

    }
