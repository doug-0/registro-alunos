using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StudentsController : ControllerBase
  {
    [HttpGet]
    public string Get()
    {
      return "Ok";
    }
  }
}