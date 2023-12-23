using AcademyApp.Domain.Models;

namespace AcademyApp.Business.Interfaces
{
    public interface IStudent
    {
        Student Create(Student student, string groupName);
        List<Student> GetAll();
        List<Student> GetAll(int age);
        List<Student> GetAll(string name);
        Student Get(int id);
        Student Update(int id, Student student, string groupName);
        Student Delete(int id);
    }
}
