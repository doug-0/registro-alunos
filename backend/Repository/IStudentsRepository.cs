using backend.Model;

namespace backend.Repository
{
  public interface IStudentsRepository
  {
    Task<IEnumerable<Students>> GetAllStudents();
    Task<Students> GetStudent(int id);
    Task<Students> GetStudentByRa(int id);
    void CreateStudent(Students student);
    void UpdateStudent(Students student);
    void DeleteStudent(Students student);

    Task<bool> SaveChangesAsync();
  }
}