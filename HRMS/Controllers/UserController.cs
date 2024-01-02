using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string GetUser()
        {
            return "User";
        }

        [HttpPost]
        public IActionResult AddEmployeeData([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}
