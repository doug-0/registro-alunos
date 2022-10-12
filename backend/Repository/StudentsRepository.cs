using backend.Data;
using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
  public class StudentsRepository : IStudentsRepository
  {
    private readonly StudentsContext _context;

    public StudentsRepository(StudentsContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<Students>> GetAllStudents()
    {
      return await _context.Students.ToListAsync();
    }

    public async Task<Students> GetStudent(int id)
    {
      return await _context.Students.Where(student => student.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Students> GetStudentByRa(int id)
    {
      return await _context.Students.Where(student => student.RA == id).FirstOrDefaultAsync();
    }


    public void CreateStudent(Students student)
    {
      _context.Add(student);
    }

    public void UpdateStudent(Students student)
    {
      _context.Update(student);
    }

    public void DeleteStudent(Students student)
    {
      _context.Remove(student);
    }

    public async Task<bool> SaveChangesAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}