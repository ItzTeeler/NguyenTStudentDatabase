
using NguyenTStudent.Services.StudentList;
using NguyenTStudentDatabase.Data;
using NguyenTStudentDatabase.Models;

namespace NguyenTStudentDatabase.Services.StudentList;

public class StudentDatabaseService : IStudentDatabaseService
{
    private readonly DataContext _db;

    public StudentDatabaseService(DataContext db)
    {
        _db = db;
    }
    public List<StudentDatabase> AddStudent(string firstName, string lastName, string hobbies)
    {
        StudentDatabase newStudent = new();
        newStudent.FirstName = firstName;
        newStudent.LastName = lastName;
        newStudent.Hobbies = hobbies;
        _db.Students.Add(newStudent);
        _db.SaveChanges();
        return _db.Students.ToList();

    }

    public List<StudentDatabase> RemoveStudent(string firstName)
    {
       var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == firstName);
       if(student != null)
       {
        _db.Students.Remove(student);
       }
        _db.SaveChanges();
        return _db.Students.ToList();
    }

    public List<StudentDatabase> ReadStudent()
    {
        return _db.Students.ToList();
    }
}
