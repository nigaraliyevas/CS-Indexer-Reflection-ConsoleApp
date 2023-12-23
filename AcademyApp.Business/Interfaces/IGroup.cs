using AcademyApp.Domain.Models;
namespace AcademyApp.Business.Interfaces
{
    public interface IGroup
    {
        Group Create(Group group);
        Group Get(int id);
        Group Delete(int id);
        Group Update(int id, Group groupName);
        List<Group> GetAll();
        List<Group> GetAll(int id);
    }
}
