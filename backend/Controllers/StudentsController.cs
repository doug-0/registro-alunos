using backend.Model;
using backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StudentsController : ControllerBase
  {
    private readonly IStudentsRepository _repository;

    public StudentsController(IStudentsRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> FindAllStudents()
    {
      var allStudents = await _repository.GetAllStudents();

      return allStudents.Any() ? Ok(allStudents) : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudentByRa(int id)
    {
      var student = await _repository.GetStudentByRa(id);

      return student == null ? Ok("Ok") : BadRequest("Registro Acadêmico já existe!");
    }

    [HttpPost]
    public async Task<IActionResult> NewStudents(Students students)
    {
      _repository.CreateStudent(students);

      return await _repository.SaveChangesAsync()
        ? Ok("Estudante adicionado com sucesso!")
        : BadRequest("Não foi possível criar cadastro do estudante.");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(int id, Students students)
    {
      var student = await _repository.GetStudent(id);

      if (student == null) return NotFound("Estudante não encontrado!");

      student.Name = students.Name ?? student.Name;
      student.Email = students.Email ?? student.Email;
      student.CPF = students.CPF ?? student.CPF;

      _repository.UpdateStudent(student);

      return await _repository.SaveChangesAsync()
        ? Ok("Estudante atualizado com sucesso!")
        : BadRequest("Não foi possível atualizar cadastro do estudante.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudents(int id, Students students)
    {
      var student = await _repository.GetStudent(id);

      if (student == null) return NotFound("Estudante não encontrado!");

      _repository.DeleteStudent(student);

      return await _repository.SaveChangesAsync()
        ? Ok("Registro excluído com sucesso!")
        : BadRequest("Não foi possível excluir cadastro do estudante.");
    }
  }
}